using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DatabaseManagementOperationsLibrary;
using EquipmentLibrary;

namespace OfficeEquipMgmtApp
{

    public partial class FRM_TableViewer : Form
    {
        Main mainForm;

        // Database variables
        SqlDataAdapter dataAdapter;
        DataSet ds;
        DatabaseOperations db;

        Equipment equipment;

        string dir;
        string file;
        protected string connString;

        public FRM_TableViewer()
        {
            InitializeComponent();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayTable("Equipment", connString, dtgrd_Tables);
            sttts_TableDisplayed.Text = "\"Equipment\"";
        }

        private void manufacturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayTable("Manufacturers", connString, dtgrd_Tables);
            sttts_TableDisplayed.Text = "\"Manufacturer\"";
        }

        public void initializeGrid(DataGridView grid)
        {
            mainForm = ((Main)MdiParent);
            dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\managementapp\";
            file = dir + string.Format("temp_{0}.mdf", "SystemDatabase");//replace with actual shit.


            // DB Connection Setup
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + file + "; Integrated Security=True;Connect Timeout=30";
            db = new DatabaseOperations(connString);

            displayTable("Equipment", connString, dtgrd_Tables);
        }

        public void displayTable(string tableName, string connString, DataGridView grid)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string selectCommand =  string.Format("SELECT * FROM {0}",tableName);

                try // database binding happens here
                {
                    dataAdapter = new SqlDataAdapter(selectCommand, connString);
                    ds = new DataSet();
                    dataAdapter.Fill(ds, tableName);
                    grid.DataMember = tableName;
                    grid.DataSource = ds;
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            scaleDatagrid(dtgrd_Tables);
        }
        public void scaleDatagrid(DataGridView grid)
        {
            //Scale the datagridview so that all of its contents are properly shown to the user.
            grid.Width = grid.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) +
            (grid.RowHeadersVisible ? dtgrd_Tables.RowHeadersWidth : 0) + 3;
        }


    }
}
