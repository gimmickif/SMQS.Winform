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
    public partial class FrmAddGrade : Form
    {
        public FrmMain frmMain { get; set; }
        MySqlConnection sqlcon;
        MySqlCommand sqlcmd;
        public FrmAddGrade()
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string id = this.tbNum.Text.ToString();
            string courseid = this.tbCourseId.Text.ToString();
            string grade = this.tbScore.Text.ToString();
            if (id == "" ||courseid== "" || grade == "")
            {
                MessageBox.Show("请输入学号或课程号或成绩！");
                return;
            }
            else
            {
                try
                {
                    string strSql = "insert into sms.grade values('" + id + "','" + courseid + "', + '" + grade + "')";
                    sqlcmd = new MySqlCommand(strSql, sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("新增成功");
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
