using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生管理系统
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        public FindScore f;
        public Evaluateteacher et;

        private void Student_Load(object sender, EventArgs e)
        {
            f = new FindScore();
            et = new Evaluateteacher();

        }

        private void Scorelist_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 返回登陆ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void 教师评价ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            et.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(et);
        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(f);
        }
    }
}
