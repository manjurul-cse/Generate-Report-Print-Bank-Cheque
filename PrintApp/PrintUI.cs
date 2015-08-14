using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelReader;

namespace PrintApp
{
    public partial class PrintUI : Form
    {
        private string excelFilePath = String.Empty;
        Reader reader=new Reader();
        public PrintUI()
        {
            InitializeComponent();
        }

        private void PrintUI_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void buttonGetExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = @"Excel Files|*.xls;*.xlsx;*.xlsm";
            //dialog.InitialDirectory = @"d:\";
            dialog.Title = @"Please select an Excel File.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                excelFilePath = dialog.FileName;
                comboBoxExcelTable.DataSource = GetExcelSheetNames(excelFilePath);
            }
        }

        private List<String> GetExcelSheetNames(string excelFile)
        {
            OleDbConnection objConn = null;
            System.Data.DataTable dt = null;

            try
            {
                // Connection String. Change the excel file to the file you
                // will search.
                String connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelFile + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';";
                // Create connection object by using the preceding connection string.
                objConn = new OleDbConnection(connString);
                // Open connection with the database.
                objConn.Open();
                // Get the data table containg the schema guid.
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                if (dt == null)
                {
                    return null;
                }
                List<string> excelSheets=new List<string>();
                //String[] excelSheets = new String[dt.Rows.Count];
                int i = 0;

                
                foreach (DataRow row in dt.Rows)
                {
                    string x = row["TABLE_NAME"].ToString();
                    x = x.Substring(0, x.Length - 1);
                    excelSheets.Add(x); 
                    i++;
                }

                

                return excelSheets;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                // Clean up.
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            List<PersonInfo> personInfos=new List<PersonInfo>();
            try
            {
                
                if (excelFilePath != String.Empty)
                {
                    string table = comboBoxExcelTable.SelectedValue.ToString();
                    PrintReport printReport = new PrintReport();
                    LastPartReport lastPartReport=new LastPartReport();
                    DataTable dt = reader.ExcelFile(excelFilePath, table);

                    personInfos = dt.AsEnumerable().Select(dataRow =>new PersonInfo()
                    {
                        
                        Name = dataRow[0].ToString().Trim(),
                        Amount =  Convert.ToInt32(dataRow[1].ToString().Trim()),
                        AmountInWord = NumberToText(Convert.ToInt32(dataRow[1].ToString().Trim())),
                        Day = DateTime.Now.ToString("dd").Insert(1, "  "),
                        Month = DateTime.Now.ToString("MM").Insert(1, "  "),
                        Year = DateTime.Now.ToString("yyyy").Insert(1, "  ").Insert(4, "  ").Insert(7, "  ")

                    }).ToList();

                    if (checkBoxAllpart.Checked)
                    {
                        printReport.SetDataSource(personInfos);
                        PrintReportViewer.ReportSource = printReport;
                    }
                    else
                    {
                        lastPartReport.SetDataSource(personInfos);
                        PrintReportViewer.ReportSource = lastPartReport;
                    }
                   

                }
                else
                {
                    MessageBox.Show("Please select excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // comboBoxExcelTable.Items.Clear();
                //excelFilePath = String.Empty;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        public static string NumberToText(int number)
        {
            if (number == 0) return "Zero";


            if (number == -2147483648) return "Minus Two Hundred and Fourteen Crore Seventy Four Lakh Eighty Three Thousand Six Hundred and Forty Eight";


            int[] num = new int[4];
            int first = 0;
            int u, h, t;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();


            if (number < 0)
            {
                sb.Append("Minus ");
                number = -number;
            }


            string[] words0 = {"" ,"One ", "Two ", "Three ", "Four ",
        "Five " ,"Six ", "Seven ", "Eight ", "Nine "};


            string[] words1 = {"Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ",
        "Fifteen ","Sixteen ","Seventeen ","Eighteen ", "Nineteen "};


            string[] words2 = {"Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ",
        "Seventy ","Eighty ", "Ninety "};


            string[] words3 = { "Thousand ", "Lakh ", "Crore " };


            num[0] = number % 1000; // units
            num[1] = number / 1000;
            num[2] = number / 100000;
            num[1] = num[1] - 100 * num[2]; // thousands
            num[3] = number / 10000000; // crores
            num[2] = num[2] - 100 * num[3]; // lakhs


            for (int i = 3; i > 0; i--)
            {
                if (num[i] != 0)
                {
                    first = i;
                    break;
                }
            }


            int x = 0;

            for (int i = first; i >= 0; i--)
            {
                if (num[i] == 0) continue;


                u = num[i] % 10; // ones
                t = num[i] / 10;
                h = num[i] / 100; // hundreds
                t = t - 10 * h; // tens


                if (h > 0) sb.Append(words0[h] + "Hundred ");


                if (u > 0 || t > 0)
                {
                    if (h > 0 || i == 0) sb.Append("and ");


                    if (t == 0)
                        sb.Append(words0[u]);
                    else if (t == 1)
                        sb.Append(words1[u]);
                    else
                        sb.Append(words2[t - 2] + words0[u]);
                }


                if (i != 0) sb.Append(words3[i - 1]);
                if (x == 3)
                {
                    sb.Append(Environment.NewLine);
                    //sb.Append("\r\n");
                }
                x++;

            }
            return sb.ToString().TrimEnd();
        }
    }
}
