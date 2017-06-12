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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ttip_optionHints = new System.Windows.Forms.ToolTip(this.components);
            this.btn_forward = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarColumn1 = new DatabaseManagementOperationsLibrary.CalendarColumn();
            this.grpbx_options = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemPerPageUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pageSelector = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_equipment)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStripA.SuspendLayout();
            this.grpbx_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPerPageUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrd_equipment
            // 
            this.dtgrd_equipment.AllowUserToAddRows = false;
            this.dtgrd_equipment.AllowUserToDeleteRows = false;
            this.dtgrd_equipment.AllowUserToResizeColumns = false;
            this.dtgrd_equipment.AllowUserToResizeRows = false;
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
            this.dtgrd_equipment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgrd_equipment.Location = new System.Drawing.Point(184, 32);
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
            this.dtgrd_equipment.Size = new System.Drawing.Size(680, 403);
            this.dtgrd_equipment.TabIndex = 1;
            this.dtgrd_equipment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_equipment_CellValueChanged);
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
            this.col_Condition.Items.AddRange(new object[] {
            "Good",
            "Under Repair",
            "Needs Replacement",
            "Lost"});
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
            this.manufacturerToolStripMenuItem.Click += new System.EventHandler(this.manufacturerToolStripMenuItem_Click);
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
            this.stsstrplbl_currentSortDirection});
            this.statusStripA.Location = new System.Drawing.Point(0, 439);
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
            // ttip_optionHints
            // 
            this.ttip_optionHints.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // btn_forward
            // 
            this.btn_forward.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_fast_forward_black_18dp_1x;
            this.btn_forward.Location = new System.Drawing.Point(112, 376);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(32, 24);
            this.btn_forward.TabIndex = 11;
            this.ttip_optionHints.SetToolTip(this.btn_forward, "Save the changes you made to the database.");
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_back
            // 
            this.btn_back.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_fast_rewind_black_18dp_1x;
            this.btn_back.Location = new System.Drawing.Point(32, 376);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(32, 24);
            this.btn_back.TabIndex = 10;
            this.ttip_optionHints.SetToolTip(this.btn_back, "Save the changes you made to the database.");
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // button2
            // 
            this.button2.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_save_black_18dp_1x;
            this.button2.Location = new System.Drawing.Point(8, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 8;
            this.ttip_optionHints.SetToolTip(this.button2, "Save the changes you made to the database.");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn5.HeaderText = "Department";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 5;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.DataPropertyName = "Date of Purchase";
            this.calendarColumn1.HeaderText = "Date of Purchase";
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.calendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // grpbx_options
            // 
            this.grpbx_options.Controls.Add(this.label2);
            this.grpbx_options.Controls.Add(this.button2);
            this.grpbx_options.Controls.Add(this.itemPerPageUpDown);
            this.grpbx_options.Location = new System.Drawing.Point(8, 24);
            this.grpbx_options.Margin = new System.Windows.Forms.Padding(2);
            this.grpbx_options.Name = "grpbx_options";
            this.grpbx_options.Padding = new System.Windows.Forms.Padding(2);
            this.grpbx_options.Size = new System.Drawing.Size(168, 104);
            this.grpbx_options.TabIndex = 9;
            this.grpbx_options.TabStop = false;
            this.grpbx_options.Text = "Options";
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
            // itemPerPageUpDown
            // 
            this.itemPerPageUpDown.Location = new System.Drawing.Point(8, 72);
            this.itemPerPageUpDown.Name = "itemPerPageUpDown";
            this.itemPerPageUpDown.Size = new System.Drawing.Size(72, 20);
            this.itemPerPageUpDown.TabIndex = 13;
            this.itemPerPageUpDown.ValueChanged += new System.EventHandler(this.itemPerPageUpDown_ValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(32, 408);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // pageSelector
            // 
            this.pageSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageSelector.Location = new System.Drawing.Point(72, 376);
            this.pageSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSelector.Name = "pageSelector";
            this.pageSelector.Size = new System.Drawing.Size(32, 23);
            this.pageSelector.TabIndex = 14;
            this.pageSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSelector.ValueChanged += new System.EventHandler(this.pageSelector_ValueChanged);
            // 
            // frm_EquipmentEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(873, 461);
            this.Controls.Add(this.pageSelector);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.grpbx_options);
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
            this.grpbx_options.ResumeLayout(false);
            this.grpbx_options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPerPageUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageSelector)).EndInit();
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
        private Button button2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DatabaseManagementOperationsLibrary.CalendarColumn calendarColumn1;
        private GroupBox grpbx_options;
        private DataGridViewTextBoxColumn col_ID;
        private DataGridViewTextBoxColumn col_Name;
        private DataGridViewComboBoxColumn col_Condition;
        private DataGridViewTextBoxColumn col_Quantity;
        private DataGridViewTextBoxColumn col_Price;
        private DataGridViewTextBoxColumn col_Department;
        private DataGridViewComboBoxColumn col_Manufacturer;
        private DatabaseManagementOperationsLibrary.CalendarColumn col_date_of_purchase;
        private Button btn_back;
        private Button btn_forward;
        private Button btnRefresh;
        private NumericUpDown itemPerPageUpDown;
        private NumericUpDown pageSelector;
        private Label label2;
    }
}