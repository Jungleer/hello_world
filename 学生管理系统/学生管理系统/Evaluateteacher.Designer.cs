namespace 学生管理系统
{
    partial class Evaluateteacher
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.evaluateofstudents = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(31, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(183, 18);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "请写下你对老师们的评语";
            // 
            // evaluateofstudents
            // 
            this.evaluateofstudents.Location = new System.Drawing.Point(32, 76);
            this.evaluateofstudents.Multiline = true;
            this.evaluateofstudents.Name = "evaluateofstudents";
            this.evaluateofstudents.Size = new System.Drawing.Size(667, 307);
            this.evaluateofstudents.TabIndex = 1;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(705, 352);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(70, 31);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Evaluateteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.evaluateofstudents);
            this.Controls.Add(this.textBox1);
            this.Name = "Evaluateteacher";
            this.Size = new System.Drawing.Size(800, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox evaluateofstudents;
        private System.Windows.Forms.Button confirm;
    }
}
