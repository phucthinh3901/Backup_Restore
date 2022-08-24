using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Data.SqlClient;
using System.Data;

namespace backup_restore
{
    static class Program
    {
        /// <summary>
        public static string Dbname = "";
        public static SqlConnection conn = new SqlConnection();
        public static String tmpConn = "Data source=DESKTOP-E4N1MRS; ;Integrated security=true";
        
        public static string connStr = "";
        public static string serverName = "DESKTOP-E4N1MRS";
        public static string loginName = "";
        public static string password = "";
        public static String defaultPath = "E:\\Thuc-Tap-Co-So\\Backup_Restore_Pj\\backup-restore_device\\";
        public static String des = "";
        public static SqlDataReader myReader;
        //public static frmMain frmchinh = new frmMain();
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            
            Application.Run(new Frmdangnhap());
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            Program.ConnectToDB();
            conn.Close();
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300; // Đợi lệnh chạy. đơn vị: giây.
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static void ExecSqlNonQuery(String strLenh)
        {
            Program.ConnectToDB();
            conn.Close();
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300; // Đợi lệnh chạy. đơn vị: giây.
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
               
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
               
            }
        }
        public static int ConnectToDB() //null thì lỗi, không null thì chạy
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connStr = "Data Source=" + Program.serverName + ";User ID=" + Program.loginName + ";password=" + Program.password;
               Program.conn.ConnectionString = connStr;
               // Program.conn = new SqlConnection(Program.connStr)
               
                Program.conn.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại username và password.\n" + ex.Message, "Lỗi kết nối!", MessageBoxButtons.OK);
                return 0;
            }
        }
    }
}
