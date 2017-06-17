using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.Entity;
using DatabaseManagementOperationsLibrary;

namespace OfficeEquipMgmtApp
{
    public partial class FRM_ManufacturerEditing : Form
    {
        Main mainForm;
        bool isNewDB;

        // Database variables
        DatabaseOperations db;
        string dir;
        string filepath;
        protected string connString;

        //DB Pagination
        DBPagination page;

        #region Properties
        public DatabaseOperations Db
        {
            get
            {
                return db;
            }

            set
            {
                db = value;
            }
        }

        public DBPagination Page
        {
            get
            {
                return page;
            }

            set
            {
                page = value;
            }
        }

        public string Filepath
        {
            get
            {
                return filepath;
            }

            set
            {
                filepath = value;
            }
        }

        public bool IsNewDB
        {
            get
            {
                return isNewDB;
            }

            set
            {
                isNewDB = value;
            }
        }
        #endregion

        public FRM_ManufacturerEditing()
        {
            InitializeComponent();
        }

        public FRM_ManufacturerEditing(string filepath)
        {
            InitializeComponent();
            isNewDB = false;
            this.filepath = filepath;
        }

        public void scaleDatagrid(DataGridView grid)
        {
            //Scale the datagridview so that all of its contents are properly shown to the user.
            grid.Width = grid.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) +
            (grid.RowHeadersVisible ? grid.RowHeadersWidth : 0) + 3;
        }

        #region Sorting
        private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dtgrd_manufacturer.Sort(this.dtgrd_manufacturer.Columns["Name"], ListSortDirection.Ascending);
            stsstrplbl_currentSort.Text = "Currently Sorted by: Name";
            stsstrplbl_currentSortDirection.Text = "Sorting Direction: Ascending";
        }

        private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dtgrd_manufacturer.Sort(this.dtgrd_manufacturer.Columns["Name"], ListSortDirection.Descending);
            stsstrplbl_currentSort.Text = "Currently Sorted by: Name";
            stsstrplbl_currentSortDirection.Text = "Sorting Direction: Descending";
        }

        private void conditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dtgrd_manufacturer.Sort(this.dtgrd_manufacturer.Columns["Condition"], ListSortDirection.Descending);
            stsstrplbl_currentSort.Text = "Currently Sorted by: Condition";
            stsstrplbl_currentSortDirection.Text = "Sorting Direction: Descending";
        }

        private void ascendingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.dtgrd_manufacturer.Sort(this.dtgrd_manufacturer.Columns["Manufacturer"], ListSortDirection.Ascending);
            stsstrplbl_currentSort.Text = "Currently Sorted by: Manufacturer";
            stsstrplbl_currentSortDirection.Text = "Sorting Direction: Ascending";
        }

        private void descendingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.dtgrd_manufacturer.Sort(this.dtgrd_manufacturer.Columns["Manufacturer"], ListSortDirection.Descending);
            stsstrplbl_currentSort.Text = "Currently Sorted by: Manufacturer";
            stsstrplbl_currentSortDirection.Text = "Sorting Direction: Descending";
        }
        #endregion

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

            page = new DBPagination(db, dtgrd_manufacturer, itemPerPageUpDown, pageSelector); // relinquish the DB to the page class
            page.currPage = 0; // make sure the form shows the first page

            Text = Path.GetFileNameWithoutExtension(filepath);

            try
            {
                page.loadPage("Equipment"); // database binding
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
            //dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\managementapp\";
            //filepath = dir + string.Format("temp_{0}.mdf", mainForm.fileCounter);

            //Text = string.Format("New Database {0}", mainForm.fileCounter);

            //// Create temporary directory and make it hidden
            //DirectoryInfo dirInf = Directory.CreateDirectory(dir);
            //dirInf.Attributes = FileAttributes.Directory | FileAttributes.Hidden;

            // DB Connection Setup
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + filepath + "; Integrated Security=True;Connect Timeout=30";
            Db = new DatabaseOperations(connString);
            Db.CreateDatabase(filepath);

            page = new DBPagination(db, dtgrd_manufacturer, itemPerPageUpDown, pageSelector); // relinquish the DB to the page class
            page.currPage = 0; // make sure the form shows the first page

            //Identity allows the 'ID' Attribute to be auto incremented. Its value does not have to specified when inserting to the table.
            Db.CreateTable("Manufacturer", "ID", "int IDENTITY(1,1) not null PRIMARY KEY","Name","VARCHAR(255)","Email","VARCHAR(255)","Number","VARCHAR(255)","Country","VARCHAR(255)","City", "VARCHAR(255)","Zip", "VARCHAR(255)");

            try
            {
                page.loadPage("Manufacturer"); // database binding
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

        private void FRM_ManufacturerEditing_Load(object sender, EventArgs e)
        {
            if (isNewDB)
                initializeDefGrid(dtgrd_manufacturer);
            else
                initalizeDataGrid(dtgrd_manufacturer);

            //Scale the form so that all of its contents are shown properly.
            this.MinimumSize = new Size(this.Width, this.Height);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Grid View page handler
            Page.pageSize = (int)itemPerPageUpDown.Value;
            Page.ReCount("Equipment");
            Page.currPage = 0; // do this so the viewport goes to the first page 
        }

        private void FRM_ManufacturerEditing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Db.Dispose(true); // equivalent to clearing all Connection Pools to the current db

            if (e.CloseReason == CloseReason.UserClosing) // if the user clicked on the local X button 
            {
                var close = MessageBox.Show("Do you want to discard changes?", "Unsaved Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (close == DialogResult.Yes)
                {
                    db.DropTable("Manufacturer");
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;
            }
        }

        private void dtgrd_manufacturer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            scaleDatagrid(dtgrd_manufacturer);
        }

        #region Page Navigation
        #endregion

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(string.Format("Are you sure you want to remove the item \"{0}\" from the table? This action cannot be undone.", dtgrd_manufacturer.Rows[dtgrd_manufacturer.CurrentCell.RowIndex].Cells[1].Value.ToString()), "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    page.Ds.Tables["Manufacturer"].Rows[dtgrd_manufacturer.CurrentCell.RowIndex].Delete();
                    scaleDatagrid(dtgrd_manufacturer);
                    page.Db.UpdateEquipDataSet(page.Ds, "Manufacturer"); // perform necessarry operations to the DB based on the changes in the DS
                    page.Ds.Dispose();
                    page.Db.Dispose(true);
                    page.loadPage("Manufacturer");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);

                }
            }
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


                    //draw selected cells here
                    if (this.dtgrd_manufacturer[e.ColumnIndex, e.RowIndex].Selected)
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                page.Db.UpdateEquipDataSet((DataSet)dtgrd_manufacturer.DataSource, "Manufacturer");
                Page.ReCount("Equipment");
            }
            catch (Exception)
            {
                MessageBox.Show("There were no modifications done to the data table.", "Unecessesary Commit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            page.Db.Dispose(true);
        }

        private void dtgrd_manufacturer_DataError(object sender, DataGridViewDataErrorEventArgs e)
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

        private void dtgrd_manufacturer_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(NumericColumn_KeyPress);
            if (dtgrd_manufacturer.CurrentCell.ColumnIndex == 2 || dtgrd_manufacturer.CurrentCell.ColumnIndex == 5)
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
            Page.ReCount("Equipment");
            Page.currPage = 0;
        }

        private void NumericColumn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //dtgrd_manufacturer.Rows[dtgrd_manufacturer.CurrentCell.RowIndex].Cells[4].ErrorText = "Letters and special characters are not allowed.";
                groupBox1.Visible = true;
            }
            else
            {
                e.Handled = false;
                groupBox1.Visible = false;
            }
        }

        private void dtgrd_manufacturer_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // discard edits made by the user
            dtgrd_manufacturer.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        public DataGridView getDGV()
        {
            return dtgrd_manufacturer;
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            Page.goNext("Manufacturer");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Page.goPrevious("Manufacturer");
        }

        private void PageSelector_ValueChanged(object sender, EventArgs e)
        {
            Page.currPage = (int)pageSelector.Value - 1;
            Page.loadPage("Manufacturer");
        }

        private void itemPerPageUpDown_ValueChanged(object sender, EventArgs e)
        {
            Page.pageSize = (int)itemPerPageUpDown.Value;
        }
    }
}
