using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生信息管理系统
{
    public partial class FrmAddStu : Form
    {
        public FrmMain frmMain { get; set; }
        MySqlConnection sqlcon;
        MySqlCommand sqlcmd;
        public FrmAddStu()
        {
            InitializeComponent();
            string strcon = "server = localhost; user = root; database = sms; password = 123456";
            //建立数据库连接
            sqlcon = new MySqlConnection(strcon);
            try
            {
                //开启连接           
                sqlcon.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("数据库连接失败!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            sqlcon.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string stuname = this.tbName.Text.ToString();
            string stuid = this.tbNum.Text.ToString();
            string clzid = this.tbClazzId.Text.ToString();
            if (stuid == "" || stuname == "" || clzid == "")
            {
                MessageBox.Show("请输入姓名或学号或班级号！");
                return;
            }
            else
            {
                try
                {
                    string strSql = "insert into sms.student values('" + stuid + "','" + stuname + "', + '" + clzid + "')";
                    sqlcmd = new MySqlCommand(strSql, sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("新增成功");
                }
                catch
                {
                    MessageBox.Show("新增失败！班级可能不存在！");
                }
            }
        }
    }
}

