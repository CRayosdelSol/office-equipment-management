namespace OfficeEquipMgmtApp
{
    partial class FRM_AddDepartment
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddDept = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Name (Max of 5 Characters):";
            // 
            // btn_AddDept
            // 
            this.btn_AddDept.Location = new System.Drawing.Point(204, 67);
            this.btn_AddDept.Name = "btn_AddDept";
            this.btn_AddDept.Size = new System.Drawing.Size(182, 34);
            this.btn_AddDept.TabIndex = 1;
            this.btn_AddDept.Text = "ADD";
            this.btn_AddDept.UseVisualStyleBackColor = true;
            this.btn_AddDept.Click += new System.EventHandler(this.btn_AddDept_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 26);
            this.textBox1.TabIndex = 2;
            // 
            // FRM_AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 107);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_AddDept);
            this.Controls.Add(this.label1);
            this.Name = "FRM_AddDepartment";
            this.Text = "Add New Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddDept;
        private System.Windows.Forms.TextBox textBox1;
    }
}