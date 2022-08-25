namespace 学生信息管理系统
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.学生管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStu = new System.Windows.Forms.ToolStripMenuItem();
            this.DelStu = new System.Windows.Forms.ToolStripMenuItem();
            this.ModStu = new System.Windows.Forms.ToolStripMenuItem();
            this.FindStu = new System.Windows.Forms.ToolStripMenuItem();
            this.lstStu = new System.Windows.Forms.ToolStripMenuItem();
            this.课程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.DelCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.ModCouse = new System.Windows.Forms.ToolStripMenuItem();
            this.FindCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.lstCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddScore = new System.Windows.Forms.ToolStripMenuItem();
            this.DelScore = new System.Windows.Forms.ToolStripMenuItem();
            this.ModScore = new System.Windows.Forms.ToolStripMenuItem();
            this.FindScore = new System.Windows.Forms.ToolStripMenuItem();
            this.lstScore = new System.Windows.Forms.ToolStripMenuItem();
            this.班级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClazz = new System.Windows.Forms.ToolStripMenuItem();
            this.DelClazz = new System.Windows.Forms.ToolStripMenuItem();
            this.ModClazz = new System.Windows.Forms.ToolStripMenuItem();
            this.FindClazz = new System.Windows.Forms.ToolStripMenuItem();
            this.lstClazz = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.学生管理ToolStripMenuItem,
            this.课程管理ToolStripMenuItem,
            this.成绩管理ToolStripMenuItem,
            this.班级ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(622, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 学生管理ToolStripMenuItem
            // 
            this.学生管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStu,
            this.DelStu,
            this.ModStu,
            this.FindStu,
            this.lstStu});
            this.学生管理ToolStripMenuItem.Name = "学生管理ToolStripMenuItem";
            this.学生管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.学生管理ToolStripMenuItem.Text = "学生管理";
            // 
            // AddStu
            // 
            this.AddStu.Name = "AddStu";
            this.AddStu.Size = new System.Drawing.Size(100, 22);
            this.AddStu.Text = "新增";
            this.AddStu.Click += new System.EventHandler(this.AddStu_Click);
            // 
            // DelStu
            // 
            this.DelStu.Name = "DelStu";
            this.DelStu.Size = new System.Drawing.Size(100, 22);
            this.DelStu.Text = "删除";
            this.DelStu.Click += new System.EventHandler(this.DelStu_Click);
            // 
            // ModStu
            // 
            this.ModStu.Name = "ModStu";
            this.ModStu.Size = new System.Drawing.Size(100, 22);
            this.ModStu.Text = "修改";
            this.ModStu.Click += new System.EventHandler(this.ModStu_Click);
            // 
            // FindStu
            // 
            this.FindStu.Name = "FindStu";
            this.FindStu.Size = new System.Drawing.Size(100, 22);
            this.FindStu.Text = "查找";
            this.FindStu.Click += new System.EventHandler(this.FindStu_Click);
            // 
            // lstStu
            // 
            this.lstStu.Name = "lstStu";
            this.lstStu.Size = new System.Drawing.Size(100, 22);
            this.lstStu.Text = "列表";
            this.lstStu.Click += new System.EventHandler(this.lstStu_Click);
            // 
            // 课程管理ToolStripMenuItem
            // 
            this.课程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCourse,
            this.DelCourse,
            this.ModCouse,
            this.FindCourse,
            this.lstCourse});
            this.课程管理ToolStripMenuItem.Name = "课程管理ToolStripMenuItem";
            this.课程管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.课程管理ToolStripMenuItem.Text = "课程管理";
            // 
            // AddCourse
            // 
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(100, 22);
            this.AddCourse.Text = "新增";
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // DelCourse
            // 
            this.DelCourse.Name = "DelCourse";
            this.DelCourse.Size = new System.Drawing.Size(100, 22);
            this.DelCourse.Text = "删除";
            this.DelCourse.Click += new System.EventHandler(this.DelCourse_Click);
            // 
            // ModCouse
            // 
            this.ModCouse.Name = "ModCouse";
            this.ModCouse.Size = new System.Drawing.Size(100, 22);
            this.ModCouse.Text = "修改";
            this.ModCouse.Click += new System.EventHandler(this.ModCouse_Click);
            // 
            // FindCourse
            // 
            this.FindCourse.Name = "FindCourse";
            this.FindCourse.Size = new System.Drawing.Size(100, 22);
            this.FindCourse.Text = "查找";
            this.FindCourse.Click += new System.EventHandler(this.FindCourse_Click);
            // 
            // lstCourse
            // 
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(100, 22);
            this.lstCourse.Text = "列表";
            this.lstCourse.Click += new System.EventHandler(this.lstCourse_Click);
            // 
            // 成绩管理ToolStripMenuItem
            // 
            this.成绩管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddScore,
            this.DelScore,
            this.ModScore,
            this.FindScore,
            this.lstScore});
            this.成绩管理ToolStripMenuItem.Name = "成绩管理ToolStripMenuItem";
            this.成绩管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成绩管理ToolStripMenuItem.Text = "成绩管理";
            // 
            // AddScore
            // 
            this.AddScore.Name = "AddScore";
            this.AddScore.Size = new System.Drawing.Size(100, 22);
            this.AddScore.Text = "新增";
            this.AddScore.Click += new System.EventHandler(this.AddScore_Click);
            // 
            // DelScore
            // 
            this.DelScore.Name = "DelScore";
            this.DelScore.Size = new System.Drawing.Size(100, 22);
            this.DelScore.Text = "删除";
            this.DelScore.Click += new System.EventHandler(this.DelScore_Click);
            // 
            // ModScore
            // 
            this.ModScore.Name = "ModScore";
            this.ModScore.Size = new System.Drawing.Size(100, 22);
            this.ModScore.Text = "修改";
            this.ModScore.Click += new System.EventHandler(this.ModScore_Click);
            // 
            // FindScore
            // 
            this.FindScore.Name = "FindScore";
            this.FindScore.Size = new System.Drawing.Size(100, 22);
            this.FindScore.Text = "查找";
            this.FindScore.Click += new System.EventHandler(this.FindScore_Click);
            // 
            // lstScore
            // 
            this.lstScore.Name = "lstScore";
            this.lstScore.Size = new System.Drawing.Size(100, 22);
            this.lstScore.Text = "列表";
            this.lstScore.Click += new System.EventHandler(this.lstScore_Click);
            // 
            // 班级ToolStripMenuItem
            // 
            this.班级ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClazz,
            this.DelClazz,
            this.ModClazz,
            this.FindClazz,
            this.lstClazz});
            this.班级ToolStripMenuItem.Name = "班级ToolStripMenuItem";
            this.班级ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.班级ToolStripMenuItem.Text = "班级管理";
            // 
            // AddClazz
            // 
            this.AddClazz.Name = "AddClazz";
            this.AddClazz.Size = new System.Drawing.Size(100, 22);
            this.AddClazz.Text = "新增";
            this.AddClazz.Click += new System.EventHandler(this.AddClazz_Click);
            // 
            // DelClazz
            // 
            this.DelClazz.Name = "DelClazz";
            this.DelClazz.Size = new System.Drawing.Size(100, 22);
            this.DelClazz.Text = "删除";
            this.DelClazz.Click += new System.EventHandler(this.DelClazz_Click);
            // 
            // ModClazz
            // 
            this.ModClazz.Name = "ModClazz";
            this.ModClazz.Size = new System.Drawing.Size(100, 22);
            this.ModClazz.Text = "修改";
            this.ModClazz.Click += new System.EventHandler(this.ModClazz_Click);
            // 
            // FindClazz
            // 
            this.FindClazz.Name = "FindClazz";
            this.FindClazz.Size = new System.Drawing.Size(100, 22);
            this.FindClazz.Text = "查找";
            this.FindClazz.Click += new System.EventHandler(this.FindClazz_Click);
            // 
            // lstClazz
            // 
            this.lstClazz.Name = "lstClazz";
            this.lstClazz.Size = new System.Drawing.Size(100, 22);
            this.lstClazz.Text = "列表";
            this.lstClazz.Click += new System.EventHandler(this.lstClazz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(604, 342);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 382);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 学生管理ToolStripMenuItem;
        private ToolStripMenuItem AddStu;
        private ToolStripMenuItem DelStu;
        private ToolStripMenuItem ModStu;
        private ToolStripMenuItem FindStu;
        private ToolStripMenuItem lstStu;
        private DataGridView dataGridView1;
        private ToolStripMenuItem 课程管理ToolStripMenuItem;
        private ToolStripMenuItem AddCourse;
        private ToolStripMenuItem DelCourse;
        private ToolStripMenuItem ModCouse;
        private ToolStripMenuItem FindCourse;
        private ToolStripMenuItem lstCourse;
        private ToolStripMenuItem 成绩管理ToolStripMenuItem;
        private ToolStripMenuItem AddScore;
        private ToolStripMenuItem DelScore;
        private ToolStripMenuItem ModScore;
        private ToolStripMenuItem FindScore;
        private ToolStripMenuItem lstScore;
        private ToolStripMenuItem 班级ToolStripMenuItem;
        private ToolStripMenuItem AddClazz;
        private ToolStripMenuItem DelClazz;
        private ToolStripMenuItem ModClazz;
        private ToolStripMenuItem FindClazz;
        private ToolStripMenuItem lstClazz;
    }
}