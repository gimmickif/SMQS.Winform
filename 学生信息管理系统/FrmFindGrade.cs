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
    public partial class FrmFindGrade : Form
    {
        public FrmMain frmMain { get; set; }
        MySqlConnection sqlcon;
        MySqlCommand sqlcmd;
        MySqlDataAdapter sqlad;
        public FrmFindGrade()
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            string com = tbCom.Text.ToString();
            if (com == "")
            {
                MessageBox.Show("请输入查询条件！");
                return;
            }
            string strSql = "select clazz.Clzno,student.Sno,clazz.Clzname,course.Cname,student.Sname,grade.Score from grade,student,course,clazz where grade.Sno = student.Sno and clazz.Clzno = student.Clzno and course.Cno = grade.Cno ";
            sqlcmd = new MySqlCommand(strSql, sqlcon);
            sqlad = new MySqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);
            string strInfo = JsonConvert.SerializeObject(ds.Tables[0]);
            List<clazzGrade> cg = JsonConvert.DeserializeObject<List<clazzGrade>>(strInfo);
            List<clazzGrade> obj = (from s in cg
                                    where s.Clzno.Contains(com)||s.Sno.Contains(com)
                                orderby(s.Score)   select s).ToList();
            this.dataGridView1.DataSource = obj;
            sqlcon.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            sqlcon.Close();
        }
    }
}
