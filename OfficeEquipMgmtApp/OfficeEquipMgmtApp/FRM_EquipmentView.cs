using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManagementOperationsLibrary;

namespace OfficeEquipMgmtApp
{
    public partial class frm_EquipmentView : Form
    {
        string user = Environment.UserName; // Get whatever the current computer's username is
        Main mainForm;
        string dir;
        string file;
        DatabaseOperations db = new DatabaseOperations();

        public frm_EquipmentView()
        {
            InitializeComponent();
        }

        private void manufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dtgrd_equipment.Sort(this.dtgrd_equipment.Columns["Name"], ListSortDirection.Ascending);
            stsstrplbl_currentSort.Text = "Currently Sorted by: Name";
            stsstrplbl_currentSortDirection.Text = "Sorting Direction: Ascending";
        }

        private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dtgrd_equipment.Sort(this.dtgrd_equipment.Columns["Name"], ListSortDirection.Descending);
            stsstrplbl_currentSort.Text = "Currently Sorted by: Name";
            stsstrplbl_currentSortDirection.Text = "Sorting Direction: Descending";
        }

        private void conditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dtgrd_equipment.Sort(this.dtgrd_equipment.Columns["Condition"], ListSortDirection.Descending);
            stsstrplbl_currentSort.Text = "Currently Sorted by: Condition";
            stsstrplbl_currentSortDirection.Text = "Sorting Direction: Descending";
        }

        private void ascendingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.dtgrd_equipment.Sort(this.dtgrd_equipment.Columns["Manufacturer"], ListSortDirection.Ascending);
            stsstrplbl_currentSort.Text = "Currently Sorted by: Manufacturer";
            stsstrplbl_currentSortDirection.Text = "Sorting Direction: Ascending";
        }

        private void descendingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.dtgrd_equipment.Sort(this.dtgrd_equipment.Columns["Manufacturer"], ListSortDirection.Descending);
            stsstrplbl_currentSort.Text = "Currently Sorted by: Manufacturer";
            stsstrplbl_currentSortDirection.Text = "Sorting Direction: Descending";
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        public void initializeDefGrid(DataGridView grid)
        {
            mainForm = ((Main)MdiParent);
            dir = @"C:\Users\" + user + @"\Desktop\.managementapp\";
            file = dir + string.Format("temp_{0}.mdf", mainForm.fileCounter);

            this.Text = string.Format("New Database {0}", mainForm.fileCounter);

            string selectCommand = "select * from Equipment";
            SqlDataAdapter dataAdapter;
            SqlCommandBuilder commandBuilder;
            DataTable table;
            BindingSource bindingSource = new BindingSource();

            // Create temporary directory and make it hidden
            DirectoryInfo dirInf = Directory.CreateDirectory(dir);
            dirInf.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

            db.CreateDatabase(file);

            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + file + "; Integrated Security=True;Connect Timeout=30";

            db.CreateTable("Equipment", connString, "item_number", "int", "name", "varchar(255)", "condition", "varchar(255)", "quantity", "int", "price", "decimal", "department", "varchar(255)", "manufacturer", "varchar(255)", "date_of_purchase", "varchar(255)", "description", "varchar(255)");

            try
            {
                using (dataAdapter = new SqlDataAdapter(selectCommand, connString))
                {
                    commandBuilder = new SqlCommandBuilder(dataAdapter);
                    table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(table);
                    bindingSource.DataSource = table;
                    grid.DataSource = bindingSource;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            grid.AllowUserToAddRows = true;
            grid.AllowUserToDeleteRows = true;
            grid.AllowUserToResizeColumns = true;

        }

        private void frm_EquipmentView_Load(object sender, EventArgs e)
        {
            initializeDefGrid(dtgrd_equipment);
        }

        private void frm_EquipmentView_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing) // if the user clicked on the local X button 
            {
                var close = MessageBox.Show("Do you want to discard changes?", "Unsaved Database", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (close == DialogResult.Yes)
                {
                    if (File.Exists(file)) // deletes temp files generated along with the mdf in case it exists
                    {
                        File.Delete(file);
                        File.Delete(dir + string.Format("temp_{0}.ldf", mainForm.fileCounter));
                    }
                    e.Cancel = false;
                }

                else
                    e.Cancel = true;
            }
        }
    }
}
