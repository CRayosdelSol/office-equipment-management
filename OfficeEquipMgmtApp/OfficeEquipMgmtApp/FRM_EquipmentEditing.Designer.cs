﻿using System.Windows.Forms;

namespace OfficeEquipMgmtApp
{
    partial class frm_EquipmentView
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
            this.dtgrd_equipment = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbx_ItemDescription = new System.Windows.Forms.TextBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_updateEquipemntInfo = new System.Windows.Forms.Button();
            this.btn_EditEquipment = new System.Windows.Forms.Button();
            this.btn_DeleteEquipment = new System.Windows.Forms.Button();
            this.btn_NewEquipment = new System.Windows.Forms.Button();
            this.grpbx_setItemCondition = new System.Windows.Forms.GroupBox();
            this.btn_forReplacementCondition = new System.Windows.Forms.Button();
            this.btn_UnderRepairCondition = new System.Windows.Forms.Button();
            this.btn_lostCondition = new System.Windows.Forms.Button();
            this.btn_GoodItemConditon = new System.Windows.Forms.Button();
            this.ttip_optionHints = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_equipment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStripA.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpbx_setItemCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrd_equipment
            // 
            this.dtgrd_equipment.AllowUserToAddRows = false;
            this.dtgrd_equipment.AllowUserToDeleteRows = false;
            this.dtgrd_equipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_equipment.Location = new System.Drawing.Point(264, 48);
            this.dtgrd_equipment.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrd_equipment.Name = "dtgrd_equipment";
            this.dtgrd_equipment.ReadOnly = true;
            this.dtgrd_equipment.RowTemplate.Height = 28;
            this.dtgrd_equipment.Size = new System.Drawing.Size(1032, 604);
            this.dtgrd_equipment.TabIndex = 1;
            this.dtgrd_equipment.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrd_equipment_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 392);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(240, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "The item was not found.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 29);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = global::OfficeEquipMgmtApp.Properties.Resources.Search_16x;
            this.button1.Location = new System.Drawing.Point(160, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 48);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbx_ItemDescription);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 256);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(240, 136);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Description";
            // 
            // txtbx_ItemDescription
            // 
            this.txtbx_ItemDescription.Location = new System.Drawing.Point(8, 32);
            this.txtbx_ItemDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_ItemDescription.Multiline = true;
            this.txtbx_ItemDescription.Name = "txtbx_ItemDescription";
            this.txtbx_ItemDescription.Size = new System.Drawing.Size(224, 98);
            this.txtbx_ItemDescription.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortItemsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1309, 35);
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
            this.manufacturerToolStripMenuItem.Click += new System.EventHandler(this.manufacturerToolStripMenuItem_Click);
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
            this.stsstrplbl_currentSortDirection});
            this.statusStripA.Location = new System.Drawing.Point(0, 662);
            this.statusStripA.Name = "statusStripA";
            this.statusStripA.Padding = new System.Windows.Forms.Padding(3, 0, 21, 0);
            this.statusStripA.Size = new System.Drawing.Size(1309, 30);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_updateEquipemntInfo);
            this.groupBox3.Controls.Add(this.btn_EditEquipment);
            this.groupBox3.Controls.Add(this.btn_DeleteEquipment);
            this.groupBox3.Controls.Add(this.btn_NewEquipment);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 152);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(240, 96);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Table Options";
            // 
            // btn_updateEquipemntInfo
            // 
            this.btn_updateEquipemntInfo.Image = global::OfficeEquipMgmtApp.Properties.Resources.UpdateDatabase_16x;
            this.btn_updateEquipemntInfo.Location = new System.Drawing.Point(120, 40);
            this.btn_updateEquipemntInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_updateEquipemntInfo.Name = "btn_updateEquipemntInfo";
            this.btn_updateEquipemntInfo.Size = new System.Drawing.Size(56, 48);
            this.btn_updateEquipemntInfo.TabIndex = 6;
            this.ttip_optionHints.SetToolTip(this.btn_updateEquipemntInfo, "Update the infromation for the currently selected equipment.");
            this.btn_updateEquipemntInfo.UseVisualStyleBackColor = true;
            // 
            // btn_EditEquipment
            // 
            this.btn_EditEquipment.Image = global::OfficeEquipMgmtApp.Properties.Resources.Edit_grey_16x;
            this.btn_EditEquipment.Location = new System.Drawing.Point(64, 40);
            this.btn_EditEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EditEquipment.Name = "btn_EditEquipment";
            this.btn_EditEquipment.Size = new System.Drawing.Size(56, 48);
            this.btn_EditEquipment.TabIndex = 5;
            this.ttip_optionHints.SetToolTip(this.btn_EditEquipment, "Edit the currently selected equipment.");
            this.btn_EditEquipment.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteEquipment
            // 
            this.btn_DeleteEquipment.Image = global::OfficeEquipMgmtApp.Properties.Resources.DeleteCell_16x;
            this.btn_DeleteEquipment.Location = new System.Drawing.Point(176, 40);
            this.btn_DeleteEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DeleteEquipment.Name = "btn_DeleteEquipment";
            this.btn_DeleteEquipment.Size = new System.Drawing.Size(56, 48);
            this.btn_DeleteEquipment.TabIndex = 4;
            this.ttip_optionHints.SetToolTip(this.btn_DeleteEquipment, "Delete the currently selected equipment from the database.");
            this.btn_DeleteEquipment.UseVisualStyleBackColor = true;
            this.btn_DeleteEquipment.Click += new System.EventHandler(this.btn_DeleteEquipment_Click);
            // 
            // btn_NewEquipment
            // 
            this.btn_NewEquipment.Image = global::OfficeEquipMgmtApp.Properties.Resources.Add_grey_16x;
            this.btn_NewEquipment.Location = new System.Drawing.Point(6, 40);
            this.btn_NewEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NewEquipment.Name = "btn_NewEquipment";
            this.btn_NewEquipment.Size = new System.Drawing.Size(56, 48);
            this.btn_NewEquipment.TabIndex = 3;
            this.ttip_optionHints.SetToolTip(this.btn_NewEquipment, "Add a new equipment.");
            this.btn_NewEquipment.UseVisualStyleBackColor = true;
            // 
            // grpbx_setItemCondition
            // 
            this.grpbx_setItemCondition.Controls.Add(this.btn_forReplacementCondition);
            this.grpbx_setItemCondition.Controls.Add(this.btn_UnderRepairCondition);
            this.grpbx_setItemCondition.Controls.Add(this.btn_lostCondition);
            this.grpbx_setItemCondition.Controls.Add(this.btn_GoodItemConditon);
            this.grpbx_setItemCondition.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_setItemCondition.Location = new System.Drawing.Point(16, 48);
            this.grpbx_setItemCondition.Margin = new System.Windows.Forms.Padding(4);
            this.grpbx_setItemCondition.Name = "grpbx_setItemCondition";
            this.grpbx_setItemCondition.Padding = new System.Windows.Forms.Padding(4);
            this.grpbx_setItemCondition.Size = new System.Drawing.Size(240, 96);
            this.grpbx_setItemCondition.TabIndex = 7;
            this.grpbx_setItemCondition.TabStop = false;
            this.grpbx_setItemCondition.Text = "Item Condition";
            // 
            // btn_forReplacementCondition
            // 
            this.btn_forReplacementCondition.Image = global::OfficeEquipMgmtApp.Properties.Resources.Condition_NeedsReplacemnet;
            this.btn_forReplacementCondition.Location = new System.Drawing.Point(120, 40);
            this.btn_forReplacementCondition.Margin = new System.Windows.Forms.Padding(4);
            this.btn_forReplacementCondition.Name = "btn_forReplacementCondition";
            this.btn_forReplacementCondition.Size = new System.Drawing.Size(56, 48);
            this.btn_forReplacementCondition.TabIndex = 6;
            this.ttip_optionHints.SetToolTip(this.btn_forReplacementCondition, "The item is in need of a replacement.");
            this.btn_forReplacementCondition.UseVisualStyleBackColor = true;
            this.btn_forReplacementCondition.Click += new System.EventHandler(this.btn_forReplacementCondition_Click);
            // 
            // btn_UnderRepairCondition
            // 
            this.btn_UnderRepairCondition.Image = global::OfficeEquipMgmtApp.Properties.Resources.Condition_UnderRepair;
            this.btn_UnderRepairCondition.Location = new System.Drawing.Point(64, 40);
            this.btn_UnderRepairCondition.Margin = new System.Windows.Forms.Padding(4);
            this.btn_UnderRepairCondition.Name = "btn_UnderRepairCondition";
            this.btn_UnderRepairCondition.Size = new System.Drawing.Size(56, 48);
            this.btn_UnderRepairCondition.TabIndex = 5;
            this.ttip_optionHints.SetToolTip(this.btn_UnderRepairCondition, "The item is under repair.");
            this.btn_UnderRepairCondition.UseVisualStyleBackColor = true;
            this.btn_UnderRepairCondition.Click += new System.EventHandler(this.btn_UnderRepairCondition_Click);
            // 
            // btn_lostCondition
            // 
            this.btn_lostCondition.Image = global::OfficeEquipMgmtApp.Properties.Resources.Condition_Lost;
            this.btn_lostCondition.Location = new System.Drawing.Point(176, 40);
            this.btn_lostCondition.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lostCondition.Name = "btn_lostCondition";
            this.btn_lostCondition.Size = new System.Drawing.Size(56, 48);
            this.btn_lostCondition.TabIndex = 4;
            this.ttip_optionHints.SetToolTip(this.btn_lostCondition, "The item is lost.");
            this.btn_lostCondition.UseVisualStyleBackColor = true;
            this.btn_lostCondition.Click += new System.EventHandler(this.btn_lostCondition_Click);
            // 
            // btn_GoodItemConditon
            // 
            this.btn_GoodItemConditon.Image = global::OfficeEquipMgmtApp.Properties.Resources.Condition_Good;
            this.btn_GoodItemConditon.Location = new System.Drawing.Point(6, 40);
            this.btn_GoodItemConditon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GoodItemConditon.Name = "btn_GoodItemConditon";
            this.btn_GoodItemConditon.Size = new System.Drawing.Size(56, 48);
            this.btn_GoodItemConditon.TabIndex = 3;
            this.ttip_optionHints.SetToolTip(this.btn_GoodItemConditon, "The item is in good condtion.");
            this.btn_GoodItemConditon.UseVisualStyleBackColor = true;
            this.btn_GoodItemConditon.Click += new System.EventHandler(this.btn_GoodItemConditon_Click);
            // 
            // ttip_optionHints
            // 
            this.ttip_optionHints.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frm_EquipmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1309, 692);
            this.Controls.Add(this.grpbx_setItemCondition);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStripA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgrd_equipment);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_EquipmentView";
            this.ShowIcon = false;
            this.Text = "FRM_EquipmentView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_EquipmentView_FormClosing);
            this.Load += new System.EventHandler(this.frm_EquipmentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_equipment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripA.ResumeLayout(false);
            this.statusStripA.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.grpbx_setItemCondition.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrd_equipment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbx_ItemDescription;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripA;
        private System.Windows.Forms.ToolStripStatusLabel stsstrplbl_currentSort;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private GroupBox groupBox3;
        private Button btn_EditEquipment;
        private Button btn_DeleteEquipment;
        private Button btn_NewEquipment;
        private ToolStripMenuItem ascendingToolStripMenuItem1;
        private ToolStripMenuItem descendingToolStripMenuItem1;
        private ToolStripStatusLabel stsstrplbl_currentSortDirection;
        private Button btn_updateEquipemntInfo;
        private ToolTip ttip_optionHints;
        private GroupBox grpbx_setItemCondition;
        private Button btn_forReplacementCondition;
        private Button btn_UnderRepairCondition;
        private Button btn_lostCondition;
        private Button btn_GoodItemConditon;
    }
}