using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backup_restore
{
    public partial class Frmdangnhap : Form
    {
        public Frmdangnhap()
        {
            InitializeComponent();
            txtServername.Text = "DESKTOP-E4N1MRS";
        }

        private void Frmdangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            Program.loginName = txtLoginname.Text;
            Program.password = txtPassword.Text;          
            if(Program.ConnectToDB() == 1 )
            {
                Frmdangnhap.ActiveForm.Visible = false;
                frmMain main = new frmMain();
                 main.Show();
          
            }
            else
            {
                return ;
            }
                
            
              
           
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
