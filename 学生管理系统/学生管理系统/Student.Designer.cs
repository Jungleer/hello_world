using System;
using System.Windows.Forms;

namespace 学生管理系统
{
    partial class Student
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
            this.成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师评价ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成绩查询ToolStripMenuItem,
            this.教师评价ToolStripMenuItem,
            this.返回登陆ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 成绩查询ToolStripMenuItem
            // 
            this.成绩查询ToolStripMenuItem.Name = "成绩查询ToolStripMenuItem";
            this.成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.成绩查询ToolStripMenuItem.Text = "成绩查询";
            this.成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.成绩查询ToolStripMenuItem_Click);
            // 
            // 教师评价ToolStripMenuItem
            // 
            this.教师评价ToolStripMenuItem.Name = "教师评价ToolStripMenuItem";
            this.教师评价ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.教师评价ToolStripMenuItem.Text = "教师评价";
            this.教师评价ToolStripMenuItem.Click += new System.EventHandler(this.教师评价ToolStripMenuItem_Click_1);
            // 
            // 返回登陆ToolStripMenuItem
            // 
            this.返回登陆ToolStripMenuItem.Name = "返回登陆ToolStripMenuItem";
            this.返回登陆ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.返回登陆ToolStripMenuItem.Text = "返回登陆";
            this.返回登陆ToolStripMenuItem.Click += new System.EventHandler(this.返回登陆ToolStripMenuItem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 420);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 成绩查询ToolStripMenuItem;
        private ToolStripMenuItem 教师评价ToolStripMenuItem;
        private ToolStripMenuItem 返回登陆ToolStripMenuItem;
        private GroupBox groupBox1;
    }
}