namespace OfficeEquipMgmtApp
{
    partial class FRM_Manufacturer
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
            this.dataGrid_Manuf = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Manuf)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_Manuf
            // 
            this.dataGrid_Manuf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Manuf.Location = new System.Drawing.Point(42, 28);
            this.dataGrid_Manuf.Name = "dataGrid_Manuf";
            this.dataGrid_Manuf.Size = new System.Drawing.Size(550, 163);
            this.dataGrid_Manuf.TabIndex = 0;
            this.dataGrid_Manuf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortItemsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortItemsToolStripMenuItem
            // 
            this.sortItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.countryToolStripMenuItem});
            this.sortItemsToolStripMenuItem.Name = "sortItemsToolStripMenuItem";
            this.sortItemsToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.sortItemsToolStripMenuItem.Text = "Sort Items";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nameToolStripMenuItem.Text = "Name";
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ascendingToolStripMenuItem.Text = "Ascending";
            this.ascendingToolStripMenuItem.Click += new System.EventHandler(this.ascendingToolStripMenuItem_Click);
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.descendingToolStripMenuItem.Text = "Descending";
            this.descendingToolStripMenuItem.Click += new System.EventHandler(this.descendingToolStripMenuItem_Click);
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem1,
            this.descendingToolStripMenuItem1});
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.countryToolStripMenuItem.Text = "Country";
            // 
            // ascendingToolStripMenuItem1
            // 
            this.ascendingToolStripMenuItem1.Name = "ascendingToolStripMenuItem1";
            this.ascendingToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ascendingToolStripMenuItem1.Text = "Ascending";
            this.ascendingToolStripMenuItem1.Click += new System.EventHandler(this.ascendingToolStripMenuItem1_Click);
            // 
            // descendingToolStripMenuItem1
            // 
            this.descendingToolStripMenuItem1.Name = "descendingToolStripMenuItem1";
            this.descendingToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.descendingToolStripMenuItem1.Text = "Descending";
            this.descendingToolStripMenuItem1.Click += new System.EventHandler(this.descendingToolStripMenuItem1_Click);
            // 
            // FRM_Manufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid_Manuf);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_Manufacturer";
            this.Text = "Manufacturer";
            this.Load += new System.EventHandler(this.FRM_Manufacturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Manuf)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Manuf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem1;
    }
}