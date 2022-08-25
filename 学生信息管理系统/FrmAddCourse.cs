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
    public partial class FrmAddCourse : Form
    {
        public FrmMain frmMain { get; set; }
        MySqlConnection sqlcon;
        MySqlCommand sqlcmd;
        public FrmAddCourse()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
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
            string id = this.tbNum.Text.ToString();
            string name = this.tbName.Text.ToString();
            if (id == "" || name == "")
            {
                MessageBox.Show("请输入课程号或课程名！");
                return;
            }
            else
            {
                try
                {
                    string strSql = "insert into sms.course values('" + id + "','" + name + "')";
                    sqlcmd = new MySqlCommand(strSql, sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("新增成功");
                    sqlcon.Close();
                }
                catch
                {
                MessageBox.Show("新增失败");
                 }
           }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            sqlcon.Close();
        }
    }
}
