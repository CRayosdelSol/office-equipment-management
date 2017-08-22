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
            this.grpbx_GeneralEquipmentSummary = new System.Windows.Forms.GroupBox();
            this.lbl_GenNeedsReplacementCondition = new System.Windows.Forms.Label();
            this.lbl_TotalNumberOfEquipments = new System.Windows.Forms.Label();
            this.lbl_GenLostCondition = new System.Windows.Forms.Label();
            this.lbl_GenGoodCondition = new System.Windows.Forms.Label();
            this.lbl_GenUnderRepairCondition = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grpbx_summaryPerDept.SuspendLayout();
            this.grpbx_ManufacturerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_Tables)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.grpbx_GeneralEquipmentSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx_summaryPerDept
            // 
            this.grpbx_summaryPerDept.Controls.Add(this.lbl_totalNumberOfEquipmentOwned);
            this.grpbx_summaryPerDept.Controls.Add(this.lbl_needsReplacement);
            this.grpbx_summaryPerDept.Controls.Add(this.lbl_LostCondition);
            this.grpbx_summaryPerDept.Controls.Add(this.lbl_UnderRepairCondition);
            this.grpbx_summaryPerDept.Controls.Add(this.lbl_GoodCondition);
            this.grpbx_summaryPerDept.Location = new System.Drawing.Point(8, 156);
            this.grpbx_summaryPerDept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbx_summaryPerDept.Name = "grpbx_summaryPerDept";
            this.grpbx_summaryPerDept.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbx_summaryPerDept.Size = new System.Drawing.Size(183, 120);
            this.grpbx_summaryPerDept.TabIndex = 0;
            this.grpbx_summaryPerDept.TabStop = false;
            this.grpbx_summaryPerDept.Text = "Department ID";
            // 
            // lbl_totalNumberOfEquipmentOwned
            // 
            this.lbl_totalNumberOfEquipmentOwned.AutoSize = true;
            this.lbl_totalNumberOfEquipmentOwned.Location = new System.Drawing.Point(4, 101);
            this.lbl_totalNumberOfEquipmentOwned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_totalNumberOfEquipmentOwned.Name = "lbl_totalNumberOfEquipmentOwned";
            this.lbl_totalNumberOfEquipmentOwned.Size = new System.Drawing.Size(158, 13);
            this.lbl_totalNumberOfEquipmentOwned.TabIndex = 4;
            this.lbl_totalNumberOfEquipmentOwned.Text = "Number of Equipments owned: -";
            // 
            // lbl_needsReplacement
            // 
            this.lbl_needsReplacement.AutoSize = true;
            this.lbl_needsReplacement.Location = new System.Drawing.Point(4, 80);
            this.lbl_needsReplacement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_needsReplacement.Name = "lbl_needsReplacement";
            this.lbl_needsReplacement.Size = new System.Drawing.Size(113, 13);
            this.lbl_needsReplacement.TabIndex = 3;
            this.lbl_needsReplacement.Text = "Needs Replacement: -";
            // 
            // lbl_LostCondition
            // 
            this.lbl_LostCondition.AutoSize = true;
            this.lbl_LostCondition.Location = new System.Drawing.Point(4, 60);
            this.lbl_LostCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LostCondition.Name = "lbl_LostCondition";
            this.lbl_LostCondition.Size = new System.Drawing.Size(36, 13);
            this.lbl_LostCondition.TabIndex = 2;
            this.lbl_LostCondition.Text = "Lost: -";
            // 
            // lbl_UnderRepairCondition
            // 
            this.lbl_UnderRepairCondition.AutoSize = true;
            this.lbl_UnderRepairCondition.Location = new System.Drawing.Point(4, 42);
            this.lbl_UnderRepairCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UnderRepairCondition.Name = "lbl_UnderRepairCondition";
            this.lbl_UnderRepairCondition.Size = new System.Drawing.Size(79, 13);
            this.lbl_UnderRepairCondition.TabIndex = 1;
            this.lbl_UnderRepairCondition.Text = "Under Repair: -";
            // 
            // lbl_GoodCondition
            // 
            this.lbl_GoodCondition.AutoSize = true;
            this.lbl_GoodCondition.Location = new System.Drawing.Point(4, 21);
            this.lbl_GoodCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GoodCondition.Name = "lbl_GoodCondition";
            this.lbl_GoodCondition.Size = new System.Drawing.Size(84, 13);
            this.lbl_GoodCondition.TabIndex = 0;
            this.lbl_GoodCondition.Text = "Good Conditon -";
            // 
            // grpbx_ManufacturerInfo
            // 
            this.grpbx_ManufacturerInfo.Controls.Add(this.lbl_CountryOfOrigin);
            this.grpbx_ManufacturerInfo.Controls.Add(this.lbl_ManufContactNumber);
            this.grpbx_ManufacturerInfo.Controls.Add(this.lbl_Manufemail);
            this.grpbx_ManufacturerInfo.Controls.Add(this.lbl_ManufName);
            this.grpbx_ManufacturerInfo.Location = new System.Drawing.Point(8, 279);
            this.grpbx_ManufacturerInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbx_ManufacturerInfo.Name = "grpbx_ManufacturerInfo";
            this.grpbx_ManufacturerInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbx_ManufacturerInfo.Size = new System.Drawing.Size(183, 94);
            this.grpbx_ManufacturerInfo.TabIndex = 1;
            this.grpbx_ManufacturerInfo.TabStop = false;
            this.grpbx_ManufacturerInfo.Text = "Manufacturer Information";
            // 
            // lbl_CountryOfOrigin
            // 
            this.lbl_CountryOfOrigin.AutoSize = true;
            this.lbl_CountryOfOrigin.Location = new System.Drawing.Point(3, 75);
            this.lbl_CountryOfOrigin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CountryOfOrigin.Name = "lbl_CountryOfOrigin";
            this.lbl_CountryOfOrigin.Size = new System.Drawing.Size(94, 13);
            this.lbl_CountryOfOrigin.TabIndex = 9;
            this.lbl_CountryOfOrigin.Text = "Country of Origin: -";
            // 
            // lbl_ManufContactNumber
            // 
            this.lbl_ManufContactNumber.AutoSize = true;
            this.lbl_ManufContactNumber.Location = new System.Drawing.Point(4, 57);
            this.lbl_ManufContactNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ManufContactNumber.Name = "lbl_ManufContactNumber";
            this.lbl_ManufContactNumber.Size = new System.Drawing.Size(93, 13);
            this.lbl_ManufContactNumber.TabIndex = 8;
            this.lbl_ManufContactNumber.Text = "Contact Number: -";
            // 
            // lbl_Manufemail
            // 
            this.lbl_Manufemail.AutoSize = true;
            this.lbl_Manufemail.Location = new System.Drawing.Point(4, 38);
            this.lbl_Manufemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Manufemail.Name = "lbl_Manufemail";
            this.lbl_Manufemail.Size = new System.Drawing.Size(85, 13);
            this.lbl_Manufemail.TabIndex = 7;
            this.lbl_Manufemail.Text = "E-mail Address: -";
            // 
            // lbl_ManufName
            // 
            this.lbl_ManufName.AutoSize = true;
            this.lbl_ManufName.Location = new System.Drawing.Point(4, 18);
            this.lbl_ManufName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ManufName.Name = "lbl_ManufName";
            this.lbl_ManufName.Size = new System.Drawing.Size(44, 13);
            this.lbl_ManufName.TabIndex = 6;
            this.lbl_ManufName.Text = "Name: -";
            // 
            // dtgrd_Tables
            // 
            this.dtgrd_Tables.AllowUserToAddRows = false;
            this.dtgrd_Tables.AllowUserToDeleteRows = false;
            this.dtgrd_Tables.AllowUserToOrderColumns = true;
            this.dtgrd_Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_Tables.Location = new System.Drawing.Point(196, 42);
            this.dtgrd_Tables.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgrd_Tables.MultiSelect = false;
            this.dtgrd_Tables.Name = "dtgrd_Tables";
            this.dtgrd_Tables.ReadOnly = true;
            this.dtgrd_Tables.RowTemplate.Height = 28;
            this.dtgrd_Tables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrd_Tables.Size = new System.Drawing.Size(693, 411);
            this.dtgrd_Tables.TabIndex = 2;
            this.dtgrd_Tables.SelectionChanged += new System.EventHandler(this.dtgrd_Tables_SelectionChanged);
            this.dtgrd_Tables.Click += new System.EventHandler(this.dtgrd_Tables_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttts_TableDisplayed});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(903, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttts_TableDisplayed
            // 
            this.sttts_TableDisplayed.Name = "sttts_TableDisplayed";
            this.sttts_TableDisplayed.Size = new System.Drawing.Size(152, 17);
            this.sttts_TableDisplayed.Text = "Currently Displayed Table: -";
            // 
            // grpbx_GeneralEquipmentSummary
            // 
            this.grpbx_GeneralEquipmentSummary.Controls.Add(this.lbl_GenNeedsReplacementCondition);
            this.grpbx_GeneralEquipmentSummary.Controls.Add(this.lbl_TotalNumberOfEquipments);
            this.grpbx_GeneralEquipmentSummary.Controls.Add(this.lbl_GenLostCondition);
            this.grpbx_GeneralEquipmentSummary.Controls.Add(this.lbl_GenGoodCondition);
            this.grpbx_GeneralEquipmentSummary.Controls.Add(this.lbl_GenUnderRepairCondition);
            this.grpbx_GeneralEquipmentSummary.Location = new System.Drawing.Point(8, 42);
            this.grpbx_GeneralEquipmentSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbx_GeneralEquipmentSummary.Name = "grpbx_GeneralEquipmentSummary";
            this.grpbx_GeneralEquipmentSummary.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbx_GeneralEquipmentSummary.Size = new System.Drawing.Size(177, 110);
            this.grpbx_GeneralEquipmentSummary.TabIndex = 19;
            this.grpbx_GeneralEquipmentSummary.TabStop = false;
            this.grpbx_GeneralEquipmentSummary.Text = "Summary";
            // 
            // lbl_GenNeedsReplacementCondition
            // 
            this.lbl_GenNeedsReplacementCondition.AutoSize = true;
            this.lbl_GenNeedsReplacementCondition.Location = new System.Drawing.Point(4, 88);
            this.lbl_GenNeedsReplacementCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GenNeedsReplacementCondition.Name = "lbl_GenNeedsReplacementCondition";
            this.lbl_GenNeedsReplacementCondition.Size = new System.Drawing.Size(113, 13);
            this.lbl_GenNeedsReplacementCondition.TabIndex = 8;
            this.lbl_GenNeedsReplacementCondition.Text = "Needs Replacement: -";
            // 
            // lbl_TotalNumberOfEquipments
            // 
            this.lbl_TotalNumberOfEquipments.AutoSize = true;
            this.lbl_TotalNumberOfEquipments.Location = new System.Drawing.Point(4, 17);
            this.lbl_TotalNumberOfEquipments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TotalNumberOfEquipments.Name = "lbl_TotalNumberOfEquipments";
            this.lbl_TotalNumberOfEquipments.Size = new System.Drawing.Size(129, 13);
            this.lbl_TotalNumberOfEquipments.TabIndex = 5;
            this.lbl_TotalNumberOfEquipments.Text = "Number of Present Items: ";
            // 
            // lbl_GenLostCondition
            // 
            this.lbl_GenLostCondition.AutoSize = true;
            this.lbl_GenLostCondition.Location = new System.Drawing.Point(4, 70);
            this.lbl_GenLostCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GenLostCondition.Name = "lbl_GenLostCondition";
            this.lbl_GenLostCondition.Size = new System.Drawing.Size(36, 13);
            this.lbl_GenLostCondition.TabIndex = 7;
            this.lbl_GenLostCondition.Text = "Lost: -";
            // 
            // lbl_GenGoodCondition
            // 
            this.lbl_GenGoodCondition.AutoSize = true;
            this.lbl_GenGoodCondition.Location = new System.Drawing.Point(4, 34);
            this.lbl_GenGoodCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GenGoodCondition.Name = "lbl_GenGoodCondition";
            this.lbl_GenGoodCondition.Size = new System.Drawing.Size(84, 13);
            this.lbl_GenGoodCondition.TabIndex = 5;
            this.lbl_GenGoodCondition.Text = "Good Conditon -";
            // 
            // lbl_GenUnderRepairCondition
            // 
            this.lbl_GenUnderRepairCondition.AutoSize = true;
            this.lbl_GenUnderRepairCondition.Location = new System.Drawing.Point(4, 53);
            this.lbl_GenUnderRepairCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GenUnderRepairCondition.Name = "lbl_GenUnderRepairCondition";
            this.lbl_GenUnderRepairCondition.Size = new System.Drawing.Size(79, 13);
            this.lbl_GenUnderRepairCondition.TabIndex = 6;
            this.lbl_GenUnderRepairCondition.Text = "Under Repair: -";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(903, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FRM_TableViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 478);
            this.Controls.Add(this.grpbx_GeneralEquipmentSummary);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dtgrd_Tables);
            this.Controls.Add(this.grpbx_ManufacturerInfo);
            this.Controls.Add(this.grpbx_summaryPerDept);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.grpbx_GeneralEquipmentSummary.ResumeLayout(false);
            this.grpbx_GeneralEquipmentSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_summaryPerDept;
        private System.Windows.Forms.GroupBox grpbx_ManufacturerInfo;
        private System.Windows.Forms.DataGridView dtgrd_Tables;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sttts_TableDisplayed;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}