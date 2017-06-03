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
        private SqlCommand selectCommand;

        public frm_EquipmentView()
        {
            InitializeComponent();
            initializeDefGrid(dtgrd_equipment);
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
            /*
            Fields Reference:
            -Serial No. (like: 1PN)
            -Name
            -Condition (Like: Good condition, needs repair, under repair, for replacement, fucked or stupidly lost)
            -Quantity
            -Price
            -Department (Like: HR, IT)
            -Manufacturer Name
            -Date Purchased
            -Description (like: "Used for writing.")
            */

            string user = Environment.UserName; // Get whatever the current computer's username is
            string dir = @"C:\Users\" + user + @"\Desktop\.managementapp\";
            string file = dir + "temp.mdf";

            DatabaseOperations db = new DatabaseOperations();
            string selectCommand = "select * from Equipment";
            SqlDataAdapter dataAdapter;
            SqlCommandBuilder commandBuilder;
            DataTable table;
            BindingSource bindingSource = new BindingSource();

            // Create temporary directory and make it hidden
            DirectoryInfo dirInf = Directory.CreateDirectory(dir);
            dirInf.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + file + "; Integrated Security=True;Connect Timeout=30";

            if (File.Exists(file)) // deletes temp files generated along with the mdf in case it exists
            {
                File.Delete(file);
                File.Delete(dir + "temp_log.ldf");
            }


            db.CreateDatabase(file);

            db.CreateTable("Equipment", connString, "item_number", "int", "serial_no", "string", "name", "string", "condition", "string", "quantity", "int", "price", "decimal", "department", "string", "manufacturer", "string", "date_of_purchase", "DateTime", "description", "string"); // @RaysOfTHeSun take a look at this

            //TODO: Add columns to database and bind it to the grid

            try
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);
                commandBuilder = new SqlCommandBuilder(dataAdapter);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource.DataSource = table;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            grid.AllowUserToAddRows = true;
            grid.AllowUserToDeleteRows = true;
            grid.AllowUserToResizeColumns = true;
            grid.DataSource = bindingSource;
        }

    }
}
