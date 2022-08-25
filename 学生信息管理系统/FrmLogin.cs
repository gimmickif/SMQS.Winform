using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生信息管理系统
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strcon = "server = localhost; user = root; database = sms; password = 123456";
            MySqlConnection conn = new MySqlConnection(strcon);
            //建立数据库连接
            try
            {
                //开启连接           
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("数据库连接失败!");
            }
            FrmMain frm = new();
            string userid = tbUserId.Text.Trim();
            string pwd = tbPwd.Text.Trim();
            if (userid == "" || pwd == "")
            {
                MessageBox.Show("请输入用户名或密码！");
                return;
            }
            else
            {
                MySqlCommand cmd = conn.CreateCommand();
                MySqlDataAdapter adp = new();
                string sql = "select * from sms.userinfo where userid='" + userid + " 'and pwd='" + pwd + "' ";
                DataSet dat = new DataSet();
                cmd.CommandText = sql;
                adp.SelectCommand = cmd;
                adp.Fill(dat, "user");
                if (dat.Tables["user"].Rows.Count == 0)
                {
                    MessageBox.Show("用户名或密码错误！");
                    return;
                }
                else
                {
                    this.Hide();
                    frm.ShowDialog();
                    conn.Close();
                }
            }
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new();
            frm.frmLogin = this;
            frm.ShowDialog();
        }
    }
}