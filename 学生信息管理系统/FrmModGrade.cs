using MySql.Data.MySqlClient;
using Newtonsoft.Json;
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
    public partial class FrmModGrade : Form
    {
        public FrmMain frmMain { get; set; }
        MySqlConnection sqlcon;
        MySqlCommand sqlcmd;
        MySqlDataAdapter sqlad;
        public FrmModGrade()
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
            string strSql1 = "select * from grade";
            sqlcmd = new MySqlCommand(strSql1, sqlcon);
            sqlad = new MySqlDataAdapter(sqlcmd);
            DataSet ds = new();
            sqlad.Fill(ds);
            string strInfo = JsonConvert.SerializeObject(ds.Tables[0]);
            List<Grade> s = JsonConvert.DeserializeObject<List<Grade>>(strInfo);
            string stuid = tbNum.Text.ToString();
            string courseid = tbCourseId.Text.ToString();
            string score = tbGrade.Text.ToString();
            if (stuid == "" || courseid == "" || score =="")
            {
                MessageBox.Show("学号号或课程号或成绩不能空！");
                return;
            }
            foreach (Grade i in s)
            {
                if (i.Sno == stuid || i.Cno == courseid )
                {
                    string strSql2 = "update sms.grade set  Score = '" + score + "'  where  Cno= '" + courseid + "' and Sno = '" + stuid + "'";
                    MySqlCommand cmd = new(strSql2, sqlcon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功！");
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
