/* Last MOdified by: Tricia Ann Pelipas 6/7/17 */

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
using DatabaseManagementOperationsLibrary;

namespace OfficeEquipMgmtApp
{
    public partial class FRM_Manufacturer : Form
    {
        Main mainForm;
        string dir;
        string file;
        string connString;
        SqlDataAdapter dataAdapter;
        DatabaseOperations db;

        public FRM_Manufacturer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGrid_Manuf.Sort(this.dataGrid_Manuf.Columns["Name"], ListSortDirection.Ascending);
        }

        private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGrid_Manuf.Sort(this.dataGrid_Manuf.Columns["Name"], ListSortDirection.Descending);
        }

        private void ascendingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.dataGrid_Manuf.Sort(this.dataGrid_Manuf.Columns["Country"], ListSortDirection.Ascending);
        }

        private void descendingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.dataGrid_Manuf.Sort(this.dataGrid_Manuf.Columns["Country"], ListSortDirection.Descending);
        }

        public void BindData(DataGridView grid)
        {
            mainForm = ((Main)MdiParent);

            string com = "select * from Manufacturer";
            SqlDataAdapter dataAdapter;
            SqlCommandBuilder commandBuilder;
            DataTable table;
            BindingSource bindingSource = new BindingSource();

            db.CreateDatabase(file);

            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + file + "; Integrated Security=True;Connect Timeout=30";
            db.CreateTable("Manufacturer","ADDRESS", "varchar(255)", "EMAIL", "varchar(255)", "[CONTACT NUMBER]", "varchar(255)",);

            try
            {
                using (dataAdapter = new SqlDataAdapter(com, connString))
                {
                    commandBuilder = new SqlCommandBuilder(dataAdapter);
                    table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(table);
                    bindingSource.DataSource = table;
                    grid.DataSource = bindingSource;
                    dataAdapter.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FRM_Manufacturer_Load(object sender, EventArgs e)
        {
            BindData(dataGrid_Manuf);
        }
    }
}
