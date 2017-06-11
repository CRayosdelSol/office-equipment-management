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
                dataAdapter.Fill(ds,minimumNumberOfRecords,5,"Equipment");
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
            dtgrd_equipment.Refresh();
            scaleDatagrid(dtgrd_equipment);
            /*If the user fills up one cell in a row, assume that he'll fill everything up. 
             if that's the case then DATE OF PURCHASE column will have a value of today's date.*/
            foreach (DataGridViewRow gridRow in dtgrd_equipment.Rows)
            {
                if (gridRow.Cells[7].Value == null || gridRow.Cells[7].Value == DBNull.Value || String.IsNullOrWhiteSpace(gridRow.Cells[7].Value.ToString()))
                {
                    gridRow.Cells[7].Value = DateTime.Now;
                }
            }
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
                MessageBox.Show("There were no modifications done to the data table.","Uncessesary Commit",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            SqlConnection.ClearAllPools();

        }

        private void dtgrd_equipment_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            minimumNumberOfRecords -= 5;
            if (minimumNumberOfRecords <= 0)
            {
                minimumNumberOfRecords = 0;
            }
            ds.Clear();
            dataAdapter.Fill(ds, minimumNumberOfRecords, 5, "Equipment");
            SqlConnection.ClearAllPools();

            scaleDatagrid(dtgrd_equipment);
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            minimumNumberOfRecords += 5;
            if (minimumNumberOfRecords > 23)
            {
                minimumNumberOfRecords = 18;
            }

            ds.Clear();
            dataAdapter.Fill(ds, minimumNumberOfRecords, 5, "Equipment");
            SqlConnection.ClearAllPools();

            scaleDatagrid(dtgrd_equipment);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bool uncommitedRowExists = false;
            string primaryKey = dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show(string.Format("Are you sure you want to remove the item \"{0}\" from the table? This action cannot be undone.", dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[1].Value.ToString()), "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                /*If the user wants to delete the selected row, disable the "AllowUserToAddRows" property so there wouldn't be a blank uncommited row.
                 This property can be re-enabled when the deletion process is over.*/
                dtgrd_equipment.AllowUserToAddRows = false;

                //Since the user is trying to delete an uncommited row, just simply delete it from the datagridview.
                if (primaryKey == string.Empty)
                {
                    dtgrd_equipment.Rows.RemoveAt(dtgrd_equipment.CurrentCell.RowIndex);
                    dtgrd_equipment.AllowUserToAddRows = true;

                }
                else
                {
                    //If the selected entity exists in the database, check if there are any unsaved changes (Rows without a primary key)
                    foreach (DataGridViewRow gridRow in dtgrd_equipment.Rows)
                    {
                        if (gridRow.Cells[0].Value == null || gridRow.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(gridRow.Cells[0].Value.ToString()))
                        {
                            uncommitedRowExists = true;
                        }
                    }

                    //If there are unsaved changes, we have no choice but to commit them to the databse before deletion
                    if (uncommitedRowExists)
                    {
                        DialogResult dialogResultB = MessageBox.Show(string.Format("The item \"{0}\" is present in the database and there appears to be unsaved changes. Deleting this item will automatically save these unsaved changes. Are you sure you wish to continue deleting this item?", dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[1].Value.ToString()), "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResultB == DialogResult.Yes)
                        {
                            ds.Tables["Equipment"].Rows[dtgrd_equipment.CurrentCell.RowIndex].Delete();
                            db.UpdateDataSet((DataSet)dtgrd_equipment.DataSource);
                            refreshDataGrid(dtgrd_equipment, connString);
                            dtgrd_equipment.AllowUserToAddRows = true;
                        }
                    }

                    //If there are no unsaved changes, just simply delete the selected row and update everything that needs updating.
                    else
                    {
                        ds.Tables["Equipment"].Rows[dtgrd_equipment.CurrentCell.RowIndex].Delete();
                        db.UpdateDataSet((DataSet)dtgrd_equipment.DataSource);
                        refreshDataGrid(dtgrd_equipment, connString);
                        dtgrd_equipment.AllowUserToAddRows = true;
                    }
                }
            }

            scaleDatagrid(dtgrd_equipment);
            SqlConnection.ClearAllPools();
            
        }
        

        private void dtgrd_equipment_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Draw only grid content cells not ColumnHeader cells nor RowHeader cells
            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {
                //Pen for left and top borders
                using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))
                //Pen for bottom and right borders
                using (var gridlinePen = new Pen(dtgrd_equipment.GridColor, 1))
                //Pen for empty cell borders
                using (var selectedPen = new Pen(Color.Red, 1))
                {
                    var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
                    var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
                    var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);


                    //Draw empty cells here
                    //If the cell is part of the "ID" column or if the row is new leave it alone
                    if ((e.RowIndex != dtgrd_equipment.NewRowIndex && e.ColumnIndex != 0) && (this.dtgrd_equipment[e.ColumnIndex, e.RowIndex].Value == null || this.dtgrd_equipment[e.ColumnIndex, e.RowIndex].Value == DBNull.Value || String.IsNullOrWhiteSpace(this.dtgrd_equipment[e.ColumnIndex, e.RowIndex].Value.ToString())))
                    {
                        //Paint all parts except borders.
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        //Draw empty cells border here
                        e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));

                        //Handled painting for this cell, Stop default rendering.
                        e.Handled = true;
                    }
                    //Draw non-null cells here
                    else
                    {
                        //Paint all parts except borders.
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        //Top border of first row cells should be in background color
                        if (e.RowIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, topRightPoint);

                        //Left border of first column cells should be in background color
                        if (e.ColumnIndex == 0)
                            e.Graphics.DrawLine(backGroundPen, topLeftPoint, bottomleftPoint);

                        //Bottom border of last row cells should be in gridLine color
                        if (e.RowIndex == dtgrd_equipment.RowCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, bottomleftPoint);
                        else  //Bottom border of non-last row cells should be in background color
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, bottomleftPoint);

                        //Right border of last column cells should be in gridLine color
                        if (e.ColumnIndex == dtgrd_equipment.ColumnCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, topRightPoint);
                        else //Right border of non-last column cells should be in background color
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, topRightPoint);

                        //Top border of non-first row cells should be in gridLine color, and they should be drawn here after right border
                        if (e.RowIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, topRightPoint);

                        //Left border of non-first column cells should be in gridLine color, and they should be drawn here after bottom border
                        if (e.ColumnIndex > 0)
                            e.Graphics.DrawLine(gridlinePen, topLeftPoint, bottomleftPoint);

                        //We handled painting for this cell, Stop default rendering.
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
