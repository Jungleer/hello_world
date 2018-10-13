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
    public partial class FindScore : UserControl
    {
        public FindScore()
        {
            InitializeComponent();
        }

        private void FindScore_Load(object sender, EventArgs e)
        {
            DataRow[] dr = Form1.dr;
            cs.Text = dr[0]["cs"].ToString();
            ms.Text = dr[0]["ms"].ToString();
            es.Text = dr[0]["es"].ToString();
            ps.Text = dr[0]["ps"].ToString();
            ches.Text = dr[0]["ches"].ToString();
            bs.Text = dr[0]["bs"].ToString();
            StudentDate astudent = new StudentDate(Form1.successname,Form1.successpass,Convert.ToSingle(cs.Text),
                Convert.ToSingle(ms.Text), Convert.ToSingle(es.Text), Convert.ToSingle(ps.Text), Convert.ToSingle(ches.Text), Convert.ToSingle(bs.Text));
            Max.Text = astudent.MaxScore.ToString();
            Min.Text = astudent.MinScore.ToString();
            total.Text = astudent.TotalScore.ToString();
            avg.Text = astudent.AvgScore.ToString();
            
        }
    }
}
