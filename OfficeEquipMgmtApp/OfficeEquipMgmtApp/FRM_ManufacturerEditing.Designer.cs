namespace OfficeEquipMgmtApp
{
    partial class FRM_ManufacturerEditing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgrd_manufacturer = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufEmailAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStripA = new System.Windows.Forms.StatusStrip();
            this.stsstrplbl_currentSort = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsstrplbl_currentSortDirection = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_RecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Pages = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.sortItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpbx_Actions = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.itemPerPageUpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_forward = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pageSelector = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_manufacturer)).BeginInit();
            this.statusStripA.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbx_Actions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPerPageUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrd_manufacturer
            // 
            this.dtgrd_manufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_manufacturer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.col_manufName,
            this.col_manufEmailAdd,
            this.col_manufContactNumber,
            this.col_manufCountry,
            this.col_manufCity,
            this.col_manufZip});
            this.dtgrd_manufacturer.Location = new System.Drawing.Point(185, 32);
            this.dtgrd_manufacturer.Margin = new System.Windows.Forms.Padding(2);
            this.dtgrd_manufacturer.Name = "dtgrd_manufacturer";
            this.dtgrd_manufacturer.RowTemplate.Height = 28;
            this.dtgrd_manufacturer.Size = new System.Drawing.Size(680, 377);
            this.dtgrd_manufacturer.TabIndex = 0;
            this.dtgrd_manufacturer.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_manufacturer_CellEndEdit);
            this.dtgrd_manufacturer.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgrd_manufacturer_CellPainting);
            this.dtgrd_manufacturer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_manufacturer_CellValueChanged);
            this.dtgrd_manufacturer.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgrd_manufacturer_DataError);
            this.dtgrd_manufacturer.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgrd_manufacturer_EditingControlShowing);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // col_manufName
            // 
            this.col_manufName.HeaderText = "Name";
            this.col_manufName.Name = "col_manufName";
            // 
            // col_manufEmailAdd
            // 
            this.col_manufEmailAdd.HeaderText = "Email Address";
            this.col_manufEmailAdd.Name = "col_manufEmailAdd";
            // 
            // col_manufContactNumber
            // 
            this.col_manufContactNumber.HeaderText = "Contact Number";
            this.col_manufContactNumber.Name = "col_manufContactNumber";
            // 
            // col_manufCountry
            // 
            this.col_manufCountry.HeaderText = "Country of Origin";
            this.col_manufCountry.Name = "col_manufCountry";
            // 
            // col_manufCity
            // 
            this.col_manufCity.HeaderText = "City";
            this.col_manufCity.Name = "col_manufCity";
            // 
            // col_manufZip
            // 
            this.col_manufZip.HeaderText = "Zip Code";
            this.col_manufZip.Name = "col_manufZip";
            // 
            // statusStripA
            // 
            this.statusStripA.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsstrplbl_currentSort,
            this.stsstrplbl_currentSortDirection,
            this.lbl_RecordCount,
            this.lbl_Pages});
            this.statusStripA.Location = new System.Drawing.Point(0, 419);
            this.statusStripA.Name = "statusStripA";
            this.statusStripA.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStripA.Size = new System.Drawing.Size(874, 22);
            this.statusStripA.TabIndex = 25;
            this.statusStripA.Text = "statusStrip1";
            // 
            // stsstrplbl_currentSort
            // 
            this.stsstrplbl_currentSort.Name = "stsstrplbl_currentSort";
            this.stsstrplbl_currentSort.Size = new System.Drawing.Size(120, 17);
            this.stsstrplbl_currentSort.Text = "Currently Sorted By: -";
            // 
            // stsstrplbl_currentSortDirection
            // 
            this.stsstrplbl_currentSortDirection.Name = "stsstrplbl_currentSortDirection";
            this.stsstrplbl_currentSortDirection.Size = new System.Drawing.Size(110, 17);
            this.stsstrplbl_currentSortDirection.Text = "Sorting Direction: - ";
            // 
            // lbl_RecordCount
            // 
            this.lbl_RecordCount.Name = "lbl_RecordCount";
            this.lbl_RecordCount.Size = new System.Drawing.Size(110, 17);
            this.lbl_RecordCount.Text = "Number of Records";
            // 
            // lbl_Pages
            // 
            this.lbl_Pages.Name = "lbl_Pages";
            this.lbl_Pages.Size = new System.Drawing.Size(99, 17);
            this.lbl_Pages.Text = "Number of Pages";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortItemsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(874, 24);
            this.menuStrip2.TabIndex = 27;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // sortItemsToolStripMenuItem
            // 
            this.sortItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem});
            this.sortItemsToolStripMenuItem.Name = "sortItemsToolStripMenuItem";
            this.sortItemsToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sortItemsToolStripMenuItem.Text = "&Sort";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.nameToolStripMenuItem.Text = "&Name";
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.Image = global::OfficeEquipMgmtApp.Properties.Resources.SortAscending_16x;
            this.ascendingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ascendingToolStripMenuItem.Text = "Ascending";
            this.ascendingToolStripMenuItem.Click += new System.EventHandler(this.ascendingToolStripMenuItem_Click);
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.Image = global::OfficeEquipMgmtApp.Properties.Resources.SortDescending_16x;
            this.descendingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.descendingToolStripMenuItem.Text = "Descending";
            this.descendingToolStripMenuItem.Click += new System.EventHandler(this.descendingToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(8, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(168, 104);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Error";
            this.groupBox1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(7, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 59);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "This cell only accepts numerical input. Letters and special characters are not al" +
    "lowed.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // grpbx_Actions
            // 
            this.grpbx_Actions.Controls.Add(this.btn_Delete);
            this.grpbx_Actions.Controls.Add(this.saveBtn);
            this.grpbx_Actions.Location = new System.Drawing.Point(8, 24);
            this.grpbx_Actions.Margin = new System.Windows.Forms.Padding(2);
            this.grpbx_Actions.Name = "grpbx_Actions";
            this.grpbx_Actions.Padding = new System.Windows.Forms.Padding(2);
            this.grpbx_Actions.Size = new System.Drawing.Size(168, 64);
            this.grpbx_Actions.TabIndex = 28;
            this.grpbx_Actions.TabStop = false;
            this.grpbx_Actions.Text = "Actions";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::OfficeEquipMgmtApp.Properties.Resources.DeleteTableRow_16x;
            this.btn_Delete.Location = new System.Drawing.Point(56, 16);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(40, 40);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::OfficeEquipMgmtApp.Properties.Resources.Save_16x;
            this.saveBtn.Location = new System.Drawing.Point(8, 16);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(40, 40);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Last);
            this.panel1.Controls.Add(this.btn_First);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.itemPerPageUpDown);
            this.panel1.Controls.Add(this.btn_forward);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.pageSelector);
            this.panel1.Location = new System.Drawing.Point(8, 352);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 56);
            this.panel1.TabIndex = 22;
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(144, 32);
            this.btn_Last.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(24, 24);
            this.btn_Last.TabIndex = 18;
            this.btn_Last.Text = "L";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(0, 32);
            this.btn_First.Margin = new System.Windows.Forms.Padding(4);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(24, 24);
            this.btn_First.TabIndex = 19;
            this.btn_First.Text = "F";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_back
            // 
            this.btn_back.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_fast_rewind_black_18dp_1x;
            this.btn_back.Location = new System.Drawing.Point(32, 32);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(24, 24);
            this.btn_back.TabIndex = 10;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // itemPerPageUpDown
            // 
            this.itemPerPageUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPerPageUpDown.Location = new System.Drawing.Point(0, 0);
            this.itemPerPageUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.itemPerPageUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemPerPageUpDown.Name = "itemPerPageUpDown";
            this.itemPerPageUpDown.Size = new System.Drawing.Size(72, 23);
            this.itemPerPageUpDown.TabIndex = 13;
            this.itemPerPageUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemPerPageUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.itemPerPageUpDown.ValueChanged += new System.EventHandler(this.itemPerPageUpDown_ValueChanged);
            // 
            // btn_forward
            // 
            this.btn_forward.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_fast_forward_black_18dp_1x;
            this.btn_forward.Location = new System.Drawing.Point(112, 32);
            this.btn_forward.Margin = new System.Windows.Forms.Padding(4);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(24, 24);
            this.btn_forward.TabIndex = 11;
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(88, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pageSelector
            // 
            this.pageSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageSelector.Location = new System.Drawing.Point(64, 32);
            this.pageSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSelector.Name = "pageSelector";
            this.pageSelector.Size = new System.Drawing.Size(40, 23);
            this.pageSelector.TabIndex = 14;
            this.pageSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pageSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSelector.ValueChanged += new System.EventHandler(this.PageSelector_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "No. of records per page:";
            // 
            // FRM_ManufacturerEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbx_Actions);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.statusStripA);
            this.Controls.Add(this.dtgrd_manufacturer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRM_ManufacturerEditing";
            this.Text = "FRM_ManufacturerEditing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_ManufacturerEditing_FormClosing);
            this.Load += new System.EventHandler(this.FRM_ManufacturerEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_manufacturer)).EndInit();
            this.statusStripA.ResumeLayout(false);
            this.statusStripA.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbx_Actions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemPerPageUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrd_manufacturer;
        private System.Windows.Forms.StatusStrip statusStripA;
        private System.Windows.Forms.ToolStripStatusLabel stsstrplbl_currentSort;
        private System.Windows.Forms.ToolStripStatusLabel stsstrplbl_currentSortDirection;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sortItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_manufName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_manufEmailAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_manufContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_manufCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_manufCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_manufZip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpbx_Actions;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.NumericUpDown itemPerPageUpDown;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown pageSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_RecordCount;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Pages;
    }
}