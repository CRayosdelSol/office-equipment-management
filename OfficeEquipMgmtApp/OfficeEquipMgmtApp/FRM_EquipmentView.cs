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

namespace OfficeEquipMgmtApp
{
    public partial class frm_EquipmentView : Form
    {
        string user = Environment.UserName; // Get whatever the current computer's username is
        Main mainForm;
        string dir;
        string file;
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
            //dir = @"C:\Users\" + user + @"\Desktop\.managementapp\";
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

            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + file + "; Integrated Security=True;Connect Timeout=30";

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
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = true;
            grid.AllowUserToResizeColumns = true;
            grid.ReadOnly = false;
            db.Dispose(true);
        }


        public void refrestDataGrid(DataGridView grid, string conn,string tableName)
        {

            string selectCommand = "select * from Equipment";
            SqlDataAdapter dataAdapter;
            SqlCommandBuilder commandBuilder;
            DataTable table;
            BindingSource bindingSource = new BindingSource();

            try
            {
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
            dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\managementapp\";
            file = dir + string.Format("temp_{0}.mdf", mainForm.fileCounter);
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + file + "; Integrated Security=True;Connect Timeout=30";
            string selectedEquipmentID = dtgrd_equipment.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            string a, b, x, f, g;
            int c;
            decimal d;
            //int temp = Convert.ToInt32(dtgrd_equipment.Rows[e.RowIndex].Cells["ID"].ToString());

            a = dtgrd_equipment.Rows[e.RowIndex].Cells[1].Value.ToString();
            b = dtgrd_equipment.Rows[e.RowIndex].Cells[2].Value.ToString();
            //c = Convert.ToInt32(dtgrd_equipment.Rows[e.RowIndex].Cells[3].Value.ToString());
            //d = Convert.ToDecimal(dtgrd_equipment.Rows[e.RowIndex].Cells[4].Value.ToString());
            x = dtgrd_equipment.Rows[e.RowIndex].Cells[5].Value.ToString();
            f = dtgrd_equipment.Rows[e.RowIndex].Cells[6].Value.ToString();
            g = dtgrd_equipment.Rows[e.RowIndex].Cells[7].Value.ToString();

            if (dtgrd_equipment.RowCount > 0 && e.RowIndex == dtgrd_equipment.RowCount - 1)
            {
                foreach (DataGridViewCell cell in dtgrd_equipment.Rows[e.RowIndex].Cells)
                {
                    if (cell.Value == null)
                    {
                        return;
                    }
                }
                dtgrd_equipment.Rows.Add();
            }

            if (selectedEquipmentID == string.Empty)
            {
                db.InsertIntoTable("Equipment", connString, a, b, 0, 0, x, f, g);
            }
            else
            {
                db.updateTable("Equipment", connString,"NAME","CONDITION","QUANTITY","PRICE","DEPARTMENT","MANUFACTURER","[DATE OF PURCHASE]",
                    a,b,"0","0",x,f,g,Convert.ToInt32(selectedEquipmentID));
            }

            refrestDataGrid(dtgrd_equipment, connString, "Equipment");
        }


    }
}
