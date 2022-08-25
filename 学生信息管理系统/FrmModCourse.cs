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
    public partial class FrmModCourse : Form
    {
        public FrmMain frmMain { get; set; }
        MySqlConnection sqlcon;
        MySqlCommand sqlcmd;
        MySqlDataAdapter sqlad;
        public FrmModCourse()
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
            string strSql1 = "select * from course";
            sqlcmd = new MySqlCommand(strSql1, sqlcon);
            sqlad = new MySqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);
            string strInfo = JsonConvert.SerializeObject(ds.Tables[0]);
            List<Course> s = JsonConvert.DeserializeObject<List<Course>>(strInfo);
            string id = tbNum.Text.ToString();
            string name = tbName.Text.ToString();
            if (id == "" || name == "")
            {
                MessageBox.Show("班级号或班级不能空！");
                return;
            }
            foreach (Course i in s)
            {
                if (i.Cno == id)
                {
                    string strSql2 = "update sms.course set  Cname = '" + name + "'  where  Cno= '" + id + "'";
                    MySqlCommand cmd = new MySqlCommand(strSql2, sqlcon);
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
