namespace Report_Form
{
    partial class ConditionReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eqDataset = new Report_Form.eqDataset();
            this.reporter = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EquipmentTableAdapter = new Report_Form.eqDatasetTableAdapters.EquipmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eqDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // EquipmentBindingSource
            // 
            this.EquipmentBindingSource.DataMember = "Equipment";
            this.EquipmentBindingSource.DataSource = this.eqDataset;
            // 
            // eqDataset
            // 
            this.eqDataset.DataSetName = "eqDataset";
            this.eqDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporter
            // 
            this.reporter.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "reportDS";
            reportDataSource1.Value = this.EquipmentBindingSource;
            this.reporter.LocalReport.DataSources.Add(reportDataSource1);
            this.reporter.LocalReport.ReportEmbeddedResource = "Report_Form.Report1.rdlc";
            this.reporter.Location = new System.Drawing.Point(0, 0);
            this.reporter.Name = "reporter";
            this.reporter.Size = new System.Drawing.Size(832, 438);
            this.reporter.TabIndex = 0;
            // 
            // EquipmentTableAdapter
            // 
            this.EquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // ConditionReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 438);
            this.Controls.Add(this.reporter);
            this.Name = "ConditionReportForm";
            this.Text = "ConditionReportForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConditionReportForm_FormClosing);
            this.Load += new System.EventHandler(this.ConditionReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eqDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reporter;
        private System.Windows.Forms.BindingSource EquipmentBindingSource;
        private eqDataset eqDataset;
        private eqDatasetTableAdapters.EquipmentTableAdapter EquipmentTableAdapter;
    }
}