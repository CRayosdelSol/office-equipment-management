using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Form
{
    public partial class ConditionReportForm : Form
    {
        public ConditionReportForm()
        {
            InitializeComponent();
        }

        private void ConditionReportForm_Load(object sender, EventArgs e)
        {
            string filepath = string.Empty;
            SqlDataAdapter da;
            DataSet ds;
            DataTable dt;
            SqlConnection conn;

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "SQL Server Database Files|*.mdf";
            open.Title = "Open Inventory File";

            if (open.ShowDialog() == DialogResult.OK) // if the user pressed OK on the form then read the file
            {
                filepath = open.FileName;
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + filepath + "; Integrated Security=True;Connect Timeout=30");
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Equipment", conn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    dt = new DataTable();

                    da.Fill(ds, "Equipment");
                    da.Fill(dt);
                    conn.Close();
                }


                ReportDataSource rds = new ReportDataSource("reportDS", ds.Tables["Equipment"]);
                //eqDataset newDS = new eqDataset();
                //newDS.Merge(ds.Tables["Equipment"]);
                reporter.LocalReport.ReportEmbeddedResource = "Report_Form.Report1.rdlc";
                reporter.LocalReport.DataSources.Clear();
                reporter.LocalReport.DataSources.Add(rds);

                this.reporter.RefreshReport();
            }
        }

        private void ConditionReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SqlConnection.ClearAllPools();
        }
    }
}
