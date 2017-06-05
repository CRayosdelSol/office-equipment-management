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
using System.Windows;
using System.Windows.Forms;
using DatabaseManagementOperationsLibrary;
using EquipmentLibrary;

namespace OfficeEquipMgmtApp
{
    public partial class frm_EquipmentView : Form
    {
        string user = Environment.UserName; // Get whatever the current computer's username is
        Main mainForm;
        string dir;
        string file;
        string connString;

        DatabaseOperations db = new DatabaseOperations();
        //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + file + "; Integrated Security=True;Connect Timeout=30";

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
            dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\managementapp\";
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

            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + file + "; Integrated Security=True;Connect Timeout=30";

            //Identity allows the 'ID' Attribute to be auto incremented. Its value does not have to specified when inserting to the table.
            db.CreateTable("Equipment", connString, "ID", "int IDENTITY(1,1) not null", "NAME", "varchar(255)", "CONDITION", "varchar(255)", "QUANTITY", "int", "PRICE", "decimal(19,2)", "DEPARTMENT", "varchar(255)", "MANUFACTURER", "varchar(255)", "[DATE OF PURCHASE]", "varchar(255)");

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
                    dataAdapter.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Adjust the datagrid view to show all the present columns.
            grid.Width = grid.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) +
                (grid.RowHeadersVisible ? grid.RowHeadersWidth : 0) + 3;
            grid.AllowUserToAddRows = true;
            grid.AllowUserToDeleteRows = true;
            grid.AllowUserToResizeColumns = true;
            grid.ReadOnly = false;
            db.Dispose(true);

            grid.Columns[0].ReadOnly = true;
            grid.Columns[2].ReadOnly = true;
            grid.Columns[0].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            grid.Columns[0].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
            grid.Columns[2].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            grid.Columns[2].DefaultCellStyle.SelectionForeColor = Color.DarkGray;

        }


        public void refrestDataGrid(DataGridView grid, string conn, string tableName)
        {

            string selectCommand = "select * from Equipment";
            SqlDataAdapter dataAdapter;
            SqlCommandBuilder commandBuilder;
            DataTable table;
            BindingSource bindingSource = new BindingSource();

            using (dataAdapter = new SqlDataAdapter(selectCommand, conn))
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

        private void frm_EquipmentView_Load(object sender, EventArgs e)
        {
            initializeDefGrid(dtgrd_equipment);

            //Scale the form so that all of its contents are shown properly.
            this.MinimumSize = new Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
                        File.Delete(dir + string.Format("temp_{0}_log.ldf", mainForm.fileCounter));
                    }
                    e.Cancel = false;
                }

                else
                    e.Cancel = true;
            }
        }

        private void dtgrd_equipment_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Manufacturer manufacturer = new Manufacturer(); we'll have to fill these later.
            //Equipment equipment = new Equipment();
            string selectedEquipmentID = dtgrd_equipment.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            string a, b, x, f, g, _c, _d;
            int c = 0;
            decimal d = 0;

            a = dtgrd_equipment.Rows[e.RowIndex].Cells[1].Value.ToString();
            b = dtgrd_equipment.Rows[e.RowIndex].Cells[2].Value.ToString();
            _c = dtgrd_equipment.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (_c != string.Empty)
            {
                c = Convert.ToInt32(_c);
            }
            _d = dtgrd_equipment.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (_d != string.Empty)
            {
                d = Convert.ToDecimal(_d);
            }
            x = dtgrd_equipment.Rows[e.RowIndex].Cells[5].Value.ToString();
            f = dtgrd_equipment.Rows[e.RowIndex].Cells[6].Value.ToString();
            g = dtgrd_equipment.Rows[e.RowIndex].Cells[7].Value.ToString();

            /*If the primary key (ID) is null, insert the specified user values. If it is not, update the 
             values where the ID matches with the ID of the current entitity occurence.*/
            if (selectedEquipmentID == string.Empty)
            {
                db.InsertIntoTable("Equipment", connString, a, "CHOOSE CONDITION FROM THE OPTIONS ON THE LEFT.", 0, 0, x, f, g);
            }
            else
            {
                db.updateTable("Equipment", connString, "NAME", "CONDITION", "QUANTITY", "PRICE", "DEPARTMENT", "MANUFACTURER", "[DATE OF PURCHASE]",
                    a, b, c, d, x, f, g, Convert.ToInt32(selectedEquipmentID));
            }

            refrestDataGrid(dtgrd_equipment, connString, "Equipment");

            //Kill all connections to the database.
            SqlConnection.ClearAllPools();
        }

        private void btn_GoodItemConditon_Click(object sender, EventArgs e)
        {
            int currentRow, currentColumn;
            currentRow = dtgrd_equipment.CurrentCell.RowIndex;
            currentColumn = dtgrd_equipment.CurrentCell.ColumnIndex;
            int primaryKey = int.Parse(dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[0].Value.ToString());
            db.updateTable("Equipment", connString, "CONDITION", "GOOD", primaryKey);
            refrestDataGrid(dtgrd_equipment, connString, "Equipment");
            dtgrd_equipment.CurrentCell = dtgrd_equipment[currentColumn,currentRow];
            SqlConnection.ClearAllPools();
        }

        private void btn_UnderRepairCondition_Click(object sender, EventArgs e)
        {
            int currentRow, currentColumn;
            currentRow = dtgrd_equipment.CurrentCell.RowIndex;
            currentColumn = dtgrd_equipment.CurrentCell.ColumnIndex;
            int primaryKey = int.Parse(dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[0].Value.ToString());
            db.updateTable("Equipment", connString, "CONDITION", "UNDER REPAIR", primaryKey);
            refrestDataGrid(dtgrd_equipment, connString, "Equipment");
            dtgrd_equipment.CurrentCell = dtgrd_equipment[currentColumn, currentRow];
            SqlConnection.ClearAllPools();
        }

        private void btn_forReplacementCondition_Click(object sender, EventArgs e)
        {
            int currentRow, currentColumn;
            currentRow = dtgrd_equipment.CurrentCell.RowIndex;
            currentColumn = dtgrd_equipment.CurrentCell.ColumnIndex;
            int primaryKey = int.Parse(dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[0].Value.ToString());
            db.updateTable("Equipment", connString, "CONDITION", "NEEDS REPLACEMENT", primaryKey);
            refrestDataGrid(dtgrd_equipment, connString, "Equipment");
            dtgrd_equipment.CurrentCell = dtgrd_equipment[currentColumn, currentRow];
            SqlConnection.ClearAllPools();
        }

        private void btn_lostCondition_Click(object sender, EventArgs e)
        {
            int currentRow, currentColumn;
            currentRow = dtgrd_equipment.CurrentCell.RowIndex;
            currentColumn = dtgrd_equipment.CurrentCell.ColumnIndex;
            int primaryKey = int.Parse(dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[0].Value.ToString());
            db.updateTable("Equipment", connString, "CONDITION", "LOST", primaryKey);
            refrestDataGrid(dtgrd_equipment, connString, "Equipment");
            dtgrd_equipment.CurrentCell = dtgrd_equipment[currentColumn, currentRow];
            SqlConnection.ClearAllPools();
        }

        private void btn_DeleteEquipment_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(string.Format("Are you sure you want to delete the equipment \"{0}\" from the table? This action cannot be undone.",dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[1].Value.ToString()),"Delete Item",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                db.deleteFromTable("Equipment", connString, Convert.ToInt32(dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[0].Value.ToString()));
                refrestDataGrid(dtgrd_equipment, connString, "Equipment");
            }
            else
            {
                //do nothing.
            }

            SqlConnection.ClearAllPools();
        }
    }
}
