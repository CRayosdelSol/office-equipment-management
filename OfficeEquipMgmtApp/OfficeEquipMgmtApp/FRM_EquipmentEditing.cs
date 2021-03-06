﻿using System;
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
        bool isSaved = false;
        ConditionList condList = new ConditionList();

        // Database variables
        DatabaseOperations db;
        DataSet manufDS = new DataSet();
        string dir;
        protected string filepath;
        protected string connString;

        //DB Pagination
        DBPagination equipmentPage, manufacturerPage;
        List<DBPagination> pagedTabs = new List<DBPagination>(); // agregate all pages to this list so that a universal code fragment can be used
        int tabIndex = 0;

        #region Properties
        public DatabaseOperations Db
        {
            get { return db; }
            set { db = value; }
        }

        public DBPagination PageEquip
        {
            get { return equipmentPage; }
            set { equipmentPage = value; }
        }

        public DBPagination PageMnf
        {
            get { return manufacturerPage; }
            set { manufacturerPage = value; }
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

        public void refreshManufCol()
        {
            string strSql = "SELECT rows FROM sys.sysindexes " +
                              "WHERE id = OBJECT_ID('Manufacturer') AND indid < 2";
            int intCount = 0;

            SqlConnection sqlPage = new SqlConnection(db.StrConn);

            var cmda = new SqlCommand(strSql, sqlPage);

            using (SqlDataAdapter da = new SqlDataAdapter(cmda))
            {
                sqlPage.Open();
                intCount = (int)cmda.ExecuteScalar();
                cmda.Dispose();
                sqlPage.Close();                
            }

            if (intCount == 0)
                return;

            List<string> values = new List<string>();
            DataGridViewComboBoxColumn manufCol = dtgrd_equipment.Columns[6] as DataGridViewComboBoxColumn;
            values.Add("Select Manufacturer");

            using (SqlConnection conn = new SqlConnection(db.StrConn))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Manufacturer", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    values.Add(reader["Name"].ToString());
                }
            }
                       
            manufCol.DataSource = values;
            manufCol.DefaultCellStyle.NullValue = values[0];
            manufCol.SortMode = DataGridViewColumnSortMode.Automatic;

            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //manufDS = new DataSet();
            //da.Fill(manufDS, "Manufacturer");
            //manufCol.DataSource = manufDS.Tables[0];
            //manufCol.DisplayMember = "Name";
            //manufCol.ValueMember = "Name";

        }

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
            isSaved = true;
            mainForm = ((Main)MdiParent);
            
            // DB Connection Setup
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + filepath + "; Integrated Security=True;Connect Timeout=30";
            Db = new DatabaseOperations(connString);
            Db.OpenDatabase(filepath);

            equipmentPage = new DBPagination(db, dtgrd_equipment, "Equipment", itemPerPageUpDown, pageSelector); // relinquish the DB to the page class
            equipmentPage.currPage = 0; // make sure the form shows the first page

            manufacturerPage = new DBPagination(db, dtgrd_manufacturer, "Manufacturer", itemPerPageUpDown, pageSelector);
            manufacturerPage.currPage = 0;

            // refresh the list
            pagedTabs = new List<DBPagination>();
            pagedTabs.Add(equipmentPage);
            pagedTabs.Add(manufacturerPage);

            Text = Path.GetFileNameWithoutExtension(filepath);

            DataGridViewComboBoxColumn conditionCol = (DataGridViewComboBoxColumn)grid.Columns[2];
            conditionCol.DataSource = condList.conditionList.OrderBy(p => p.Priority).ToList();
            conditionCol.DefaultCellStyle.NullValue = condList.conditionList[0].Value;
            conditionCol.DisplayMember = "Value";
            conditionCol.ValueMember = "Value";
            conditionCol.SortMode = DataGridViewColumnSortMode.Automatic;

            refreshManufCol();
            try
            {
                manufacturerPage.loadPage(); //database binding for manufacturers
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
            colorRowsByCondition();
            Db.Dispose(true);
        }

        /// <summary>
        /// Creates a new DB and loads it up to the view
        /// </summary>
        /// <param name="grid"></param>
        public void initializeDefGrid(DataGridView grid)
        {
            isSaved = false;

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

            manufacturerPage = new DBPagination(db, dtgrd_manufacturer, "Manufacturer", itemPerPageUpDown, pageSelector);
            manufacturerPage.currPage = 0;

            //Identity allows the 'ID' Attribute to be auto incremented. Its value does not have to specified when inserting to the table.
            Db.CreateTable("Equipment", "ID", "int IDENTITY(1,1) not null PRIMARY KEY", "Name", "varchar(255)", "Condition", "varchar(255)", "Quantity", "int", "Price", "decimal(19,2)", "Department", "varchar(255)", "Manufacturer", "varchar(255)", "[Date_of_Purchase]", "date");

            Db.CreateTable("Manufacturer", "ID", "int IDENTITY(1,1) not null PRIMARY KEY", "Name", "varchar(255)", "[Email_Address]", "varchar(255)", "[Contact_Number]", "varchar(255)", "[Country_of_Origin]", "varchar(255)", "City", "varchar(255)", "[Zip_Code]", "int");

            Db.CreateTable("Department", "ID", "int IDENTITY(1,1) not null PRIMARY KEY", "Name", "varchar(255)");

            //DataGridViewComboBoxColumn conditionCol = (DataGridViewComboBoxColumn)grid.Columns[2];
            DataGridViewComboBoxColumn conditionCol = dtgrd_equipment.Columns[2] as DataGridViewComboBoxColumn;
            conditionCol.DataSource = condList.conditionList.OrderBy(p => p.Priority).ToList();
            conditionCol.DefaultCellStyle.NullValue = condList.conditionList[0].Value;
            conditionCol.DisplayMember = "Value";
            conditionCol.ValueMember = "Value";
            conditionCol.SortMode = DataGridViewColumnSortMode.Automatic;

            try
            {
                manufacturerPage.loadPage();//database binding (manufacturer)
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

            //#MANUFdgv
            if (isNewDB)
            {
                initializeDefGrid(dtgrd_equipment);
            }
            else
            {
                initalizeDataGrid(dtgrd_equipment);

                //initializeDefGrid(dtgrd_manufacturer);
            }

            //Scale the form so that all of its contents are shown properly.
            this.MinimumSize = new Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Grid View page handler
            pagedTabs.Add(equipmentPage);
            pagedTabs.Add(manufacturerPage);

            tabIndex = tab_Tables.SelectedIndex;

            pagedTabs[tabIndex].pageSize = (int)itemPerPageUpDown.Value;
            pagedTabs[tabIndex].ReCount();
            pagedTabs[tabIndex].currPage = 0; // do this so the viewport goes to the first page 

            lbl_Pages.Text = pagedTabs[tabIndex].pageCount.ToString() + " Page(s) in total";
            lbl_RecordCount.Text = pagedTabs[tabIndex].totalRecords.ToString() + " Records present";
        }

        private void frm_EquipmentView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Db.Dispose(true); // equivalent to clearing all Connection Pools to the current db

            if (e.CloseReason == CloseReason.UserClosing && isSaved == false) // if the user clicked on the local X button 
            {
                var close = MessageBox.Show("Do you want to save changes?", "Unsaved Database", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (close == DialogResult.No) // drop the database
                {
                    if (File.Exists(filepath) && isNewDB == true) // deletes temp files generated along with the mdf in case it exists
                    {
                        File.Delete(filepath);
                        File.Delete(dir + string.Format("temp_{0}_log.ldf", mainForm.fileCounter));
                    }

                    e.Cancel = false;
                }
                else if (close == DialogResult.Yes)
                {
                    saveBtn_Click(sender, e);
                    if (isNewDB)
                    {
                        Main tempform = Application.OpenForms[0] as Main;
                        tempform.btnSaveAs_Click(sender, e);
                    }

                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
        }

        private void dtgrd_equipment_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isSaved = false;
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
            colorRowsByCondition();
        }

        #region Page Navigation
        private void btn_back_Click(object sender, EventArgs e)
        {
            pagedTabs[tabIndex].goPrevious();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            pagedTabs[tabIndex].goNext();
        }

        private void pageSelector_ValueChanged(object sender, EventArgs e)
        {
            pagedTabs[tabIndex].currPage = (int)pageSelector.Value - 1;
            pagedTabs[tabIndex].loadPage();
        }
        #endregion

        private void itemPerPageUpDown_ValueChanged(object sender, EventArgs e)
        {
            pagedTabs[tabIndex].pageSize = (int)itemPerPageUpDown.Value;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            // TODO: Add multiple row deletion dialog box
            //DialogResult dialogResult = DialogResult.No;
            DialogResult dialogResult;

            if (!isSaved)
            {
                MessageBox.Show("Please save any unsaved changes before proceeding with deletion.", "Unsaved Changes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saveBtn_Click(sender, e);
                return;
            }

            if (tab_Tables.SelectedTab.Name == "tabEquipment")
            {
                try
                {
                    dialogResult = MessageBox.Show("Are you sure you want to remove the selected item(s) from the table? This action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dtgrd_equipment.SelectedRows)
                        {
                            equipmentPage.Ds.Tables["Equipment"].Rows[row.Index].Delete();
                        }

                        scaleDatagrid(dtgrd_equipment);
                        equipmentPage.Db.UpdateEquipDataSet(equipmentPage.Ds); // perform necessarry operations to the DB based on the changes in the DS
                        equipmentPage.Ds.Dispose();
                        equipmentPage.Db.Dispose(true);
                        equipmentPage.loadPage();
                        colorRowsByCondition();

                        //refreshManufCol();

                        lbl_Pages.Text = equipmentPage.pageCount.ToString() + " Page(s) in total";
                        lbl_RecordCount.Text = equipmentPage.totalRecords.ToString() + " Records present";
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                colorRowsByCondition();
            }

            else if (tab_Tables.SelectedTab.Name == "tabManufacturer")
            {
                List<String> presentValues = new List<string>();
                bool exist = false;
                foreach (DataGridViewRow row in dtgrd_manufacturer.SelectedRows)
                {
                    if (db.checkIfManufacturerIsInUse(row.Cells[1].Value.ToString()))
                    {
                        presentValues.Add(row.Cells[1].Value.ToString());
                    }
                }
                
                if(presentValues.Count > 0)
                {
                    exist = true;
                }

                if (exist)
                {
                    var message = string.Join(Environment.NewLine, presentValues);
                    MessageBox.Show(string.Format("The following selected Manufacturer(s) is/are currently assigned to an Equipment and cannot be deleted. " + Environment.NewLine + "{0}" + Environment.NewLine + "Please un-select them then try again.", message),"Cannot Delete",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    try
                    {
                        dialogResult = MessageBox.Show("Are you sure you want to remove the selected item(s) from the table? This action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {

                            foreach (DataGridViewRow row in dtgrd_manufacturer.SelectedRows)
                            {
                                manufacturerPage.Ds.Tables["Manufacturer"].Rows[row.Index].Delete();
                            }

                            scaleDatagrid(dtgrd_manufacturer);
                            manufacturerPage.Db.updateManufacturerDataSet(manufacturerPage.Ds); // perform necessarry operations to the DB based on the changes in the DS
                            manufacturerPage.Ds.Dispose();
                            manufacturerPage.Db.Dispose(true);
                            manufacturerPage.loadPage();

                            lbl_Pages.Text = manufacturerPage.pageCount.ToString() + " Page(s) in total";
                            lbl_RecordCount.Text = manufacturerPage.totalRecords.ToString() + " Records present";
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
            }
        }
        #region equipmentDGVPainting
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

        #endregion

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
            try
            {
                if (tabIndex == 0)
                    pagedTabs[tabIndex].Db.UpdateEquipDataSet(pagedTabs[tabIndex].Ds);
                else
                    pagedTabs[tabIndex].Db.updateManufacturerDataSet(pagedTabs[tabIndex].Ds);

                colorRowsByCondition();
                pagedTabs[tabIndex].ReCount();
                lbl_Pages.Text = pagedTabs[tabIndex].pageCount.ToString() + " Page(s) in total";
                lbl_RecordCount.Text = pagedTabs[tabIndex].totalRecords.ToString() + " Records present";
                refreshManufCol();

                if (isNewDB)
                {
                    Main tempform = Application.OpenForms[0] as Main;
                    tempform.btnSaveAs_Click(sender, e);
                }

                isSaved = true;
            }
            catch (Exception)
            {
                MessageBox.Show("There were no modifications done to the data table.", "Unecessesary Commit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isSaved = false;
            }
            pagedTabs[tabIndex].Db.Dispose(true);
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
            pagedTabs[tabIndex].ReCount();
            pagedTabs[tabIndex].currPage = 0;
            lbl_Pages.Text = pagedTabs[tabIndex].pageCount.ToString() + " Page(s) in total";
            lbl_RecordCount.Text = pagedTabs[tabIndex].totalRecords.ToString() + " Records present";
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
            dtgrd_equipment.Refresh();

            if (e.RowIndex != dtgrd_equipment.NewRowIndex)
            {
                if (dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[2].Value.ToString().ToLower() == "good")
                {
                    dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }

                else if (dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[2].Value.ToString().ToLower() == "needs replacement")
                {
                    dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                }

                else if (dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[2].Value.ToString().ToLower() == "under repair")
                {
                    dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                }

                else if (dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[2].Value.ToString().ToLower() == "lost")
                {
                    dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].DefaultCellStyle.BackColor = Color.PaleVioletRed;
                }
                else
                {

                }
            }
        }

        public void colorRowsByCondition()
        {
            dtgrd_equipment.AllowUserToAddRows = false;
            foreach (DataGridViewRow row in dtgrd_equipment.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 2 && row.Cells[2].Value.ToString().ToLower() == "good")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }

                    else if (cell.ColumnIndex == 2 && row.Cells[2].Value.ToString().ToLower() == "needs replacement")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                    }

                    else if (cell.ColumnIndex == 2 && row.Cells[2].Value.ToString().ToLower() == "under repair")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    }

                    else if (cell.ColumnIndex == 2 && row.Cells[2].Value.ToString().ToLower() == "lost")
                    {
                        row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                    }

                    else
                    {

                    }
                }
            }
            dtgrd_equipment.AllowUserToAddRows = true;
        }


        internal DataGridView getDGV()
        {
            return dtgrd_equipment;
        }

        private void btn_First_Click(object sender, EventArgs e)
        {
            pagedTabs[tabIndex].goFirst();
        }

        private void dtgrd_manufacturer_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Draw only grid content cells not ColumnHeader cells nor RowHeader cells
            if (e.ColumnIndex > -1 & e.RowIndex > -1)
            {
                //Pen for left and top borders
                using (var backGroundPen = new Pen(e.CellStyle.BackColor, 1))
                //Pen for bottom and right borders
                using (var gridlinePen = new Pen(dtgrd_manufacturer.GridColor, 1))
                //Pen for selected cell borders
                using (var selectedPen = new Pen(Color.ForestGreen, 1))
                {
                    var topLeftPoint = new Point(e.CellBounds.Left, e.CellBounds.Top);
                    var topRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Top);
                    var bottomRightPoint = new Point(e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
                    var bottomleftPoint = new Point(e.CellBounds.Left, e.CellBounds.Bottom - 1);

                    //Draw selected cells here
                    if (this.dtgrd_manufacturer[e.ColumnIndex, e.RowIndex].Selected)
                    {
                        //Paint all parts except borders.
                        e.Paint(e.ClipBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        //Draw selected cells border here
                        e.Graphics.DrawRectangle(selectedPen, new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width - 1, e.CellBounds.Height - 1));

                        //Handled painting for this cell, Stop default rendering.
                        e.Handled = true;
                    }
                    //Draw non-selected cells here
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
                        if (e.RowIndex == dtgrd_manufacturer.RowCount - 1)
                            e.Graphics.DrawLine(gridlinePen, bottomRightPoint, bottomleftPoint);
                        else  //Bottom border of non-last row cells should be in background color
                            e.Graphics.DrawLine(backGroundPen, bottomRightPoint, bottomleftPoint);

                        //Right border of last column cells should be in gridLine color
                        if (e.ColumnIndex == dtgrd_manufacturer.ColumnCount - 1)
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

        private void dtgrd_manufacturer_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex == dtgrd_manufacturer.NewRowIndex)
                return;

            if (dtgrd_manufacturer.Columns[e.ColumnIndex].Name == "col_manufName")
            {
                if (e.FormattedValue.ToString().Length < 2)
                {
                    dtgrd_manufacturer.Rows[e.RowIndex].ErrorText = "Manufacturer name must at least be 2 characters long!";
                    e.Cancel = true;
                }
            }

            else if (dtgrd_manufacturer.Columns[e.ColumnIndex].Name == "col_manufEmailAdd")
            {
                if (e.FormattedValue.ToString().Length <= 2)
                {
                    dtgrd_manufacturer.Rows[e.RowIndex].ErrorText = "Please enter a valid e-mail address!";
                    e.Cancel = true;
                }
            }

            else if (dtgrd_manufacturer.Columns[e.ColumnIndex].Name == "col_manufContactNumber")
            {
                if (e.FormattedValue.ToString().Length <= 1)
                {
                    dtgrd_manufacturer.Rows[e.RowIndex].ErrorText = "Please enter a valid phone number!";
                    e.Cancel = true;
                }
            }

            else if (dtgrd_manufacturer.Columns[e.ColumnIndex].Name == "col_manufCountry")
            {
                if (e.FormattedValue.ToString().Length <= 1)
                {
                    dtgrd_manufacturer.Rows[e.RowIndex].ErrorText = "Please enter the actual country name. Do not use abbriviations.";
                    e.Cancel = true;
                }
            }

            else if (dtgrd_manufacturer.Columns[e.ColumnIndex].Name == "col_manufCity")
            {
                if (e.FormattedValue.ToString().Length <= 1)
                {
                    dtgrd_manufacturer.Rows[e.RowIndex].ErrorText = "Please enter the actual city name. Do not use abbriviations.";
                    e.Cancel = true;
                }
            }

            else if (dtgrd_manufacturer.Columns[e.ColumnIndex].Name == "col_manufZip")
            {
                if (e.FormattedValue.ToString().Length <= 2)
                {
                    dtgrd_manufacturer.Rows[e.RowIndex].ErrorText = "Please enter a valid zip code.";
                    e.Cancel = true;
                }
            }


        }

        private void dtgrd_manufacturer_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // discard edits made by the user
            dtgrd_manufacturer.Rows[e.RowIndex].ErrorText = string.Empty;
            dtgrd_manufacturer.Refresh();
        }

        private void dtgrd_equipment_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tab_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveBtn_Click(sender, e);
            tabIndex = tab_Tables.SelectedIndex;
            pagedTabs[tabIndex].pageSize = (int)itemPerPageUpDown.Value;
            pagedTabs[tabIndex].ReCount();
            pagedTabs[tabIndex].currPage = 0; // do this so the viewport goes to the first page 

            lbl_Pages.Text = pagedTabs[tabIndex].pageCount.ToString() + " Page(s) in total";
            lbl_RecordCount.Text = pagedTabs[tabIndex].totalRecords.ToString() + " Records present";
        }

        private void dtgrd_manufacturer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isSaved = false;
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            pagedTabs[tabIndex].goLast();
        }
    }
}