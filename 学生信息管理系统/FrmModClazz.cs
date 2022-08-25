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
    public partial class FrmModClazz : Form
    {
        public FrmMain frmMain { get; set; }
        MySqlConnection sqlcon;
        MySqlCommand sqlcmd;
        MySqlDataAdapter sqlad;
        public FrmModClazz()
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
            string strSql1 = "select * from clazz";
            sqlcmd = new MySqlCommand(strSql1, sqlcon);
            sqlad = new MySqlDataAdapter(sqlcmd);
            DataSet ds = new();
            sqlad.Fill(ds);
            string strInfo = JsonConvert.SerializeObject(ds.Tables[0]);
            List<Clazz> s = JsonConvert.DeserializeObject<List<Clazz>>(strInfo);
            string clazzid = tbClazzId.Text.ToString();
            string clazzname = tbClazzName.Text.ToString();
            if (clazzid == "" || clazzname == "")
            {
                MessageBox.Show("班级号或班级不能空！");
                return;
            }
            foreach (Clazz i in s)
            {
                if (i.Clzno == clazzid)
                {
                    string strSql2 = "update sms.clazz set  Clzname = '" + clazzname + "'  where  Clzno = '" +  clazzid + "'";
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
