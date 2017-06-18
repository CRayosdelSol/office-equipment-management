using System.Windows.Forms;

namespace OfficeEquipMgmtApp
{
    partial class frm_EquipmentEditing
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgrd_equipment = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Condition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Manufacturer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_date_of_purchase = new DatabaseManagementOperationsLibrary.CalendarColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripA = new System.Windows.Forms.StatusStrip();
            this.stsstrplbl_currentSort = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsstrplbl_currentSortDirection = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Pages = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_RecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.ttip_optionHints = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.calendarColumn1 = new DatabaseManagementOperationsLibrary.CalendarColumn();
            this.grpbx_Actions = new System.Windows.Forms.GroupBox();
            this.itemPerPageUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pageSelector = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_equipment)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStripA.SuspendLayout();
            this.grpbx_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPerPageUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSelector)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrd_equipment
            // 
            this.dtgrd_equipment.AllowUserToAddRows = false;
            this.dtgrd_equipment.AllowUserToDeleteRows = false;
            this.dtgrd_equipment.AllowUserToResizeColumns = false;
            this.dtgrd_equipment.AllowUserToResizeRows = false;
            this.dtgrd_equipment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_equipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgrd_equipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_equipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Name,
            this.col_Condition,
            this.col_Quantity,
            this.col_Price,
            this.col_Department,
            this.col_Manufacturer,
            this.col_date_of_purchase});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrd_equipment.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgrd_equipment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgrd_equipment.Location = new System.Drawing.Point(185, 32);
            this.dtgrd_equipment.Name = "dtgrd_equipment";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_equipment.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgrd_equipment.RowTemplate.Height = 28;
            this.dtgrd_equipment.Size = new System.Drawing.Size(680, 377);
            this.dtgrd_equipment.TabIndex = 1;
            this.dtgrd_equipment.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_equipment_CellEndEdit);
            this.dtgrd_equipment.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgrd_equipment_CellPainting);
            this.dtgrd_equipment.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtgrd_equipment_CellValidating);
            this.dtgrd_equipment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_equipment_CellValueChanged);
            this.dtgrd_equipment.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgrd_equipment_DataError);
            this.dtgrd_equipment.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgrd_equipment_EditingControlShowing);
            // 
            // col_ID
            // 
            this.col_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_ID.DataPropertyName = "ID";
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_ID.Width = 43;
            // 
            // col_Name
            // 
            this.col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_Name.DataPropertyName = "Name";
            this.col_Name.HeaderText = "Name";
            this.col_Name.Name = "col_Name";
            this.col_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Name.Width = 60;
            // 
            // col_Condition
            // 
            this.col_Condition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_Condition.DataPropertyName = "Condition";
            this.col_Condition.HeaderText = "Condition";
            this.col_Condition.Name = "col_Condition";
            this.col_Condition.Width = 57;
            // 
            // col_Quantity
            // 
            this.col_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_Quantity.DataPropertyName = "Quantity";
            this.col_Quantity.HeaderText = "Quantity";
            this.col_Quantity.Name = "col_Quantity";
            this.col_Quantity.Width = 71;
            // 
            // col_Price
            // 
            this.col_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_Price.DataPropertyName = "Price";
            this.col_Price.HeaderText = "Price";
            this.col_Price.Name = "col_Price";
            this.col_Price.Width = 56;
            // 
            // col_Department
            // 
            this.col_Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_Department.DataPropertyName = "Department";
            this.col_Department.HeaderText = "Department";
            this.col_Department.MaxInputLength = 5;
            this.col_Department.Name = "col_Department";
            this.col_Department.Width = 87;
            // 
            // col_Manufacturer
            // 
            this.col_Manufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_Manufacturer.DataPropertyName = "Manufacturer";
            this.col_Manufacturer.HeaderText = "Manufacturer";
            this.col_Manufacturer.Items.AddRange(new object[] {
            "Manuf 1",
            "Manuf 2"});
            this.col_Manufacturer.Name = "col_Manufacturer";
            this.col_Manufacturer.Width = 76;
            // 
            // col_date_of_purchase
            // 
            this.col_date_of_purchase.DataPropertyName = "Date of Purchase";
            this.col_date_of_purchase.HeaderText = "Date of Purchase";
            this.col_date_of_purchase.Name = "col_date_of_purchase";
            this.col_date_of_purchase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_date_of_purchase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortItemsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortItemsToolStripMenuItem
            // 
            this.sortItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.conditionToolStripMenuItem,
            this.manufacturerToolStripMenuItem});
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
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
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
            // conditionToolStripMenuItem
            // 
            this.conditionToolStripMenuItem.Name = "conditionToolStripMenuItem";
            this.conditionToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.conditionToolStripMenuItem.Text = "&Condition";
            this.conditionToolStripMenuItem.Click += new System.EventHandler(this.conditionToolStripMenuItem_Click);
            // 
            // manufacturerToolStripMenuItem
            // 
            this.manufacturerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem1,
            this.descendingToolStripMenuItem1});
            this.manufacturerToolStripMenuItem.Name = "manufacturerToolStripMenuItem";
            this.manufacturerToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.manufacturerToolStripMenuItem.Text = "&Manufacturer";
            // 
            // ascendingToolStripMenuItem1
            // 
            this.ascendingToolStripMenuItem1.Image = global::OfficeEquipMgmtApp.Properties.Resources.SortAscending_16x;
            this.ascendingToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ascendingToolStripMenuItem1.Name = "ascendingToolStripMenuItem1";
            this.ascendingToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.ascendingToolStripMenuItem1.Text = "Ascending";
            this.ascendingToolStripMenuItem1.Click += new System.EventHandler(this.ascendingToolStripMenuItem1_Click);
            // 
            // descendingToolStripMenuItem1
            // 
            this.descendingToolStripMenuItem1.Image = global::OfficeEquipMgmtApp.Properties.Resources.SortDescending_16x;
            this.descendingToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.descendingToolStripMenuItem1.Name = "descendingToolStripMenuItem1";
            this.descendingToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.descendingToolStripMenuItem1.Text = "Descending";
            this.descendingToolStripMenuItem1.Click += new System.EventHandler(this.descendingToolStripMenuItem1_Click);
            // 
            // statusStripA
            // 
            this.statusStripA.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsstrplbl_currentSort,
            this.stsstrplbl_currentSortDirection,
            this.lbl_Pages,
            this.lbl_RecordCount});
            this.statusStripA.Location = new System.Drawing.Point(0, 419);
            this.statusStripA.Name = "statusStripA";
            this.statusStripA.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStripA.Size = new System.Drawing.Size(873, 22);
            this.statusStripA.TabIndex = 5;
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
            // lbl_Pages
            // 
            this.lbl_Pages.Name = "lbl_Pages";
            this.lbl_Pages.Size = new System.Drawing.Size(99, 17);
            this.lbl_Pages.Text = "Number of Pages";
            // 
            // lbl_RecordCount
            // 
            this.lbl_RecordCount.Name = "lbl_RecordCount";
            this.lbl_RecordCount.Size = new System.Drawing.Size(110, 17);
            this.lbl_RecordCount.Text = "Number of Records";
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(144, 32);
            this.btn_Last.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(24, 24);
            this.btn_Last.TabIndex = 18;
            this.btn_Last.Text = "L";
            this.ttip_optionHints.SetToolTip(this.btn_Last, "Go to Last Page");
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
            this.ttip_optionHints.SetToolTip(this.btn_First, "Go to First Page");
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
            this.ttip_optionHints.SetToolTip(this.btn_back, "Go to Previous Page");
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_fast_forward_black_18dp_1x;
            this.btn_forward.Location = new System.Drawing.Point(112, 32);
            this.btn_forward.Margin = new System.Windows.Forms.Padding(4);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(24, 24);
            this.btn_forward.TabIndex = 11;
            this.ttip_optionHints.SetToolTip(this.btn_forward, "Go to Next Page");
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::OfficeEquipMgmtApp.Properties.Resources.DeleteTableRow_16x;
            this.btn_Delete.Location = new System.Drawing.Point(56, 16);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(40, 40);
            this.btn_Delete.TabIndex = 9;
            this.ttip_optionHints.SetToolTip(this.btn_Delete, "Delete the selected item from the table.");
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
            this.ttip_optionHints.SetToolTip(this.saveBtn, "Save the changes you made to the database.");
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.DataPropertyName = "Date of Purchase";
            this.calendarColumn1.HeaderText = "Date of Purchase";
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.grpbx_Actions.TabIndex = 9;
            this.grpbx_Actions.TabStop = false;
            this.grpbx_Actions.Text = "Actions";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Items per page:";
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
            this.pageSelector.ValueChanged += new System.EventHandler(this.pageSelector_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "No. of records per page:";
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
            this.groupBox1.TabIndex = 17;
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
            this.panel1.TabIndex = 20;
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
            // frm_EquipmentEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(873, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbx_Actions);
            this.Controls.Add(this.statusStripA);
            this.Controls.Add(this.dtgrd_equipment);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_EquipmentEditing";
            this.ShowIcon = false;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_EquipmentView_FormClosing);
            this.Load += new System.EventHandler(this.frm_EquipmentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_equipment)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripA.ResumeLayout(false);
            this.statusStripA.PerformLayout();
            this.grpbx_Actions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemPerPageUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSelector)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrd_equipment;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripA;
        private System.Windows.Forms.ToolStripStatusLabel stsstrplbl_currentSort;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private ToolStripMenuItem ascendingToolStripMenuItem1;
        private ToolStripMenuItem descendingToolStripMenuItem1;
        private ToolStripStatusLabel stsstrplbl_currentSortDirection;
        private ToolTip ttip_optionHints;
        private Button saveBtn;
        private DatabaseManagementOperationsLibrary.CalendarColumn calendarColumn1;
        private GroupBox grpbx_Actions;
        private Button btn_back;
        private Button btn_forward;
        private Button btnRefresh;
        private NumericUpDown itemPerPageUpDown;
        private NumericUpDown pageSelector;
        private Label label2;
        private Button btn_Delete;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label4;
        private DataGridViewTextBoxColumn col_ID;
        private DataGridViewTextBoxColumn col_Name;
        private DataGridViewComboBoxColumn col_Condition;
        private DataGridViewTextBoxColumn col_Quantity;
        private DataGridViewTextBoxColumn col_Price;
        private DataGridViewTextBoxColumn col_Department;
        private DataGridViewComboBoxColumn col_Manufacturer;
        private DatabaseManagementOperationsLibrary.CalendarColumn col_date_of_purchase;
        private Button btn_Last;
        private Button btn_First;
        private Panel panel1;
        private ToolStripStatusLabel lbl_Pages;
        private ToolStripStatusLabel lbl_RecordCount;
    }
}