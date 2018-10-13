using System;
using System.Windows.Forms;

namespace 学生管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.ChooseID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Login.Location = new System.Drawing.Point(107, 367);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(138, 43);
            this.Login.TabIndex = 0;
            this.Login.Text = "确认登陆";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(205, 43);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(138, 25);
            this.UserName.TabIndex = 5;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(110, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "密码";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(459, 43);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "身份选择";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(205, 97);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(138, 25);
            this.password.TabIndex = 13;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // ChooseID
            // 
            this.ChooseID.FormattingEnabled = true;
            this.ChooseID.Items.AddRange(new object[] {
            "学生",
            "老师"});
            this.ChooseID.Location = new System.Drawing.Point(107, 227);
            this.ChooseID.Name = "ChooseID";
            this.ChooseID.Size = new System.Drawing.Size(138, 23);
            this.ChooseID.TabIndex = 14;
            this.ChooseID.SelectedIndexChanged += new System.EventHandler(this.ChooseID_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 463);
            this.Controls.Add(this.ChooseID);
            this.Controls.Add(this.password);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Login);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "学生成绩管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox UserName;
        public System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox ChooseID;
    }
}

#endregion