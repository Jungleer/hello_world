using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace 学生管理系统
{
    
    public partial class DatesOfStudents : Form
    {
        public DatesOfStudents()
        {
            InitializeComponent();
        }

        

        private void DatesOfStudents_Load(object sender, EventArgs e)
        {
            Dates.DataSource = null;
            DataTable dt = getData().Tables[0];
            Dates.DataSource = dt;
            
        }

        public static DataSet getData()
        {
            using (DataSet ds = new DataSet())
            {
                //判断Excel文件是2003版本还是2007版本
               string connString = "";
                string path = "C:\\Users\\Lenovo\\Desktop\\Dates.xls";
                    connString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + path + ";" + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";
                //读取文件
                string sql_select = " SELECT * FROM [Sheet1$]";
                using (OleDbConnection conn = new OleDbConnection(connString))
                using (OleDbDataAdapter cmd = new OleDbDataAdapter(sql_select, conn))
                {
                    conn.Open();
                    cmd.Fill(ds);
                    

                }
                if (ds == null || ds.Tables.Count <= 0) return null;
                return ds;
            }
        }

        private void Dates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Dates.DataSource;
            Export2Xls(dt, "C:\\Users\\Lenovo\\Desktop\\Dates.xls", true);
        }

        public static void Export2Xls(DataTable data, string filename, bool exportHeader = true)
        {
            if (System.IO.File.Exists(filename))
                System.IO.File.Delete(filename);

            Excel._Application xlsApp = null;
            Excel._Workbook xlsBook = null;
            Excel._Worksheet xstSheet = null;
            try
            {
                xlsApp = new Excel.ApplicationClass();

                xlsBook = xlsApp.Workbooks.Add();
                xstSheet = (Excel._Worksheet)xlsBook.Worksheets[1];

                var buffer = new StringBuilder();
                if (exportHeader)
                {
                    // Excel中列与列之间按照Tab隔开  
                    foreach (DataColumn col in data.Columns)
                        buffer.Append(col.ColumnName + "\t");

                    buffer.AppendLine();
                }
                foreach (DataRow row in data.Rows)
                {
                    foreach (DataColumn col in data.Columns)
                        buffer.Append(row[col].ToString() + "\t");

                    buffer.AppendLine();
                }
                System.Windows.Forms.Clipboard.SetDataObject("");
                // 放入剪切板  
                System.Windows.Forms.Clipboard.SetDataObject(buffer.ToString());
                var range = (Excel.Range)xstSheet.Cells[1, 1];
                range.Select();
                xstSheet.Paste();
                // 清空剪切板  
                System.Windows.Forms.Clipboard.SetDataObject("");

                xstSheet.SaveAs(filename);
            }
            finally
            {
                if (xlsBook != null)
                    xlsBook.Close();

                if (xlsApp != null)
                    xlsApp.Quit();

                // finally里清空Com对象  
                Marshal.ReleaseComObject(xlsApp);
                Marshal.ReleaseComObject(xlsBook);
                Marshal.ReleaseComObject(xstSheet);

                xstSheet = null;
                xlsBook = null;
                xlsApp = null;
                MessageBox.Show("Save it successfully!");
            }
        }
    }
}
