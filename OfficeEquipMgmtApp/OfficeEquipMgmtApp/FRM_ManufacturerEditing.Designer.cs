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
            this.grpbx_options = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pageSelector = new System.Windows.Forms.NumericUpDown();
            this.itemPerPageUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.statusStripA = new System.Windows.Forms.StatusStrip();
            this.stsstrplbl_currentSort = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsstrplbl_currentSortDirection = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.sortItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufEmailAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_manufacturer)).BeginInit();
            this.grpbx_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPerPageUpDown)).BeginInit();
            this.statusStripA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
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
            this.dtgrd_manufacturer.Location = new System.Drawing.Point(278, 50);
            this.dtgrd_manufacturer.Name = "dtgrd_manufacturer";
            this.dtgrd_manufacturer.RowTemplate.Height = 28;
            this.dtgrd_manufacturer.Size = new System.Drawing.Size(1020, 566);
            this.dtgrd_manufacturer.TabIndex = 0;
            this.dtgrd_manufacturer.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_manufacturer_CellEndEdit);
            this.dtgrd_manufacturer.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgrd_manufacturer_CellPainting);
            this.dtgrd_manufacturer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_manufacturer_CellValueChanged);
            this.dtgrd_manufacturer.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgrd_manufacturer_DataError);
            this.dtgrd_manufacturer.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgrd_manufacturer_EditingControlShowing);
            // 
            // grpbx_options
            // 
            this.grpbx_options.Controls.Add(this.btn_Delete);
            this.grpbx_options.Controls.Add(this.saveBtn);
            this.grpbx_options.Location = new System.Drawing.Point(20, 50);
            this.grpbx_options.Name = "grpbx_options";
            this.grpbx_options.Size = new System.Drawing.Size(252, 96);
            this.grpbx_options.TabIndex = 10;
            this.grpbx_options.TabStop = false;
            this.grpbx_options.Text = "Options";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_delete_forever_black_18dp_1x;
            this.btn_Delete.Location = new System.Drawing.Point(84, 24);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(60, 60);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_save_black_18dp_1x;
            this.saveBtn.Location = new System.Drawing.Point(12, 24);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(6);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(60, 60);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "PAGE NUMBER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "# OF RECORDS PER PAGE";
            // 
            // pageSelector
            // 
            this.pageSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageSelector.Location = new System.Drawing.Point(90, 523);
            this.pageSelector.Margin = new System.Windows.Forms.Padding(4);
            this.pageSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSelector.Name = "pageSelector";
            this.pageSelector.Size = new System.Drawing.Size(112, 30);
            this.pageSelector.TabIndex = 21;
            this.pageSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pageSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSelector.ValueChanged += new System.EventHandler(this.PageSelector_ValueChanged);
            // 
            // itemPerPageUpDown
            // 
            this.itemPerPageUpDown.Location = new System.Drawing.Point(74, 463);
            this.itemPerPageUpDown.Margin = new System.Windows.Forms.Padding(4);
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
            this.itemPerPageUpDown.Size = new System.Drawing.Size(134, 26);
            this.itemPerPageUpDown.TabIndex = 20;
            this.itemPerPageUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.itemPerPageUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.itemPerPageUpDown.ValueChanged += new System.EventHandler(this.itemPerPageUpDown_ValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(18, 583);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(252, 34);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_fast_forward_black_18dp_1x;
            this.btn_forward.Location = new System.Drawing.Point(210, 518);
            this.btn_forward.Margin = new System.Windows.Forms.Padding(6);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(60, 60);
            this.btn_forward.TabIndex = 18;
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_back
            // 
            this.btn_back.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_fast_rewind_black_18dp_1x;
            this.btn_back.Location = new System.Drawing.Point(20, 518);
            this.btn_back.Margin = new System.Windows.Forms.Padding(6);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(60, 60);
            this.btn_back.TabIndex = 17;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // statusStripA
            // 
            this.statusStripA.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsstrplbl_currentSort,
            this.stsstrplbl_currentSortDirection});
            this.statusStripA.Location = new System.Drawing.Point(0, 621);
            this.statusStripA.Name = "statusStripA";
            this.statusStripA.Padding = new System.Windows.Forms.Padding(3, 0, 21, 0);
            this.statusStripA.Size = new System.Drawing.Size(1310, 30);
            this.statusStripA.TabIndex = 25;
            this.statusStripA.Text = "statusStrip1";
            // 
            // stsstrplbl_currentSort
            // 
            this.stsstrplbl_currentSort.Name = "stsstrplbl_currentSort";
            this.stsstrplbl_currentSort.Size = new System.Drawing.Size(181, 25);
            this.stsstrplbl_currentSort.Text = "Currently Sorted By: -";
            // 
            // stsstrplbl_currentSortDirection
            // 
            this.stsstrplbl_currentSortDirection.Name = "stsstrplbl_currentSortDirection";
            this.stsstrplbl_currentSortDirection.Size = new System.Drawing.Size(167, 25);
            this.stsstrplbl_currentSortDirection.Text = "Sorting Direction: - ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(32, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 152);
            this.groupBox1.TabIndex = 26;
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
            this.textBox1.Location = new System.Drawing.Point(10, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 88);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "This cell only accepts numerical input. Letters and special characters are not al" +
    "lowed.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortItemsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(1310, 35);
            this.menuStrip2.TabIndex = 27;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // sortItemsToolStripMenuItem
            // 
            this.sortItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem});
            this.sortItemsToolStripMenuItem.Name = "sortItemsToolStripMenuItem";
            this.sortItemsToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.sortItemsToolStripMenuItem.Text = "&Sort";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.nameToolStripMenuItem.Text = "&Name";
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.Image = global::OfficeEquipMgmtApp.Properties.Resources.SortAscending_16x;
            this.ascendingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(189, 30);
            this.ascendingToolStripMenuItem.Text = "Ascending";
            this.ascendingToolStripMenuItem.Click += new System.EventHandler(this.ascendingToolStripMenuItem_Click);
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.Image = global::OfficeEquipMgmtApp.Properties.Resources.SortDescending_16x;
            this.descendingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(189, 30);
            this.descendingToolStripMenuItem.Text = "Descending";
            this.descendingToolStripMenuItem.Click += new System.EventHandler(this.descendingToolStripMenuItem_Click);
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
            // FRM_ManufacturerEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 651);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStripA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pageSelector);
            this.Controls.Add(this.itemPerPageUpDown);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.grpbx_options);
            this.Controls.Add(this.dtgrd_manufacturer);
            this.Name = "FRM_ManufacturerEditing";
            this.Text = "FRM_ManufacturerEditing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_ManufacturerEditing_FormClosing);
            this.Load += new System.EventHandler(this.FRM_ManufacturerEditing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_manufacturer)).EndInit();
            this.grpbx_options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pageSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPerPageUpDown)).EndInit();
            this.statusStripA.ResumeLayout(false);
            this.statusStripA.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrd_manufacturer;
        private System.Windows.Forms.GroupBox grpbx_options;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pageSelector;
        private System.Windows.Forms.NumericUpDown itemPerPageUpDown;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.StatusStrip statusStripA;
        private System.Windows.Forms.ToolStripStatusLabel stsstrplbl_currentSort;
        private System.Windows.Forms.ToolStripStatusLabel stsstrplbl_currentSortDirection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
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
    }
}