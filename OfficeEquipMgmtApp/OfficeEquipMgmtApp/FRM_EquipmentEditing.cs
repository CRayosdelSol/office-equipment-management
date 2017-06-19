using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using DatabaseManagementOperationsLibrary;
using EquipmentLibrary;

namespace OfficeEquipMgmtApp
{
    public partial class FRM_EquipmentEditing : Form
    {
        Main mainForm;
        bool isNewDB;
        ConditionList condList = new ConditionList();

        // Database variables
        SqlDataAdapter dataAdapter;
        DataSet ds;
        DatabaseOperations db;
        string dir;
        string filepath;
        protected string connString;

        //DB Pagination
        DBPagination equipmentPage, manufacturersPage;

        #region Properties
        public DatabaseOperations Db
        {
            get { return db; }
            set { db = value; }
        }

        public DBPagination Page
        {
            get { return equipmentPage; }
            set { equipmentPage = value; }
        }

        public string Filepath
        {
            get { return filepath; }
            set { filepath = value; }
        }

        public bool IsNewDB
        {
            get { return isNewDB; }
            set { isNewDB = value; }
        }
        #endregion

        /// <summary>
        /// Default form opening behavior, used for creating new databases
        /// </summary>
        internal FRM_EquipmentEditing()
        {
            InitializeComponent();
            isNewDB = true;
        }

        /// <summary>
        /// Called when opening an already existing DB 
        /// </summary>
        /// <param name="filepath"></param>
        internal FRM_EquipmentEditing(string filepath)
        {
            InitializeComponent();
            isNewDB = false;
            this.filepath = filepath;
        }

        #region Sorting
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
        #endregion

        public void scaleDatagrid(DataGridView grid)
        {
            //Scale the datagridview so that all of its contents are properly shown to the user.
            grid.Width = grid.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) +
            (grid.RowHeadersVisible ? dtgrd_equipment.RowHeadersWidth : 0) + 3;
        }

        /// <summary>
        /// Opens an existing mdf file, called by the form constructor with 1 overload
        /// </summary>
        /// <param name="grid">The datagrid to bind the DB to</param>
        public void initalizeDataGrid(DataGridView grid)
        {
            mainForm = ((Main)MdiParent);

            // DB Connection Setup
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + filepath + "; Integrated Security=True;Connect Timeout=30";
            Db = new DatabaseOperations(connString);
            Db.OpenDatabase(filepath);

            equipmentPage = new DBPagination(db, dtgrd_equipment, "Equipment", itemPerPageUpDown, pageSelector); // relinquish the DB to the page class
            equipmentPage.currPage = 0; // make sure the form shows the first page

            Text = Path.GetFileNameWithoutExtension(filepath);

            DataGridViewComboBoxColumn conditionCol = (DataGridViewComboBoxColumn)grid.Columns[2];
            conditionCol.DataSource = condList.conditionList.OrderBy(p => p.Priority).ToList();
            conditionCol.DefaultCellStyle.NullValue = condList.conditionList[0].Value;
            conditionCol.DisplayMember = "Value";
            conditionCol.ValueMember = "Value";
            conditionCol.SortMode = DataGridViewColumnSortMode.Automatic;

            try
            {
                equipmentPage.loadPage(); // database binding
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            grid.AllowUserToAddRows = true;
            grid.AllowUserToDeleteRows = true;
            grid.AllowUserToResizeColumns = true;
            grid.ReadOnly = false;
            grid.Columns[0].ReadOnly = true;
            grid.Columns[0].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            grid.Columns[0].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
            grid.Columns[2].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            grid.Columns[2].DefaultCellStyle.SelectionForeColor = Color.DarkGray;

            Db.Dispose(true);
        }

        /// <summary>
        /// Creates a new DB and loads it up to the view
        /// </summary>
        /// <param name="grid"></param>
        public void initializeDefGrid(DataGridView grid)
        {
            mainForm = ((Main)MdiParent);
            dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\managementapp\";
            filepath = dir + string.Format("temp_{0}.mdf", mainForm.fileCounter);

            Text = string.Format("New Database {0}", mainForm.fileCounter);

            // Create temporary directory and make it hidden
            DirectoryInfo dirInf = Directory.CreateDirectory(dir);
            dirInf.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

            // DB Connection Setup
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + filepath + "; Integrated Security=True;Connect Timeout=30";
            Db = new DatabaseOperations(connString);
            Db.CreateDatabase(filepath);

            equipmentPage = new DBPagination(db, dtgrd_equipment, "Equipment", itemPerPageUpDown, pageSelector); // relinquish the DB to the page class
            equipmentPage.currPage = 0; // make sure the form shows the first page

            //Identity allows the 'ID' Attribute to be auto incremented. Its value does not have to specified when inserting to the table.
            Db.CreateTable("Equipment", "ID", "int IDENTITY(1,1) not null PRIMARY KEY", "Name", "varchar(255)", "Condition", "varchar(255)", "Quantity", "int", "Price", "decimal(19,2)", "Department", "varchar(255)", "Manufacturer", "varchar(255)", "[Date of Purchase]", "date");

            Db.CreateTable("Manufacturer", "ID", "int IDENTITY(1,1) not null PRIMARY KEY", "Name", "VARCHAR(255)", "Email", "VARCHAR(255)", "Number", "VARCHAR(255)", "Country", "VARCHAR(255)", "City", "VARCHAR(255)", "Zip", "VARCHAR(255)");

            DataGridViewComboBoxColumn conditionCol = (DataGridViewComboBoxColumn)grid.Columns[2];
            conditionCol.DataSource = condList.conditionList.OrderBy(p => p.Priority).ToList();
            conditionCol.DefaultCellStyle.NullValue = condList.conditionList[0].Value;
            conditionCol.DisplayMember = "Value";
            conditionCol.ValueMember = "Value";
            conditionCol.SortMode = DataGridViewColumnSortMode.Automatic;

            try
            {
                equipmentPage.loadPage(); // database binding
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            grid.AllowUserToAddRows = true;
            grid.AllowUserToDeleteRows = true;
            grid.AllowUserToResizeColumns = true;
            grid.ReadOnly = false;
            grid.Columns[0].ReadOnly = true;
            grid.Columns[0].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            grid.Columns[0].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
            grid.Columns[2].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            grid.Columns[2].DefaultCellStyle.SelectionForeColor = Color.DarkGray;

            Db.Dispose(true);
        }

        /// <summary>
        /// Determines what type of operation was started by the user
        /// </summary>
        private void frm_EquipmentView_Load(object sender, EventArgs e)
        {
            condList.conditionList.Add(new Condition { value = "Select item condition", priority = 99 });
            condList.conditionList.Add(new Condition { value = "Good", priority = 1 });
            condList.conditionList.Add(new Condition { value = "Under Repair", priority = 2 });
            condList.conditionList.Add(new Condition { value = "Needs Replacement", priority = 3 });
            condList.conditionList.Add(new Condition { value = "Lost", priority = 4 });

            if (isNewDB)
                initializeDefGrid(dtgrd_equipment);
            else
                initalizeDataGrid(dtgrd_equipment);

            //Scale the form so that all of its contents are shown properly.
            this.MinimumSize = new Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Grid View page handler
            Page.pageSize = (int)itemPerPageUpDown.Value;
            Page.ReCount();
            Page.currPage = 0; // do this so the viewport goes to the first page 

            lbl_Pages.Text = equipmentPage.pageCount.ToString() + " Page(s) in total";
            lbl_RecordCount.Text = Page.totalRecords.ToString() + " Records present";
        }

        private void frm_EquipmentView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Db.Dispose(true); // equivalent to clearing all Connection Pools to the current db

            if (e.CloseReason == CloseReason.UserClosing) // if the user clicked on the local X button 
            {
                var close = MessageBox.Show("Do you want to discard changes?", "Unsaved Database", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (close == DialogResult.Yes)
                {
                    if (File.Exists(filepath) && isNewDB == true) // deletes temp files generated along with the mdf in case it exists
                    {
                        File.Delete(filepath);
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

        #region Page Navigation
        private void btn_back_Click(object sender, EventArgs e)
        {
            Page.goPrevious();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            Page.goNext();
        }

        private void pageSelector_ValueChanged(object sender, EventArgs e)
        {
            Page.currPage = (int)pageSelector.Value - 1;
            Page.loadPage();
        }
        #endregion

        private void itemPerPageUpDown_ValueChanged(object sender, EventArgs e)
        {
            Page.pageSize = (int)itemPerPageUpDown.Value;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            // TODO: Add multiple row deletion dialog box
            DialogResult dialogResult = DialogResult.No;

            try
            {
                dialogResult = MessageBox.Show(string.Format("Are you sure you want to remove the item \"{0}\" from the table? This action cannot be undone.", dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[1].Value.ToString()), "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            catch (Exception)
            { }

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    for (int index = 0; index <= dtgrd_equipment.SelectedRows.Count; index++) // deletes all selected row indices
                    {
                        equipmentPage.Ds.Tables["Equipment"].Rows[index].Delete();
                    }

                    scaleDatagrid(dtgrd_equipment);
                    equipmentPage.Db.UpdateEquipDataSet(equipmentPage.Ds); // perform necessarry operations to the DB based on the changes in the DS
                    equipmentPage.Ds.Dispose();
                    equipmentPage.Db.Dispose(true);
                    equipmentPage.loadPage();

                    lbl_Pages.Text = equipmentPage.pageCount.ToString() + " Page(s) in total";
                    lbl_RecordCount.Text = Page.totalRecords.ToString() + " Records present";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void dtgrd_equipment_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //TODO: Add option to show row colors based on condtition of item

            //Draw only grid content cells not ColumnHeader cells nor RowHeader cells
            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {
                //Pen for left and top borders
                using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))
                //Pen for bottom and right borders
                using (var gridlinePen = new Pen(dtgrd_equipment.GridColor, 1))
                //Pen for selected cell borders
                using (var selectedPen = new Pen(Color.ForestGreen, 1))
                {
                    var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
                    var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
                    var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);


                    //draw selected cells here
                    if (this.dtgrd_equipment[e.ColumnIndex, e.RowIndex].Selected)
                    {
                        //Paint all parts except borders.
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        //Draw empty cells border here
                        e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));

                        //Handled painting for this cell, Stop default rendering.
                        e.Handled = true;
                    }
                    //Draw unselected cells here
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

        private void dtgrd_equipment_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex == dtgrd_equipment.NewRowIndex)
                return;

            if (dtgrd_equipment.Columns[e.ColumnIndex].Name == "col_Name")
            {
                if (e.FormattedValue.ToString().Length < 2)
                {
                    dtgrd_equipment.Rows[e.RowIndex].ErrorText = "Item name must at least be 2 characters long!";
                    e.Cancel = true;
                }
            }

            else if (dtgrd_equipment.Columns[e.ColumnIndex].Name == "col_Department")
            {
                if (e.FormattedValue.ToString().Length <= 0)
                {
                    dtgrd_equipment.Rows[e.RowIndex].ErrorText = "Assigned Department must not be empty!";
                    e.Cancel = true;
                }
            }

            else if (dtgrd_equipment.Columns[e.ColumnIndex].Name == "col_Condition")
            {
                if (e.FormattedValue.ToString() == String.Empty)
                {
                    dtgrd_equipment.Rows[e.RowIndex].ErrorText = "Please select an item from the list!";
                    e.Cancel = true;
                }
            }

            else if (dtgrd_equipment.Columns[e.ColumnIndex].Name == "col_Manufacturer")
            {
                if (e.FormattedValue.ToString() == String.Empty)
                {
                    dtgrd_equipment.Rows[e.RowIndex].ErrorText = "Please select an item from the list!";
                    e.Cancel = true;
                }
            }

            else if (dtgrd_equipment.Columns[e.ColumnIndex].Name == "col_Quantity")
            {
                if (e.FormattedValue.ToString() == DBNull.Value.ToString() || int.Parse(e.FormattedValue.ToString()) < 0)
                {
                    dtgrd_equipment.Rows[e.RowIndex].ErrorText = "Item Quantity cannot be negative or empty!";
                    e.Cancel = true;
                }
            }

            else if (dtgrd_equipment.Columns[e.ColumnIndex].Name == "col_Price")
            {
                if (e.FormattedValue.ToString() == DBNull.Value.ToString() || e.FormattedValue.ToString() == "0.00")
                {
                    dtgrd_equipment.Rows[e.RowIndex].ErrorText = "Item Price cannot be 0 or empty!";
                    e.Cancel = true;
                }
            }

        }

        internal void saveBtn_Click(object sender, EventArgs e)
        {
            if (tab_Tables.SelectedTab.Name == "tabEquipment")
            {
                try
                {
                    equipmentPage.Db.UpdateEquipDataSet((DataSet)dtgrd_equipment.DataSource);
                    Page.ReCount();
                    lbl_Pages.Text = equipmentPage.pageCount.ToString() + " Page(s) in total";
                    lbl_RecordCount.Text = Page.totalRecords.ToString() + " Records present";
                }
                catch (Exception)
                {
                    MessageBox.Show("There were no modifications done to the data table.", "Unecessesary Commit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                equipmentPage.Db.Dispose(true);
            }
            else if (tab_Tables.SelectedTab.Name == "tabManufacturers")
            {

            }

        }

        private void dtgrd_equipment_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error happened " + e.Context.ToString());

            if (e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (e.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (e.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (e.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((e.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[e.RowIndex].ErrorText = "an error";
                view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "an error";

                e.ThrowException = false;
            }
        }

        private void dtgrd_equipment_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(NumericColumn_KeyPress);
            if (dtgrd_equipment.CurrentCell.ColumnIndex == 4 || dtgrd_equipment.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    //Prevent user from entering non numeric values.
                    tb.KeyPress += new KeyPressEventHandler(NumericColumn_KeyPress);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Page.ReCount();
            Page.currPage = 0;
            lbl_Pages.Text = equipmentPage.pageCount.ToString() + " Page(s) in total";
            lbl_RecordCount.Text = Page.totalRecords.ToString() + " Records present";

        }

        private void NumericColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[4].ErrorText = "Letters and special characters are not allowed.";
                groupBox1.Visible = true;
            }
            else
            {
                e.Handled = false;
                groupBox1.Visible = false;
            }
        }

        private void dtgrd_equipment_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // discard edits made by the user
            dtgrd_equipment.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        internal DataGridView getDGV()
        {
            return dtgrd_equipment;
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            equipmentPage.goFirst();
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            equipmentPage.goLast();
        }
    }
}