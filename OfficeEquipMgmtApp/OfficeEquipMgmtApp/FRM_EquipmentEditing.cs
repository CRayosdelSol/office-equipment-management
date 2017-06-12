using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DatabaseManagementOperationsLibrary;

namespace OfficeEquipMgmtApp
{
    public partial class frm_EquipmentEditing : Form
    {
        Main mainForm;
        SqlDataAdapter dataAdapter;
        DataSet ds;
        DatabaseOperations db;
        string dir;
        string file;
        string connString;
        private static string strConn;
        int minimumNumberOfRecords;
        int itemsPerPage;

        public frm_EquipmentEditing()
        {
            InitializeComponent();
            minimumNumberOfRecords = 0;
        }

        public frm_EquipmentEditing(string filepath)
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

        public void refreshDataGrid(DataGridView grid, string connString)
        {
            string selectCommand = "SELECT * FROM Equipment";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try // database binding happens here
                {
                    dataAdapter = new SqlDataAdapter(selectCommand, connString);
                    ds = new DataSet();
                    dataAdapter.Fill(ds, minimumNumberOfRecords, 5, "Equipment");
                    grid.DataMember = "Equipment";
                    grid.DataSource = ds;
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            scaleDatagrid(dtgrd_equipment);
        }


        public void scaleDatagrid(DataGridView grid)
        {
            //Scale the datagridview so that all of its contents are properly shown to the user.
            grid.Width = grid.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) +
            (grid.RowHeadersVisible ? dtgrd_equipment.RowHeadersWidth : 0) + 3;
        }

        public void initalizeDataGrid(DataGridView grid)
        {

        }

        public void initializeDefGrid(DataGridView grid)
        {
            mainForm = ((Main)MdiParent);
            dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\managementapp\";
            file = dir + string.Format("temp_{0}.mdf", mainForm.fileCounter);

            Text = string.Format("New Database {0}", mainForm.fileCounter);
            string selectCommand = "SELECT * FROM Equipment";

            // Create temporary directory and make it hidden
            DirectoryInfo dirInf = Directory.CreateDirectory(dir);
            dirInf.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + file + "; Integrated Security=True;Connect Timeout=30";

            db = new DatabaseOperations(connString);
            db.CreateDatabase(file);

            strConn = connString;

            //Identity allows the 'ID' Attribute to be auto incremented. Its value does not have to specified when inserting to the table.
            db.CreateTable("Equipment", "ID", "int IDENTITY(1,1) not null PRIMARY KEY", "Name", "varchar(255)", "Condition", "varchar(255)", "Quantity", "int", "Price", "decimal(19,2)", "Department", "varchar(255)", "Manufacturer", "varchar(255)", "[Date of Purchase]", "date");

            try // database binding happens here
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);
                ds = new DataSet();
                //dataAdapter.Fill(ds, "Equipment");
                dataAdapter.Fill(ds, minimumNumberOfRecords, 5, "Equipment");
                grid.DataMember = "Equipment";
                grid.DataSource = ds;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            grid.AllowUserToAddRows = true;
            grid.AllowUserToDeleteRows = true;
            grid.AllowUserToResizeColumns = true;
            grid.ReadOnly = false;
            db.Dispose(true);

            grid.Columns[0].ReadOnly = true;
            //CalendarColumn calCol = new CalendarColumn();
            //calCol = grid.Columns[7];
            grid.Columns[0].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            grid.Columns[0].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
            grid.Columns[2].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            grid.Columns[2].DefaultCellStyle.SelectionForeColor = Color.DarkGray;

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
            db.Dispose(true); // equivalent to clearing all Connection Pools to the current db

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
            scaleDatagrid(dtgrd_equipment);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                db.UpdateDataSet((DataSet)dtgrd_equipment.DataSource);
                refreshDataGrid(dtgrd_equipment, connString);
            }
            catch (Exception)
            {
                MessageBox.Show("There were no modifications done to the data table.", "Uncessesary Commit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            SqlConnection.ClearAllPools();

        }

        private void dtgrd_equipment_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            minimumNumberOfRecords -= itemsPerPage;
            if (minimumNumberOfRecords <= 0)
            {
                minimumNumberOfRecords = 0;
            }

            ds.Clear();
            dataAdapter.Fill(ds, minimumNumberOfRecords, itemsPerPage, "Equipment");
            SqlConnection.ClearAllPools();

            scaleDatagrid(dtgrd_equipment);
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            minimumNumberOfRecords += itemsPerPage;
            if (minimumNumberOfRecords > 23)
            {
                minimumNumberOfRecords = 18;
            }

            ds.Clear();
            dataAdapter.Fill(ds, minimumNumberOfRecords, itemsPerPage, "Equipment");
            SqlConnection.ClearAllPools();

            scaleDatagrid(dtgrd_equipment);
        }

        private void pageSelector_ValueChanged(object sender, EventArgs e)
        {

        }

        private void itemPerPageUpDown_ValueChanged(object sender, EventArgs e)
        {
            itemsPerPage = (int)pageSelector.Value;
        }
    }
}
