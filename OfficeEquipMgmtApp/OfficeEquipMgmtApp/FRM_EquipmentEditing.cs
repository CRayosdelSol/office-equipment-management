using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using DatabaseManagementOperationsLibrary;

namespace OfficeEquipMgmtApp
{
    public partial class frm_EquipmentEditing : Form
    {
        Main mainForm;

        // Database variables
        SqlDataAdapter dataAdapter;
        DataSet ds;
        DatabaseOperations db;
        string dir;
        string file;
        protected string connString;
        //private static string strConn;

        //DB Pagination
        protected SqlConnection sqlPage;
        int totalRecords, pageSize, pageCount;
        int currPage = 1;

        public frm_EquipmentEditing()
        {
            InitializeComponent();
        }

        public frm_EquipmentEditing(string filepath)
        {
            InitializeComponent();
        }

        #region toolstripClickEvents

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

        #endregion  

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
                    dataAdapter.Fill(ds, "Equipment");
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

            // DB Connection Setup
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + file + "; Integrated Security=True;Connect Timeout=30";
            db = new DatabaseOperations(connString);
            db.CreateDatabase(file);

            //Identity allows the 'ID' Attribute to be auto incremented. Its value does not have to specified when inserting to the table.
            db.CreateTable("Equipment", "ID", "int IDENTITY(1,1) not null PRIMARY KEY", "Name", "varchar(255)", "Condition", "varchar(255)", "Quantity", "int", "Price", "decimal(19,2)", "Department", "varchar(255)", "Manufacturer", "varchar(255)", "[Date of Purchase]", "date");

            try // database binding happens here
            {
                dataAdapter = new SqlDataAdapter(selectCommand, connString);
                ds = new DataSet();
                dataAdapter.Fill(ds, "Equipment");
                //dataAdapter.Fill(ds, minimumNumberOfRecords, 5, "Equipment");
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
            grid.Columns[0].ReadOnly = true;
            grid.Columns[0].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            grid.Columns[0].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
            grid.Columns[2].DefaultCellStyle.SelectionBackColor = Color.LightGray;
            grid.Columns[2].DefaultCellStyle.SelectionForeColor = Color.DarkGray;

            db.Dispose(true);
        }

        private void frm_EquipmentView_Load(object sender, EventArgs e)
        {
            initializeDefGrid(dtgrd_equipment);
            pageSize = (int)itemPerPageUpDown.Value;
            //Scale the form so that all of its contents are shown properly.
            this.MinimumSize = new Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            //DB Pagination Initializers
            // For Page view.
            pageSize = int.Parse(itemPerPageUpDown.Text);
            totalRecords = getResultCount();
            pageCount = totalRecords / pageSize;

            // Adjust page count if the last page contains partial page.
            if (totalRecords % pageSize > 0)
                this.pageCount++;

            currPage = 0;
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

        private void dtgrd_equipment_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            goPrevious();
            //minimumNumberOfRecords -= itemsPerPage;
            //if (minimumNumberOfRecords <= 0)
            //{
            //    minimumNumberOfRecords = 0;
            //}

            //ds.Clear();
            //dataAdapter.Fill(ds, minimumNumberOfRecords, itemsPerPage, "Equipment");
            //SqlConnection.ClearAllPools();
            //scaleDatagrid(dtgrd_equipment);
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            goNext();
            //minimumNumberOfRecords += itemsPerPage;
            //if (minimumNumberOfRecords > 23)
            //{
            //    minimumNumberOfRecords = 18;
            //}

            //ds.Clear();
            //dataAdapter.Fill(ds, minimumNumberOfRecords, itemsPerPage, "Equipment");
            //SqlConnection.ClearAllPools();
            //scaleDatagrid(dtgrd_equipment);
        }

        private void pageSelector_ValueChanged(object sender, EventArgs e)
        {

        }

        private void itemPerPageUpDown_ValueChanged(object sender, EventArgs e)
        {
            pageSize = (int)itemPerPageUpDown.Value;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(string.Format("Are you sure you want to remove the item \"{0}\" from the table? This action cannot be undone.", dtgrd_equipment.Rows[dtgrd_equipment.CurrentCell.RowIndex].Cells[1].Value.ToString()), "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ds.Tables["Equipment"].Rows[dtgrd_equipment.CurrentCell.RowIndex].Delete();
                scaleDatagrid(dtgrd_equipment);
                db.UpdateDataSet(ds); // perform necessarry operations to the DB based on the changes in the DS
                db.Dispose(true);
            }
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.UpdateDataSet((DataSet)dtgrd_equipment.DataSource);
                refreshDataGrid(dtgrd_equipment, connString);

                //DB Pagination Initalizers
                // For Page view.
                pageSize = int.Parse(itemPerPageUpDown.Text);
                totalRecords = getResultCount();
                pageCount = totalRecords / pageSize;

                // Adjust page count if the last page contains partial page.
                if (totalRecords % pageSize > 0)
                    this.pageCount++;
            }
            catch (Exception)
            {
                MessageBox.Show("There were no modifications done to the data table.", "Unecessesary Commit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            db.Dispose(true);
            SqlConnection.ClearAllPools();
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
            // For Page view.
            pageSize = int.Parse(itemPerPageUpDown.Text);
            totalRecords = getResultCount();
            pageCount = totalRecords / pageSize;

            // Adjust page count if the last page contains partial page.
            if (totalRecords % pageSize > 0)
                this.pageCount++;

            currPage = 0;
            loadPage();
        }

        /// <summary>
        /// Fills the DS with the user-specifide parameters
        /// </summary>
        private void loadPage()
        {
            string strSql;
            int intSkip = 0;

            intSkip = (currPage * pageSize);

            // Select only the n records.
            strSql = "SELECT TOP " + pageSize +
                " * FROM Equipment WHERE ID NOT IN " +
                "(SELECT TOP " + intSkip + " ID FROM Equipment)";

            sqlPage = new SqlConnection(connString);

            var cmd = new SqlCommand(strSql, sqlPage);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Equipment");

            // Populate Data Grid
            dtgrd_equipment.DataMember = "Equipment";
            dtgrd_equipment.DataSource = ds;
            //// Show Status
            //this.lblStatus.Text = (currPage + 1).ToString() +
            //  " / " + pageCount.ToString();

            cmd.Dispose();
            da.Dispose();
            ds.Dispose();
            SqlConnection.ClearAllPools();
        }


        private int getResultCount()
        {
            // This select statement is very fast compare to SELECT COUNT(*)
            string strSql = "SELECT rows FROM sys.sysindexes " +
                            "WHERE id = OBJECT_ID('Equipment') AND indid < 2";
            int intCount = 0;

            sqlPage = new SqlConnection(connString);

            var cmd = new SqlCommand(strSql, sqlPage);

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                sqlPage.Open();
                intCount = (int)cmd.ExecuteScalar();
                cmd.Dispose();
                sqlPage.Close();
            }

            return intCount;
        }

        #region pageScroll

        private void goFirst()
        {
            if (getResultCount() == 0)
                return;

            currPage = 0;

            loadPage();
        }

        private void goPrevious()
        {
            if (getResultCount() == 0)
                return;

            if (currPage == pageCount)
                currPage = pageCount - 1;

            currPage--;

            if (currPage < 1)
                currPage = 0;

            loadPage();
        }

        private void goNext()
        {
            if (getResultCount() == 0)
                return;

            currPage++;

            if (currPage > (pageCount - 1))
                currPage = (pageCount - 1);

            loadPage();
        }

        private void goLast()
        {
            if (getResultCount() == 0)
                return;

            currPage = pageCount - 1;

            loadPage();
        }

        #endregion

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
            dtgrd_equipment.Rows[e.RowIndex].ErrorText = String.Empty;
        }
    }
}
