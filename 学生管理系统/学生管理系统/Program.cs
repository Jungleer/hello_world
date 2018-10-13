using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 学生管理系统
{
    static class Program
    {
        
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 basic = new Form1();
            Application.Run(basic);
        }

    }
    
    public class GetDate
    {
        public static DataTable dataTable= DatesOfStudents.getData().Tables[0];
        static ArraySegment<StudentDate> GetStudentDates()
        {
           
            return new ArraySegment<StudentDate>();
        }
    }

    public class StudentDate
    {
        public String stuno;
        public String pass;
        public float ChineseScore;
        public float MathScore;
        public float EnglishScore;
        public float PhyciseScore;
        public float ChemistryScore;
        public float BiologyScore;
        public float TotalScore;
        public float MaxScore;
        public float MinScore;
        public float AvgScore;

        public StudentDate() { }

        public StudentDate(String stuno,String pass,float CS,float MS,float ES,float PS,float CheS,float BS)
        {
            this.stuno = stuno;
            this.pass = pass;
            this.ChineseScore = CS;
            this.MathScore = MS;
            this.EnglishScore = ES;
            this.PhyciseScore = PS;
            this.ChemistryScore = CheS;
            this.BiologyScore = BS;
            this.TotalScore = (this.ChineseScore + this.MathScore + this.EnglishScore + this.PhyciseScore + this.ChemistryScore + this.BiologyScore);
            this.AvgScore = this.TotalScore / 6;
            this.MaxScore = getMaxScore();
            this.MinScore = getMinScore();
        }

        private float getMinScore()
        {
            float Min=150;
            if (Min > this.ChineseScore) Min = this.ChineseScore;
            if (Min > this.MathScore) Min = this.MathScore;
            if (Min > this.EnglishScore) Min = this.EnglishScore;
            if (Min > this.PhyciseScore) Min = this.PhyciseScore;
            if (Min > this.ChemistryScore) Min = this.ChemistryScore;
            if (Min > this.BiologyScore) Min = this.BiologyScore;
            return Min;
        }

        private float getMaxScore()
        {
            float Max=0;
            if (Max < this.ChineseScore) Max = this.ChineseScore;
            if (Max < this.MathScore) Max = this.MathScore;
            if (Max < this.EnglishScore) Max = this.EnglishScore;
            if (Max < this.PhyciseScore) Max = this.PhyciseScore;
            if (Max < this.ChemistryScore) Max = this.ChemistryScore;
            if (Max < this.BiologyScore) Max = this.BiologyScore;
            return Max;
        }
    }
}
