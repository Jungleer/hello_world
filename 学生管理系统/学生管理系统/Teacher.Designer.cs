namespace 学生管理系统
{
    partial class Teacher
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
            this.查看所有学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看学生寄语ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findstuno = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看所有学生信息ToolStripMenuItem,
            this.查看学生寄语ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查看所有学生信息ToolStripMenuItem
            // 
            this.查看所有学生信息ToolStripMenuItem.Name = "查看所有学生信息ToolStripMenuItem";
            this.查看所有学生信息ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.查看所有学生信息ToolStripMenuItem.Text = "查看所有学生信息";
            this.查看所有学生信息ToolStripMenuItem.Click += new System.EventHandler(this.查看所有学生信息ToolStripMenuItem_Click);
            // 
            // 查看学生寄语ToolStripMenuItem
            // 
            this.查看学生寄语ToolStripMenuItem.Name = "查看学生寄语ToolStripMenuItem";
            this.查看学生寄语ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.查看学生寄语ToolStripMenuItem.Text = "查看学生寄语";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(186, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "查看指定学号学生的评语";
            // 
            // findstuno
            // 
            this.findstuno.Location = new System.Drawing.Point(296, 72);
            this.findstuno.Name = "findstuno";
            this.findstuno.Size = new System.Drawing.Size(188, 25);
            this.findstuno.TabIndex = 2;
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(44, 128);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.Size = new System.Drawing.Size(439, 257);
            this.content.TabIndex = 3;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(535, 75);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(79, 22);
            this.find.TabIndex = 4;
            this.find.Text = "确定";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.find);
            this.Controls.Add(this.content);
            this.Controls.Add(this.findstuno);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Teacher";
            this.Text = "教师登陆界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看所有学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看学生寄语ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox findstuno;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Button find;
    }
}