using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生管理系统
{
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void 查看所有学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatesOfStudents dates = new DatesOfStudents();
            dates.Show();
            
        }

        private void find_Click(object sender, EventArgs e)
        {
            if (findstuno.Text == "" || findstuno.Text == null) MessageBox.Show("请输入要看的学生学号！");
            else
            {
                if (File.Exists("D:\\" + findstuno.Text+ ".txt")) content.Text = File.ReadAllText("D:\\" + findstuno.Text + ".txt", Encoding.Default); 
                else
                {
                    content.Text = "";
                    MessageBox.Show("不存在该学生或者该学生未写评语");
                }
            }

        }
    }
}
