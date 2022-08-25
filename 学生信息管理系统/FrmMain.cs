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
    public partial class FrmMain : Form
    {
        public FrmLogin frmLogin { get; set; }
        MySqlConnection sqlcon;
        MySqlCommand sqlcmd;
        MySqlDataAdapter sqlad;
        public FrmMain()
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
        #region  学生管理
        private void AddStu_Click(object sender, EventArgs e)
        {
            FrmAddStu frm = new();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void DelStu_Click(object sender, EventArgs e)
        {
            FrmDelStu frm = new FrmDelStu();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void ModStu_Click(object sender, EventArgs e)
        {
            FrmModStu frm = new FrmModStu();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void FindStu_Click(object sender, EventArgs e)
        {
            FrmFindStu frm = new ();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void lstStu_Click(object sender, EventArgs e)
        {
            string strSql1 = "select * from student";
            sqlcmd = new MySqlCommand(strSql1, sqlcon);
            sqlad = new MySqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);
            string strInfo = JsonConvert.SerializeObject(ds.Tables[0]);
            List<Student> lst = JsonConvert.DeserializeObject<List<Student>>(strInfo);
            dataGridView1.DataSource = new BindingList<Student>(lst);
        }
        #endregion

        #region  课程管理
        private void AddCourse_Click(object sender, EventArgs e)
        {
            FrmAddCourse frm = new FrmAddCourse();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void DelCourse_Click(object sender, EventArgs e)
        {
            FrmDelCourse frm = new FrmDelCourse();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void ModCouse_Click(object sender, EventArgs e)
        {
            FrmModCourse frm = new FrmModCourse();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void FindCourse_Click(object sender, EventArgs e)
        {
            FrmFindCourse frm = new FrmFindCourse();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void lstCourse_Click(object sender, EventArgs e)
        {
            string strSql = "select * from course";
            sqlcmd = new MySqlCommand(strSql, sqlcon);
            sqlad = new MySqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);
            string strInfo = JsonConvert.SerializeObject(ds.Tables[0]);
            List<Course> lst = JsonConvert.DeserializeObject<List<Course>>(strInfo);
            dataGridView1.DataSource = new BindingList<Course>(lst);
        }
        #endregion

        #region  成绩管理
        private void AddScore_Click(object sender, EventArgs e)
        {
            FrmAddGrade frm = new FrmAddGrade();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void DelScore_Click(object sender, EventArgs e)
        {
            FrmDelGrade frm = new FrmDelGrade();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void ModScore_Click(object sender, EventArgs e)
        {
            FrmModGrade frm = new FrmModGrade();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void FindScore_Click(object sender, EventArgs e)
        {
            FrmFindGrade frm = new FrmFindGrade();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void lstScore_Click(object sender, EventArgs e)
        {
            string strSql = "select * from grade";
            sqlcmd = new MySqlCommand(strSql, sqlcon);
            sqlad = new MySqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);
            string strInfo = JsonConvert.SerializeObject(ds.Tables[0]);
            List<Grade> lst = JsonConvert.DeserializeObject<List<Grade>>(strInfo);
            dataGridView1.DataSource = new BindingList<Grade>(lst);
        }
        #endregion

        #region 班级管理
        private void AddClazz_Click(object sender, EventArgs e)
        {
            FrmAddClazz frm = new FrmAddClazz();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void DelClazz_Click(object sender, EventArgs e)
        {
            FrmDelClazz frm = new FrmDelClazz();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void ModClazz_Click(object sender, EventArgs e)
        {
            FrmModClazz frm = new FrmModClazz();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void FindClazz_Click(object sender, EventArgs e)
        {
            FrmFindClazz frm = new FrmFindClazz();
            frm.frmMain = this;
            frm.ShowDialog();
        }

        private void lstClazz_Click(object sender, EventArgs e)
        {
            string strSql = "select * from clazz";
            sqlcmd = new MySqlCommand(strSql, sqlcon);
            sqlad = new MySqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            sqlad.Fill(ds);
            string strInfo = JsonConvert.SerializeObject(ds.Tables[0]);
            List<Clazz> lst = JsonConvert.DeserializeObject<List<Clazz>>(strInfo);
            dataGridView1.DataSource = new BindingList<Clazz>(lst);
        }
        #endregion
    }
}