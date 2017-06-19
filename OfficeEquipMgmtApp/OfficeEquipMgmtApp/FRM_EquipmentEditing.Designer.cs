using System.Windows.Forms;

namespace OfficeEquipMgmtApp
{
    partial class FRM_EquipmentEditing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tab_Tables = new System.Windows.Forms.TabControl();
            this.tabEquipment = new System.Windows.Forms.TabPage();
            this.dtgrd_equipment = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Condition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Manufacturer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_date_of_purchase = new DatabaseManagementOperationsLibrary.CalendarColumn();
            this.tabManufacturer = new System.Windows.Forms.TabPage();
            this.dtgrd_manufacturer = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufEmailAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_manufZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.statusStripA.SuspendLayout();
            this.grpbx_Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPerPageUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSelector)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_Tables.SuspendLayout();
            this.tabEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_equipment)).BeginInit();
            this.tabManufacturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_manufacturer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortItemsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1311, 35);
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
            this.sortItemsToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
            this.sortItemsToolStripMenuItem.Text = "&Sort";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
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
            // conditionToolStripMenuItem
            // 
            this.conditionToolStripMenuItem.Name = "conditionToolStripMenuItem";
            this.conditionToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.conditionToolStripMenuItem.Text = "&Condition";
            this.conditionToolStripMenuItem.Click += new System.EventHandler(this.conditionToolStripMenuItem_Click);
            // 
            // manufacturerToolStripMenuItem
            // 
            this.manufacturerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem1,
            this.descendingToolStripMenuItem1});
            this.manufacturerToolStripMenuItem.Name = "manufacturerToolStripMenuItem";
            this.manufacturerToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.manufacturerToolStripMenuItem.Text = "&Manufacturer";
            // 
            // ascendingToolStripMenuItem1
            // 
            this.ascendingToolStripMenuItem1.Image = global::OfficeEquipMgmtApp.Properties.Resources.SortAscending_16x;
            this.ascendingToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ascendingToolStripMenuItem1.Name = "ascendingToolStripMenuItem1";
            this.ascendingToolStripMenuItem1.Size = new System.Drawing.Size(189, 30);
            this.ascendingToolStripMenuItem1.Text = "Ascending";
            this.ascendingToolStripMenuItem1.Click += new System.EventHandler(this.ascendingToolStripMenuItem1_Click);
            // 
            // descendingToolStripMenuItem1
            // 
            this.descendingToolStripMenuItem1.Image = global::OfficeEquipMgmtApp.Properties.Resources.SortDescending_16x;
            this.descendingToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.descendingToolStripMenuItem1.Name = "descendingToolStripMenuItem1";
            this.descendingToolStripMenuItem1.Size = new System.Drawing.Size(189, 30);
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
            this.statusStripA.Location = new System.Drawing.Point(0, 632);
            this.statusStripA.Name = "statusStripA";
            this.statusStripA.Padding = new System.Windows.Forms.Padding(3, 0, 21, 0);
            this.statusStripA.Size = new System.Drawing.Size(1311, 30);
            this.statusStripA.TabIndex = 5;
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
            // lbl_Pages
            // 
            this.lbl_Pages.Name = "lbl_Pages";
            this.lbl_Pages.Size = new System.Drawing.Size(150, 25);
            this.lbl_Pages.Text = "Number of Pages";
            // 
            // lbl_RecordCount
            // 
            this.lbl_RecordCount.Name = "lbl_RecordCount";
            this.lbl_RecordCount.Size = new System.Drawing.Size(167, 25);
            this.lbl_RecordCount.Text = "Number of Records";
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(216, 48);
            this.btn_Last.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(36, 36);
            this.btn_Last.TabIndex = 18;
            this.btn_Last.Text = "L";
            this.ttip_optionHints.SetToolTip(this.btn_Last, "Go to Last Page");
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(0, 48);
            this.btn_First.Margin = new System.Windows.Forms.Padding(6);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(36, 36);
            this.btn_First.TabIndex = 19;
            this.btn_First.Text = "F";
            this.ttip_optionHints.SetToolTip(this.btn_First, "Go to First Page");
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // btn_back
            // 
            this.btn_back.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_fast_rewind_black_18dp_1x;
            this.btn_back.Location = new System.Drawing.Point(48, 48);
            this.btn_back.Margin = new System.Windows.Forms.Padding(6);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(36, 36);
            this.btn_back.TabIndex = 10;
            this.ttip_optionHints.SetToolTip(this.btn_back, "Go to Previous Page");
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_fast_forward_black_18dp_1x;
            this.btn_forward.Location = new System.Drawing.Point(168, 48);
            this.btn_forward.Margin = new System.Windows.Forms.Padding(6);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(36, 36);
            this.btn_forward.TabIndex = 11;
            this.ttip_optionHints.SetToolTip(this.btn_forward, "Go to Next Page");
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Image = global::OfficeEquipMgmtApp.Properties.Resources.DeleteTableRow_16x;
            this.btn_Delete.Location = new System.Drawing.Point(84, 24);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(60, 60);
            this.btn_Delete.TabIndex = 9;
            this.ttip_optionHints.SetToolTip(this.btn_Delete, "Delete the selected item from the table.");
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::OfficeEquipMgmtApp.Properties.Resources.Save_16x;
            this.saveBtn.Location = new System.Drawing.Point(12, 24);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(6);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(60, 60);
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
            this.grpbx_Actions.Controls.Add(this.saveBtn);
            this.grpbx_Actions.Controls.Add(this.btn_Delete);
            this.grpbx_Actions.Location = new System.Drawing.Point(12, 36);
            this.grpbx_Actions.Name = "grpbx_Actions";
            this.grpbx_Actions.Size = new System.Drawing.Size(252, 96);
            this.grpbx_Actions.TabIndex = 9;
            this.grpbx_Actions.TabStop = false;
            this.grpbx_Actions.Text = "Actions";
            // 
            // itemPerPageUpDown
            // 
            this.itemPerPageUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPerPageUpDown.Location = new System.Drawing.Point(0, 0);
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
            this.itemPerPageUpDown.Size = new System.Drawing.Size(108, 30);
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
            this.pageSelector.Location = new System.Drawing.Point(96, 48);
            this.pageSelector.Margin = new System.Windows.Forms.Padding(4);
            this.pageSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSelector.Name = "pageSelector";
            this.pageSelector.Size = new System.Drawing.Size(60, 30);
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
            this.label1.Location = new System.Drawing.Point(12, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "No. of records per page:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 156);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Last);
            this.panel1.Controls.Add(this.btn_First);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.itemPerPageUpDown);
            this.panel1.Controls.Add(this.btn_forward);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.pageSelector);
            this.panel1.Location = new System.Drawing.Point(12, 528);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 84);
            this.panel1.TabIndex = 20;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(132, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 34);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tab_Tables
            // 
            this.tab_Tables.Controls.Add(this.tabEquipment);
            this.tab_Tables.Controls.Add(this.tabManufacturer);
            this.tab_Tables.Location = new System.Drawing.Point(276, 48);
            this.tab_Tables.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Tables.Name = "tab_Tables";
            this.tab_Tables.SelectedIndex = 0;
            this.tab_Tables.Size = new System.Drawing.Size(1032, 564);
            this.tab_Tables.TabIndex = 21;
            // 
            // tabEquipment
            // 
            this.tabEquipment.Controls.Add(this.dtgrd_equipment);
            this.tabEquipment.Location = new System.Drawing.Point(4, 29);
            this.tabEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.tabEquipment.Name = "tabEquipment";
            this.tabEquipment.Padding = new System.Windows.Forms.Padding(4);
            this.tabEquipment.Size = new System.Drawing.Size(1024, 531);
            this.tabEquipment.TabIndex = 0;
            this.tabEquipment.Text = "Equipment";
            this.tabEquipment.UseVisualStyleBackColor = true;
            // 
            // dtgrd_equipment
            // 
            this.dtgrd_equipment.AllowUserToAddRows = false;
            this.dtgrd_equipment.AllowUserToDeleteRows = false;
            this.dtgrd_equipment.AllowUserToResizeColumns = false;
            this.dtgrd_equipment.AllowUserToResizeRows = false;
            this.dtgrd_equipment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_equipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrd_equipment.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrd_equipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrd_equipment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgrd_equipment.Location = new System.Drawing.Point(4, 4);
            this.dtgrd_equipment.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrd_equipment.Name = "dtgrd_equipment";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrd_equipment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrd_equipment.RowTemplate.Height = 28;
            this.dtgrd_equipment.Size = new System.Drawing.Size(1016, 523);
            this.dtgrd_equipment.TabIndex = 2;
            this.dtgrd_equipment.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_equipment_CellEndEdit);
            this.dtgrd_equipment.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgrd_equipment_CellPainting);
            this.dtgrd_equipment.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtgrd_equipment_CellValidating);
            this.dtgrd_equipment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_equipment_CellValueChanged);
            this.dtgrd_equipment.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgrd_equipment_EditingControlShowing);
            this.dtgrd_equipment.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_equipment_RowLeave);
            // 
            // col_ID
            // 
            this.col_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.col_ID.DataPropertyName = "ID";
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_ID.Width = 62;
            // 
            // col_Name
            // 
            this.col_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_Name.DataPropertyName = "Name";
            this.col_Name.HeaderText = "Name";
            this.col_Name.Name = "col_Name";
            this.col_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Name.Width = 89;
            // 
            // col_Condition
            // 
            this.col_Condition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_Condition.DataPropertyName = "Condition";
            this.col_Condition.HeaderText = "Condition";
            this.col_Condition.Name = "col_Condition";
            this.col_Condition.Width = 85;
            // 
            // col_Quantity
            // 
            this.col_Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_Quantity.DataPropertyName = "Quantity";
            this.col_Quantity.HeaderText = "Quantity";
            this.col_Quantity.Name = "col_Quantity";
            this.col_Quantity.Width = 107;
            // 
            // col_Price
            // 
            this.col_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_Price.DataPropertyName = "Price";
            this.col_Price.HeaderText = "Price";
            this.col_Price.Name = "col_Price";
            this.col_Price.Width = 84;
            // 
            // col_Department
            // 
            this.col_Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_Department.DataPropertyName = "Department";
            this.col_Department.HeaderText = "Department";
            this.col_Department.MaxInputLength = 5;
            this.col_Department.Name = "col_Department";
            this.col_Department.Width = 133;
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
            this.col_Manufacturer.Width = 114;
            // 
            // col_date_of_purchase
            // 
            this.col_date_of_purchase.DataPropertyName = "Date of Purchase";
            this.col_date_of_purchase.HeaderText = "Date of Purchase";
            this.col_date_of_purchase.Name = "col_date_of_purchase";
            this.col_date_of_purchase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_date_of_purchase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabManufacturer
            // 
            this.tabManufacturer.Controls.Add(this.dtgrd_manufacturer);
            this.tabManufacturer.Location = new System.Drawing.Point(4, 29);
            this.tabManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.tabManufacturer.Name = "tabManufacturer";
            this.tabManufacturer.Padding = new System.Windows.Forms.Padding(4);
            this.tabManufacturer.Size = new System.Drawing.Size(1024, 531);
            this.tabManufacturer.TabIndex = 1;
            this.tabManufacturer.Text = "Manufacturers";
            this.tabManufacturer.UseVisualStyleBackColor = true;
            // 
            // dtgrd_manufacturer
            // 
            this.dtgrd_manufacturer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgrd_manufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_manufacturer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.col_manufName,
            this.col_manufEmailAdd,
            this.col_manufContactNumber,
            this.col_manufCountry,
            this.col_manufCity,
            this.col_manufZip});
            this.dtgrd_manufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrd_manufacturer.Location = new System.Drawing.Point(4, 4);
            this.dtgrd_manufacturer.Name = "dtgrd_manufacturer";
            this.dtgrd_manufacturer.RowTemplate.Height = 28;
            this.dtgrd_manufacturer.Size = new System.Drawing.Size(1016, 523);
            this.dtgrd_manufacturer.TabIndex = 1;
            this.dtgrd_manufacturer.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_manufacturer_CellEndEdit);
            this.dtgrd_manufacturer.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgrd_manufacturer_CellPainting);
            this.dtgrd_manufacturer.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dtgrd_manufacturer_CellValidating);
            this.dtgrd_manufacturer.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgrd_manufacturer_EditingControlShowing);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 62;
            // 
            // col_manufName
            // 
            this.col_manufName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_manufName.DataPropertyName = "Name";
            this.col_manufName.HeaderText = "Name";
            this.col_manufName.Name = "col_manufName";
            this.col_manufName.Width = 87;
            // 
            // col_manufEmailAdd
            // 
            this.col_manufEmailAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_manufEmailAdd.DataPropertyName = "Email Address";
            this.col_manufEmailAdd.HeaderText = "Email Address";
            this.col_manufEmailAdd.Name = "col_manufEmailAdd";
            this.col_manufEmailAdd.Width = 135;
            // 
            // col_manufContactNumber
            // 
            this.col_manufContactNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_manufContactNumber.DataPropertyName = "Contact Number";
            this.col_manufContactNumber.HeaderText = "Contact Number";
            this.col_manufContactNumber.Name = "col_manufContactNumber";
            this.col_manufContactNumber.Width = 148;
            // 
            // col_manufCountry
            // 
            this.col_manufCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_manufCountry.DataPropertyName = "Country of Origin";
            this.col_manufCountry.HeaderText = "Country of Origin";
            this.col_manufCountry.Name = "col_manufCountry";
            this.col_manufCountry.Width = 113;
            // 
            // col_manufCity
            // 
            this.col_manufCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_manufCity.DataPropertyName = "City";
            this.col_manufCity.HeaderText = "City";
            this.col_manufCity.Name = "col_manufCity";
            this.col_manufCity.Width = 71;
            // 
            // col_manufZip
            // 
            this.col_manufZip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_manufZip.DataPropertyName = "Zip Code";
            this.col_manufZip.HeaderText = "Zip Code";
            this.col_manufZip.Name = "col_manufZip";
            this.col_manufZip.Width = 101;
            // 
            // FRM_EquipmentEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1311, 662);
            this.Controls.Add(this.tab_Tables);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbx_Actions);
            this.Controls.Add(this.statusStripA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_EquipmentEditing";
            this.ShowIcon = false;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_EquipmentView_FormClosing);
            this.Load += new System.EventHandler(this.frm_EquipmentView_Load);
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
            this.tab_Tables.ResumeLayout(false);
            this.tabEquipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_equipment)).EndInit();
            this.tabManufacturer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_manufacturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private Button btn_Last;
        private Button btn_First;
        private Panel panel1;
        private ToolStripStatusLabel lbl_Pages;
        private ToolStripStatusLabel lbl_RecordCount;
        private TabControl tab_Tables;
        private TabPage tabEquipment;
        private TabPage tabManufacturer;
        private DataGridView dtgrd_equipment;
        private DataGridViewTextBoxColumn col_ID;
        private DataGridViewTextBoxColumn col_Name;
        private DataGridViewComboBoxColumn col_Condition;
        private DataGridViewTextBoxColumn col_Quantity;
        private DataGridViewTextBoxColumn col_Price;
        private DataGridViewTextBoxColumn col_Department;
        private DataGridViewComboBoxColumn col_Manufacturer;
        private DatabaseManagementOperationsLibrary.CalendarColumn col_date_of_purchase;
        private DataGridView dtgrd_manufacturer;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn col_manufName;
        private DataGridViewTextBoxColumn col_manufEmailAdd;
        private DataGridViewTextBoxColumn col_manufContactNumber;
        private DataGridViewTextBoxColumn col_manufCountry;
        private DataGridViewTextBoxColumn col_manufCity;
        private DataGridViewTextBoxColumn col_manufZip;
    }
}