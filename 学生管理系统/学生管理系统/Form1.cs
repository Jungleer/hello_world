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
    public partial class Form1 : Form
    {
        public static DataRow[] dr=null;
        public static String successname = null;
        public static String successpass = null;
        public Form1()
        {
            InitializeComponent();

        }

        private void Login_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDate.dataTable;//获取到表格
            String Names = UserName.Text;
            String Pass = password.Text;
            String Choose = ChooseID.Text;
            
            bool flag = true;
            if (Names == "") MessageBox.Show("用户名不能为空","提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (Pass == "") MessageBox.Show("密码不能为空");
            if (Choose == "") MessageBox.Show("请选择教师或者学生进行登陆");
            if (Choose == "老师" && (Names != "admin" || Pass != "admin")) { flag = false; MessageBox.Show("教师密码输入错误"); }

            if (flag)
            {
                
                Teacher teacher = new Teacher();
                Student student = new Student();
                if (Choose == "老师")
                {
                    this.Hide();
                    teacher.Show();
                }  
                else
                {
                    dr = dt.Select("stuno='"+Names+"'"+"and pass='"+Pass+"'");
                    if (dr.Length == 0)
                        MessageBox.Show("没有该用户或者密码错误！");
                    else
                    {
                        this.Hide();
                        student.Show();
                        successname = Names;
                        successpass = Pass;
                    }
                }                   
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChooseID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
