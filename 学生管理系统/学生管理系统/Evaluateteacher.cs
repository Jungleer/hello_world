using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生管理系统
{
    public partial class Evaluateteacher : UserControl
    {
        public Evaluateteacher()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("D:\\"+Form1.successname+".txt",evaluateofstudents.Text,Encoding.Default);
            evaluateofstudents.Text = "";
        }
    }
}
