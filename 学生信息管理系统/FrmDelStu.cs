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
    public partial class FrmDelStu : Form
    {
        public FrmMain frmMain { get; set; }
        MySqlConnection sqlcon;
        public FrmDelStu()
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
            string stuId = tbNum.Text.ToString();
            if (stuId == "")
            {
                MessageBox.Show("请输入学号！");
                return;
            }
            //反序列化对象
            string strSql1 = "select * from student";
            MySqlCommand sqlcmd = new MySqlCommand(strSql1, sqlcon);
            MySqlDataAdapter sqlad = new MySqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);
            string strInfo = JsonConvert.SerializeObject(ds.Tables[0]);
            List<Student> c = JsonConvert.DeserializeObject<List<Student>>(strInfo);
            int sign = 0;
            //查找对象
            foreach(Student i in c)
            {
                if (i.Sno == stuId)
                {
                    string strSql2 = "delete from sms.student where Sno = '"+stuId+"'";
                    MySqlCommand cmd = new MySqlCommand(strSql2, sqlcon);
                    cmd.ExecuteNonQuery();
                    sign++;
                }
            }
            if (sign != 0)
            {
                MessageBox.Show("删除成功");
            }
            else
                MessageBox.Show("未找到该学生，请重新输入学号");
        }
    }
}
