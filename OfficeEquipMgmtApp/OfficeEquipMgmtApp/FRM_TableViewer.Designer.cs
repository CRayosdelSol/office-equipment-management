namespace OfficeEquipMgmtApp
{
    partial class FRM_TableViewer
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
            this.grpbx_summaryPerDept = new System.Windows.Forms.GroupBox();
            this.lbl_totalNumberOfEquipmentOwned = new System.Windows.Forms.Label();
            this.lbl_needsReplacement = new System.Windows.Forms.Label();
            this.lbl_LostCondition = new System.Windows.Forms.Label();
            this.lbl_UnderRepairCondition = new System.Windows.Forms.Label();
            this.lbl_GoodCondition = new System.Windows.Forms.Label();
            this.grpbx_ManufacturerInfo = new System.Windows.Forms.GroupBox();
            this.lbl_CountryOfOrigin = new System.Windows.Forms.Label();
            this.lbl_ManufContactNumber = new System.Windows.Forms.Label();
            this.lbl_Manufemail = new System.Windows.Forms.Label();
            this.lbl_ManufName = new System.Windows.Forms.Label();
            this.dtgrd_Tables = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttts_TableDisplayed = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTableInEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.pageSelector = new System.Windows.Forms.NumericUpDown();
            this.grpbx_GeneralEquipmentSummary = new System.Windows.Forms.GroupBox();
            this.lbl_GenNeedsReplacementCondition = new System.Windows.Forms.Label();
            this.lbl_TotalNumberOfEquipments = new System.Windows.Forms.Label();
            this.lbl_GenLostCondition = new System.Windows.Forms.Label();
            this.lbl_GenGoodCondition = new System.Windows.Forms.Label();
            this.lbl_GenUnderRepairCondition = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.itemPerPageUpDown = new System.Windows.Forms.NumericUpDown();
            this.btn_forward = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.grpbx_summaryPerDept.SuspendLayout();
            this.grpbx_ManufacturerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_Tables)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageSelector)).BeginInit();
            this.grpbx_GeneralEquipmentSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPerPageUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbx_summaryPerDept
            // 
            this.grpbx_summaryPerDept.Controls.Add(this.lbl_totalNumberOfEquipmentOwned);
            this.grpbx_summaryPerDept.Controls.Add(this.lbl_needsReplacement);
            this.grpbx_summaryPerDept.Controls.Add(this.lbl_LostCondition);
            this.grpbx_summaryPerDept.Controls.Add(this.lbl_UnderRepairCondition);
            this.grpbx_summaryPerDept.Controls.Add(this.lbl_GoodCondition);
            this.grpbx_summaryPerDept.Location = new System.Drawing.Point(12, 240);
            this.grpbx_summaryPerDept.Name = "grpbx_summaryPerDept";
            this.grpbx_summaryPerDept.Size = new System.Drawing.Size(275, 184);
            this.grpbx_summaryPerDept.TabIndex = 0;
            this.grpbx_summaryPerDept.TabStop = false;
            this.grpbx_summaryPerDept.Text = "Department ID";
            // 
            // lbl_totalNumberOfEquipmentOwned
            // 
            this.lbl_totalNumberOfEquipmentOwned.AutoSize = true;
            this.lbl_totalNumberOfEquipmentOwned.Location = new System.Drawing.Point(6, 155);
            this.lbl_totalNumberOfEquipmentOwned.Name = "lbl_totalNumberOfEquipmentOwned";
            this.lbl_totalNumberOfEquipmentOwned.Size = new System.Drawing.Size(236, 20);
            this.lbl_totalNumberOfEquipmentOwned.TabIndex = 4;
            this.lbl_totalNumberOfEquipmentOwned.Text = "Number of Equipments owned: -";
            // 
            // lbl_needsReplacement
            // 
            this.lbl_needsReplacement.AutoSize = true;
            this.lbl_needsReplacement.Location = new System.Drawing.Point(6, 123);
            this.lbl_needsReplacement.Name = "lbl_needsReplacement";
            this.lbl_needsReplacement.Size = new System.Drawing.Size(167, 20);
            this.lbl_needsReplacement.TabIndex = 3;
            this.lbl_needsReplacement.Text = "Needs Replacement: -";
            // 
            // lbl_LostCondition
            // 
            this.lbl_LostCondition.AutoSize = true;
            this.lbl_LostCondition.Location = new System.Drawing.Point(6, 92);
            this.lbl_LostCondition.Name = "lbl_LostCondition";
            this.lbl_LostCondition.Size = new System.Drawing.Size(53, 20);
            this.lbl_LostCondition.TabIndex = 2;
            this.lbl_LostCondition.Text = "Lost: -";
            // 
            // lbl_UnderRepairCondition
            // 
            this.lbl_UnderRepairCondition.AutoSize = true;
            this.lbl_UnderRepairCondition.Location = new System.Drawing.Point(6, 64);
            this.lbl_UnderRepairCondition.Name = "lbl_UnderRepairCondition";
            this.lbl_UnderRepairCondition.Size = new System.Drawing.Size(117, 20);
            this.lbl_UnderRepairCondition.TabIndex = 1;
            this.lbl_UnderRepairCondition.Text = "Under Repair: -";
            // 
            // lbl_GoodCondition
            // 
            this.lbl_GoodCondition.AutoSize = true;
            this.lbl_GoodCondition.Location = new System.Drawing.Point(6, 33);
            this.lbl_GoodCondition.Name = "lbl_GoodCondition";
            this.lbl_GoodCondition.Size = new System.Drawing.Size(126, 20);
            this.lbl_GoodCondition.TabIndex = 0;
            this.lbl_GoodCondition.Text = "Good Conditon -";
            // 
            // grpbx_ManufacturerInfo
            // 
            this.grpbx_ManufacturerInfo.Controls.Add(this.lbl_CountryOfOrigin);
            this.grpbx_ManufacturerInfo.Controls.Add(this.lbl_ManufContactNumber);
            this.grpbx_ManufacturerInfo.Controls.Add(this.lbl_Manufemail);
            this.grpbx_ManufacturerInfo.Controls.Add(this.lbl_ManufName);
            this.grpbx_ManufacturerInfo.Location = new System.Drawing.Point(12, 430);
            this.grpbx_ManufacturerInfo.Name = "grpbx_ManufacturerInfo";
            this.grpbx_ManufacturerInfo.Size = new System.Drawing.Size(275, 144);
            this.grpbx_ManufacturerInfo.TabIndex = 1;
            this.grpbx_ManufacturerInfo.TabStop = false;
            this.grpbx_ManufacturerInfo.Text = "Manufacturer Information";
            // 
            // lbl_CountryOfOrigin
            // 
            this.lbl_CountryOfOrigin.AutoSize = true;
            this.lbl_CountryOfOrigin.Location = new System.Drawing.Point(5, 116);
            this.lbl_CountryOfOrigin.Name = "lbl_CountryOfOrigin";
            this.lbl_CountryOfOrigin.Size = new System.Drawing.Size(140, 20);
            this.lbl_CountryOfOrigin.TabIndex = 9;
            this.lbl_CountryOfOrigin.Text = "Country of Origin: -";
            // 
            // lbl_ManufContactNumber
            // 
            this.lbl_ManufContactNumber.AutoSize = true;
            this.lbl_ManufContactNumber.Location = new System.Drawing.Point(6, 87);
            this.lbl_ManufContactNumber.Name = "lbl_ManufContactNumber";
            this.lbl_ManufContactNumber.Size = new System.Drawing.Size(138, 20);
            this.lbl_ManufContactNumber.TabIndex = 8;
            this.lbl_ManufContactNumber.Text = "Contact Number: -";
            // 
            // lbl_Manufemail
            // 
            this.lbl_Manufemail.AutoSize = true;
            this.lbl_Manufemail.Location = new System.Drawing.Point(6, 58);
            this.lbl_Manufemail.Name = "lbl_Manufemail";
            this.lbl_Manufemail.Size = new System.Drawing.Size(129, 20);
            this.lbl_Manufemail.TabIndex = 7;
            this.lbl_Manufemail.Text = "E-mail Address: -";
            // 
            // lbl_ManufName
            // 
            this.lbl_ManufName.AutoSize = true;
            this.lbl_ManufName.Location = new System.Drawing.Point(6, 28);
            this.lbl_ManufName.Name = "lbl_ManufName";
            this.lbl_ManufName.Size = new System.Drawing.Size(64, 20);
            this.lbl_ManufName.TabIndex = 6;
            this.lbl_ManufName.Text = "Name: -";
            // 
            // dtgrd_Tables
            // 
            this.dtgrd_Tables.AllowUserToAddRows = false;
            this.dtgrd_Tables.AllowUserToDeleteRows = false;
            this.dtgrd_Tables.AllowUserToOrderColumns = true;
            this.dtgrd_Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_Tables.Location = new System.Drawing.Point(294, 65);
            this.dtgrd_Tables.MultiSelect = false;
            this.dtgrd_Tables.Name = "dtgrd_Tables";
            this.dtgrd_Tables.ReadOnly = true;
            this.dtgrd_Tables.RowTemplate.Height = 28;
            this.dtgrd_Tables.Size = new System.Drawing.Size(1039, 633);
            this.dtgrd_Tables.TabIndex = 2;
            this.dtgrd_Tables.SelectionChanged += new System.EventHandler(this.dtgrd_Tables_SelectionChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttts_TableDisplayed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 705);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1355, 30);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttts_TableDisplayed
            // 
            this.sttts_TableDisplayed.Name = "sttts_TableDisplayed";
            this.sttts_TableDisplayed.Size = new System.Drawing.Size(227, 25);
            this.sttts_TableDisplayed.Text = "Currently Displayed Table: -";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1355, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTableInEditorToolStripMenuItem,
            this.loadTableToolStripMenuItem,
            this.generateReportToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.databaseToolStripMenuItem.Text = "&Database";
            // 
            // openTableInEditorToolStripMenuItem
            // 
            this.openTableInEditorToolStripMenuItem.Name = "openTableInEditorToolStripMenuItem";
            this.openTableInEditorToolStripMenuItem.Size = new System.Drawing.Size(255, 30);
            this.openTableInEditorToolStripMenuItem.Text = "Open table in editor";
            // 
            // loadTableToolStripMenuItem
            // 
            this.loadTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipmentToolStripMenuItem,
            this.manufacturersToolStripMenuItem});
            this.loadTableToolStripMenuItem.Name = "loadTableToolStripMenuItem";
            this.loadTableToolStripMenuItem.Size = new System.Drawing.Size(255, 30);
            this.loadTableToolStripMenuItem.Text = "Load Table";
            // 
            // equipmentToolStripMenuItem
            // 
            this.equipmentToolStripMenuItem.Name = "equipmentToolStripMenuItem";
            this.equipmentToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.equipmentToolStripMenuItem.Text = "Equipment";
            this.equipmentToolStripMenuItem.Click += new System.EventHandler(this.equipmentToolStripMenuItem_Click);
            // 
            // manufacturersToolStripMenuItem
            // 
            this.manufacturersToolStripMenuItem.Name = "manufacturersToolStripMenuItem";
            this.manufacturersToolStripMenuItem.Size = new System.Drawing.Size(209, 30);
            this.manufacturersToolStripMenuItem.Text = "Manufacturers";
            this.manufacturersToolStripMenuItem.Click += new System.EventHandler(this.manufacturersToolStripMenuItem_Click);
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(255, 30);
            this.generateReportToolStripMenuItem.Text = "&Generate Report";
            this.generateReportToolStripMenuItem.Click += new System.EventHandler(this.generateReportToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 678);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "PAGE NUMBER";
            // 
            // pageSelector
            // 
            this.pageSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageSelector.Location = new System.Drawing.Point(93, 644);
            this.pageSelector.Margin = new System.Windows.Forms.Padding(4);
            this.pageSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageSelector.Name = "pageSelector";
            this.pageSelector.Size = new System.Drawing.Size(112, 30);
            this.pageSelector.TabIndex = 18;
            this.pageSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pageSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpbx_GeneralEquipmentSummary
            // 
            this.grpbx_GeneralEquipmentSummary.Controls.Add(this.lbl_GenNeedsReplacementCondition);
            this.grpbx_GeneralEquipmentSummary.Controls.Add(this.lbl_TotalNumberOfEquipments);
            this.grpbx_GeneralEquipmentSummary.Controls.Add(this.lbl_GenLostCondition);
            this.grpbx_GeneralEquipmentSummary.Controls.Add(this.lbl_GenGoodCondition);
            this.grpbx_GeneralEquipmentSummary.Controls.Add(this.lbl_GenUnderRepairCondition);
            this.grpbx_GeneralEquipmentSummary.Location = new System.Drawing.Point(12, 65);
            this.grpbx_GeneralEquipmentSummary.Name = "grpbx_GeneralEquipmentSummary";
            this.grpbx_GeneralEquipmentSummary.Size = new System.Drawing.Size(265, 169);
            this.grpbx_GeneralEquipmentSummary.TabIndex = 19;
            this.grpbx_GeneralEquipmentSummary.TabStop = false;
            this.grpbx_GeneralEquipmentSummary.Text = "Summary";
            // 
            // lbl_GenNeedsReplacementCondition
            // 
            this.lbl_GenNeedsReplacementCondition.AutoSize = true;
            this.lbl_GenNeedsReplacementCondition.Location = new System.Drawing.Point(6, 135);
            this.lbl_GenNeedsReplacementCondition.Name = "lbl_GenNeedsReplacementCondition";
            this.lbl_GenNeedsReplacementCondition.Size = new System.Drawing.Size(167, 20);
            this.lbl_GenNeedsReplacementCondition.TabIndex = 8;
            this.lbl_GenNeedsReplacementCondition.Text = "Needs Replacement: -";
            // 
            // lbl_TotalNumberOfEquipments
            // 
            this.lbl_TotalNumberOfEquipments.AutoSize = true;
            this.lbl_TotalNumberOfEquipments.Location = new System.Drawing.Point(6, 26);
            this.lbl_TotalNumberOfEquipments.Name = "lbl_TotalNumberOfEquipments";
            this.lbl_TotalNumberOfEquipments.Size = new System.Drawing.Size(194, 20);
            this.lbl_TotalNumberOfEquipments.TabIndex = 5;
            this.lbl_TotalNumberOfEquipments.Text = "Number of Present Items: ";
            // 
            // lbl_GenLostCondition
            // 
            this.lbl_GenLostCondition.AutoSize = true;
            this.lbl_GenLostCondition.Location = new System.Drawing.Point(6, 108);
            this.lbl_GenLostCondition.Name = "lbl_GenLostCondition";
            this.lbl_GenLostCondition.Size = new System.Drawing.Size(53, 20);
            this.lbl_GenLostCondition.TabIndex = 7;
            this.lbl_GenLostCondition.Text = "Lost: -";
            // 
            // lbl_GenGoodCondition
            // 
            this.lbl_GenGoodCondition.AutoSize = true;
            this.lbl_GenGoodCondition.Location = new System.Drawing.Point(6, 52);
            this.lbl_GenGoodCondition.Name = "lbl_GenGoodCondition";
            this.lbl_GenGoodCondition.Size = new System.Drawing.Size(126, 20);
            this.lbl_GenGoodCondition.TabIndex = 5;
            this.lbl_GenGoodCondition.Text = "Good Conditon -";
            // 
            // lbl_GenUnderRepairCondition
            // 
            this.lbl_GenUnderRepairCondition.AutoSize = true;
            this.lbl_GenUnderRepairCondition.Location = new System.Drawing.Point(6, 81);
            this.lbl_GenUnderRepairCondition.Name = "lbl_GenUnderRepairCondition";
            this.lbl_GenUnderRepairCondition.Size = new System.Drawing.Size(117, 20);
            this.lbl_GenUnderRepairCondition.TabIndex = 6;
            this.lbl_GenUnderRepairCondition.Text = "Under Repair: -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "# OF RECORDS PER PAGE";
            // 
            // itemPerPageUpDown
            // 
            this.itemPerPageUpDown.Location = new System.Drawing.Point(81, 584);
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
            // 
            // btn_forward
            // 
            this.btn_forward.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_fast_forward_black_18dp_1x;
            this.btn_forward.Location = new System.Drawing.Point(227, 638);
            this.btn_forward.Margin = new System.Windows.Forms.Padding(6);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(60, 60);
            this.btn_forward.TabIndex = 12;
            this.btn_forward.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Image = global::OfficeEquipMgmtApp.Properties.Resources.ic_fast_rewind_black_18dp_1x;
            this.btn_back.Location = new System.Drawing.Point(12, 640);
            this.btn_back.Margin = new System.Windows.Forms.Padding(6);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(60, 60);
            this.btn_back.TabIndex = 11;
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // FRM_TableViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 735);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.itemPerPageUpDown);
            this.Controls.Add(this.grpbx_GeneralEquipmentSummary);
            this.Controls.Add(this.pageSelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dtgrd_Tables);
            this.Controls.Add(this.grpbx_ManufacturerInfo);
            this.Controls.Add(this.grpbx_summaryPerDept);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_TableViewer";
            this.Text = "FRM_TableViewer";
            this.Load += new System.EventHandler(this.FRM_TableViewer_Load);
            this.grpbx_summaryPerDept.ResumeLayout(false);
            this.grpbx_summaryPerDept.PerformLayout();
            this.grpbx_ManufacturerInfo.ResumeLayout(false);
            this.grpbx_ManufacturerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_Tables)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageSelector)).EndInit();
            this.grpbx_GeneralEquipmentSummary.ResumeLayout(false);
            this.grpbx_GeneralEquipmentSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemPerPageUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_summaryPerDept;
        private System.Windows.Forms.GroupBox grpbx_ManufacturerInfo;
        private System.Windows.Forms.DataGridView dtgrd_Tables;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTableInEditorToolStripMenuItem;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown pageSelector;
        private System.Windows.Forms.ToolStripStatusLabel sttts_TableDisplayed;
        private System.Windows.Forms.ToolStripMenuItem loadTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturersToolStripMenuItem;
        private System.Windows.Forms.Label lbl_needsReplacement;
        private System.Windows.Forms.Label lbl_LostCondition;
        private System.Windows.Forms.Label lbl_UnderRepairCondition;
        private System.Windows.Forms.Label lbl_GoodCondition;
        private System.Windows.Forms.Label lbl_totalNumberOfEquipmentOwned;
        private System.Windows.Forms.GroupBox grpbx_GeneralEquipmentSummary;
        private System.Windows.Forms.Label lbl_TotalNumberOfEquipments;
        private System.Windows.Forms.Label lbl_ManufName;
        private System.Windows.Forms.Label lbl_CountryOfOrigin;
        private System.Windows.Forms.Label lbl_ManufContactNumber;
        private System.Windows.Forms.Label lbl_Manufemail;
        private System.Windows.Forms.Label lbl_GenNeedsReplacementCondition;
        private System.Windows.Forms.Label lbl_GenLostCondition;
        private System.Windows.Forms.Label lbl_GenGoodCondition;
        private System.Windows.Forms.Label lbl_GenUnderRepairCondition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown itemPerPageUpDown;
        private System.Windows.Forms.ToolStripMenuItem generateReportToolStripMenuItem;
    }
}