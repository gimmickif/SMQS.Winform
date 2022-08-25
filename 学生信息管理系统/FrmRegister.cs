using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 学生信息管理系统
{
    public partial class FrmRegister : Form
    {
        public FrmLogin frmLogin { get; set; }
        MySqlConnection sqlcon;
        MySqlCommand sqlcmd;
        string code;
        Random r = new Random();
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            setCode(4);
        }
        private void setCode(int length)
        {
            code = "";
            for (int i = 0; i < length; i++)
            {
                int type = r.Next(0, 2);//存在两次
                if (type == 0)
                {
                    code += r.Next(0, 9);
                }
                else if (type == 1)
                {
                    code += (char)r.Next(97, 123);
                }
            }
            if (string.IsNullOrWhiteSpace(code))
            {
                return;
            }
            Bitmap img = new(code.Length * 20 + 10, 30);
            Graphics graphics = Graphics.FromImage(img);
            graphics.Clear(Color.White);
            Pen pen = new(Color.Black, 1);
            graphics.DrawRectangle(pen, 0, 0, img.Width - 1, img.Height - 1);
            for (int i = 0; i < code.Length; i++)
            {
                Pen p = new(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)), r.Next(1, 2));//画线
                graphics.DrawLine(p, r.Next(0, img.Width), r.Next(0, img.Height), r.Next(img.Width), r.Next(0, img.Height));//线段的两个点
            }
            graphics.DrawString(code, new Font("宋体", 15, FontStyle.Italic | FontStyle.Bold), new SolidBrush(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255))), new Point(5, 5));
            for (int i = 0; i < code.Length * 20; i++)
            {
                graphics.FillEllipse(new SolidBrush(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255))), r.Next(0, img.Width), r.Next(0, img.Height), 2, 2);//绘制小圆点
            }
            pictureBox1.Image = img;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userid = tbUserId.Text.ToString();
            string pwd = tbPwd.Text.ToString();
            if (userid == "" || pwd == "")
            {
                MessageBox.Show("请输入用户名或密码！");
                tbUserId.Text = "";
                tbPwd.Text = "";
                return;
            }
            else
            {
                if (code.ToUpper().Equals(textBox1.Text.ToUpper()))
                {
                    try
                    {
                        string strcon = "server = localhost; user = root; database = sms; password = 123456";
                        //建立数据库连接
                        sqlcon = new MySqlConnection(strcon);
                        sqlcon.Open();
                        string strSql = "insert into sms.userinfo values('" + userid + "','" + pwd + "')";
                        sqlcmd = new MySqlCommand(strSql, sqlcon);
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show("注册成功!");
                        sqlcon.Close();
                    }
                    catch (Exception)
                    {
                    MessageBox.Show("数据库连接失败!");
                    }
            }
                else
                {
                    MessageBox.Show("验证码错误,请重新输入!");
                    setCode(4);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
