namespace 学生信息管理系统
{
    partial class FrmModClazz
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
            this.tbClazzName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbClazzId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbClazzName
            // 
            this.tbClazzName.Location = new System.Drawing.Point(96, 72);
            this.tbClazzName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbClazzName.Name = "tbClazzName";
            this.tbClazzName.Size = new System.Drawing.Size(125, 27);
            this.tbClazzName.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "班级名";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(139, 116);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbClazzId
            // 
            this.tbClazzId.Location = new System.Drawing.Point(96, 32);
            this.tbClazzId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbClazzId.Name = "tbClazzId";
            this.tbClazzId.Size = new System.Drawing.Size(125, 27);
            this.tbClazzId.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "班级号";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(39, 116);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 29);
            this.btnConfirm.TabIndex = 27;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmModClazz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 180);
            this.Controls.Add(this.tbClazzName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbClazzId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConfirm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmModClazz";
            this.Text = "FrmModClazz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbClazzName;
        private Label label1;
        private Button btnCancel;
        private TextBox tbClazzId;
        private Label label5;
        private Button btnConfirm;
    }
}