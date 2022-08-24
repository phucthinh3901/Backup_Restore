using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace backup_restore
{
   
    public partial class frmMain : System.Windows.Forms.Form
    {
        public static string sqlQuery="";
        public static string position="";
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bK_RSDataSet.databases' table. You can move, or remove it, as needed.
            this.databasesTableAdapter.Fill(this.bK_RSDataSet.databases);
            Program.Dbname = databasesDataGridView.Rows[0].Cells[0].Value.ToString();
            this.bK_RSTableAdapter.Fill(this.bK_RSDataSet.BK_RS, Program.Dbname);
            //Program.Dbname = ((DataRowView)databasesBindingSource[0])["name"].ToString().Trim(); 
            this.dateEdit.Value = DateTime.Now;
            hideNAME.Text = Program.Dbname;
            menuDeviceLighting();

        }
        private void databasesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.Dbname = ((DataRowView)databasesBindingSource[databasesBindingSource.Position])["name"].ToString().Trim();  // bat su kien click 
            this.bK_RSTableAdapter.Fill(this.bK_RSDataSet.BK_RS, Program.Dbname);
            menuDeviceLighting();
            hideNAME.Text = Program.Dbname;
        }
        private void bK_RSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = ((DataRowView)bK_RSBindingSource[bK_RSBindingSource.Position])["position"].ToString();
            vesionBk.Text = position;
        }
        
        private void btnSaoluu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmText frm = new frmText();
            DialogResult dr = frm.ShowDialog();
            if(dr == DialogResult.OK)
            {
                Program.des = frm.getText();
                string dk = "with description =''";
                sqlQuery = "USE master BACKUP DATABASE " + Program.Dbname + " TO DEV_" + Program.Dbname;
                if (chk_XoaBK.Checked == true)
                {
                    dk = " with init";
                }
                sqlQuery = "backup database " + Program.Dbname + " to disk = " + "'E:\\Thuc-Tap-Co-So\\Backup_Restore_Pj\\backup-restore_device\\" + "DEV_" + Program.Dbname + ".bak' " + dk
                 + ", name = '" + Program.des + "';";
                Program.myReader = Program.ExecSqlDataReader(sqlQuery);
                if (Program.myReader != null)
                {
                    MessageBox.Show("Tạo bản sao lưu thành công ");
                }
                else
                {
                    MessageBox.Show("Tạo bản sao lưu thất bại ");
                }
                Program.myReader.Close();   
            }
            else if (dr == DialogResult.Cancel)
            {
                frm.Close();
            }
            
            this.bK_RSTableAdapter.Fill(this.bK_RSDataSet.BK_RS, Program.Dbname);
            menuDeviceLighting();
        }
        private void btnTaoDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sqlQuery = "USE master EXEC sp_addumpdevice 'disk', " +
                       "'" + "DEV_" + Program.Dbname + "', " +
                       "'" + Program.defaultPath + "DEV_" + Program.Dbname + ".bak'";

            Program.myReader = Program.ExecSqlDataReader(sqlQuery);
            if (Program.myReader != null)
            {
                MessageBox.Show("Tạo Device thành công.");
            }
            else
            {
                MessageBox.Show("Tạo Device thất bại!");
            }
            Program.myReader.Close();
            menuDeviceLighting();
        }        
        private bool CheckHasDevice()
        {
          
            String sqlQuery = "USE master SELECT name FROM sys.backup_devices where name like " + "'%" + Program.Dbname + "%'"; // lay tat ca database so sanh voi DB co chua co thi them vao
            Program.myReader = Program.ExecSqlDataReader(sqlQuery);
            while (Program.myReader.Read())
            {              
                Program.myReader.Close();
                return true;
               
            }
                return false;
        }
        private void menuDeviceLighting()
        {
            if (CheckHasDevice())
            {
                btnTaodevice.Enabled = false;

                btnSaoluu.Enabled = true;
                btnPhuchoi.Enabled = true;
                chk_Thamsotg.Enabled = true;
                chk_XoaBK.Enabled = true;
                btnXoaBk.Enabled = true;
              //  bK_RSDataGridView.Enabled = true;
            }
            else
            {
                btnTaodevice.Enabled = true;

                btnSaoluu.Enabled = false;
                btnPhuchoi.Enabled = false;
                chk_Thamsotg.Enabled = false;
                chk_XoaBK.Enabled = false;
                btnXoaBk.Enabled = false;
               // bK_RSDataGridView.Enabled = false;
            }
        }        
        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {       
            if(chk_Thamsotg.Checked == false)
            {
                if(position == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản sao lưu.");
                    return;

                }
                
                sqlQuery = "USE master ALTER DATABASE " + Program.Dbname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE USE tempdb "
                    + " RESTORE DATABASE " + Program.Dbname + " From DEV_" +Program.Dbname + " with FILE= " +
                      position + ", REPLACE ALTER DATABASE "
                     + Program.Dbname + " SET MULTI_USER";
                
               
            }
            else
            {
                NoteRS frm = new NoteRS();
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    if (((dateEdit.Value).Minute - (DateTime.Now).Minute) > -1)
                    {
                        MessageBox.Show("Thời gian chọn phải nhỏ hơn thời gian hiện tại ít nhất 1 phút");
                        return;
                    }
                    bK_RSBindingSource.MoveFirst();   // Đưa position trong gridView lên trên cùng
                    position = ((DataRowView)bK_RSBindingSource[bK_RSBindingSource.Position])["position"].ToString();
                    DateTime timeBackup = (DateTime)((DataRowView)bK_RSBindingSource[bK_RSBindingSource.Position])["backup_start_date"];


                    int lessNow = (timeBackup - dateEdit.Value).Minutes;
                    if (lessNow <= -1)
                    {
                        sqlQuery = "ALTER DATABASE " + Program.Dbname + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE USE master " +
                            " BACKUP LOG " + Program.Dbname + " TO DISK ='" + Program.defaultPath + "DEV_" + Program.Dbname + ".trn' WITH INIT, NORECOVERY" +
                            " USE master " +
                            " RESTORE DATABASE " + Program.Dbname + " FROM " + "DEV_" + Program.Dbname + " WITH FILE =" + position + ", NORECOVERY, REPLACE" +
                            " RESTORE DATABASE " + Program.Dbname + " FROM DISK ='" + Program.defaultPath + "DEV_" + Program.Dbname + ".trn' WITH STOPAT ='" + dateEdit.Value + "'"
                            + " ALTER DATABASE " + Program.Dbname + " SET MULTI_USER";
                    }  else
                    {
                        MessageBox.Show("Thời gian chọn phải sau bản backup mới nhất 3 phút");
                        return;
                    }                                       
                                                            
                }
                else if (dr == DialogResult.Cancel)
                {
                    frm.Close();
                    return;
                }                
            }
            
            try
            {
                    Program.ExecSqlNonQuery(sqlQuery);
                    MessageBox.Show("Phục hồi thành công.");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Phục hồi thất bại.");
            }                 
                
            
           
        }
        private void chk_Thamsotg_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (chk_Thamsotg.Checked)
            {
                HidePanal_EditEtime.Visible = true;
            }
            else
            {
                HidePanal_EditEtime.Visible = false;
            }
                       
        }
        private void btnXoaBk_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Xoa tat ca cac bang bk o tat ca DATABASE
            //sqlQuery = "Use msdb EXEC sp_delete_backuphistory @oldest_date = '" + DateTime.Now + "';";
            //Program.myReader = Program.ExecSqlDataReader(sqlQuery);
            //if(Program.myReader != null)
            //{
            //    MessageBox.Show("Xoá bản sao lưu thành công.");
            //}
            //else
            //{
            //    MessageBox.Show("Xoá bản sao lưu thất bại.");
            //}

            //this.bK_RSTableAdapter.Fill(this.bK_RSDataSet.BK_RS, Program.Dbname);
            //  string bk_id = ((DataRowView)bK_RSBindingSource[bK_RSBindingSource.Position])["backup_set_id"].ToString();
            // xoa tung bang BK 
            //position = ((DataRowView)bK_RSBindingSource[bK_RSBindingSource.Position])["position"].ToString();
            //if(position == "1")
            //{
            //    MessageBox.Show("không cho xoá bản thứ nhất.");
            //    return;
            //}
            //else
            //{
            //    sqlQuery = "delete from msdb.dbo.backupfilegroup where backup_set_id = " + bk_id +
            //               "delete from msdb.dbo.backupfile where backup_set_id = " + bk_id +
            //               "delete from msdb.dbo.backupset where backup_set_id = " + bk_id;
            //    Program.ExecSqlNonQuery(sqlQuery);
            //    this.bK_RSTableAdapter.Fill(this.bK_RSDataSet.BK_RS, Program.Dbname);
            //}
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chk_XoaBK_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
