namespace 学生管理系统
{
    partial class DatesOfStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatesOfStudents));
            this.Dates = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.Tips = new System.Windows.Forms.TextBox();
            this.waring = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dates)).BeginInit();
            this.SuspendLayout();
            // 
            // Dates
            // 
            this.Dates.AllowDrop = true;
            this.Dates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dates.Location = new System.Drawing.Point(0, 0);
            this.Dates.Name = "Dates";
            this.Dates.RowTemplate.Height = 27;
            this.Dates.Size = new System.Drawing.Size(1206, 300);
            this.Dates.TabIndex = 0;
            this.Dates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dates_CellContentClick);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(100, 559);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(173, 73);
            this.save.TabIndex = 1;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Tips
            // 
            this.Tips.Location = new System.Drawing.Point(709, 332);
            this.Tips.Multiline = true;
            this.Tips.Name = "Tips";
            this.Tips.ReadOnly = true;
            this.Tips.Size = new System.Drawing.Size(360, 300);
            this.Tips.TabIndex = 2;
            this.Tips.Text = resources.GetString("Tips.Text");
            // 
            // waring
            // 
            this.waring.Location = new System.Drawing.Point(313, 332);
            this.waring.Multiline = true;
            this.waring.Name = "waring";
            this.waring.ReadOnly = true;
            this.waring.Size = new System.Drawing.Size(382, 299);
            this.waring.TabIndex = 3;
            this.waring.Text = resources.GetString("waring.Text");
            // 
            // DatesOfStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 765);
            this.Controls.Add(this.waring);
            this.Controls.Add(this.Tips);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Dates);
            this.Name = "DatesOfStudents";
            this.Text = "DatesOfStudents";
            this.Load += new System.EventHandler(this.DatesOfStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dates;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox Tips;
        private System.Windows.Forms.TextBox waring;
    }
}