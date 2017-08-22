/*
 * PLEASE MAKE A BACKUP BEFORE COMMITING!
 * Programmers:
 *  Alvarez, Arvin Kenneth
 *  Aguas, Nathaniael Johnn
 *  Lim, Jasmin Rose
 *  Pelipas, Mary Tricia Ann
 *  Rayos del Sol, Carl Ivan

 * Purpose: To serve as an inventory sysetm for a speecific company.
 * Data started: Arvin knows. I forgot lol.
 * Submission Date: I don't know. Sorry.
 
 * LAST MODIFIED BY: AKCALVAREZ 19:23
 * Please change this when you modify ANYTHING so we know who touched this thing last. :)
 * P.S. MSVS Shows you who last edited a method/class since it reads github related files AFAIK
 */
using System;
using System.Windows.Forms;
using System.IO;
using Report_Form;

namespace OfficeEquipMgmtApp
{
    public partial class Main : Form
    {
        // this keeps track of how many times the "New" menu item has been pressed 
        public int fileCounter = 0;
        string openFileName;

        public Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Timer tmr = new Timer();
            tmr.Interval = 1000; // ticks every 1 second
            tmr.Tick += new EventHandler(updateTime);
            tmr.Start();

            // delete trash files in case the program crashed on it's previous launch
            try
            {
                string user = Environment.UserName; // Get whatever the current computer's username is
                string dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\managementapp\";
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\managementapp";
                string[] filepaths = Directory.GetFiles(dir);

                foreach (string f in filepaths)
                {
                    if (File.Exists(f))
                        File.Delete(f);
                }

                if (Directory.Exists(folder))
                {
                    Directory.Delete(folder);
                }
            }
            catch (Exception)
            { }
        }

        private void updateTime(object sender, EventArgs e)
        {
            striplbl.Text = DateTime.Now.ToString("MM /dd/yyyy hh:mm tt");
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "SQL Server Database Files|*.mdf";
            open.Title = "Open Inventory File";

            if (open.ShowDialog() == DialogResult.OK) // if the user pressed OK on the form then read the file
            {
                FRM_EquipmentEditing frm = new FRM_EquipmentEditing(open.FileName);
                frm.MdiParent = this;
                frm.Show();
                openFileName = open.FileName;
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileCounter++;
            FRM_EquipmentEditing frm = new FRM_EquipmentEditing();
            frm.MdiParent = this;
            frm.Show();
            openFileName = frm.Filepath;
        }

        /// <summary>
        /// Deletes all temp files generated during runtime
        /// </summary>s
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                string user = Environment.UserName;
                string dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\managementapp\";
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\managementapp";
                string[] filepaths = Directory.GetFiles(dir);

                foreach (string f in filepaths)
                {
                    if (File.Exists(f))
                        File.Delete(f);
                }

                if (Directory.Exists(folder))
                {
                    Directory.Delete(folder);
                }
            }
            catch (Exception)
            { }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            var closing = MessageBox.Show("Do you want quit and discard all changes, if there are any?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (closing == DialogResult.Yes)
            {
                return;
            }
            else
                e.Cancel = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // get active MDI Form and determine if it is an EquipmentView Form
                if (ActiveMdiChild.GetType() == typeof(FRM_EquipmentEditing))
                {
                    // get the active mdi child and determine if it is an equipment form
                    FRM_EquipmentEditing tempForm = (FRM_EquipmentEditing)ActiveMdiChild;

                    if (tempForm.PageEquip.getResultCount() == 0)
                    {
                        MessageBox.Show("Database table has no entries!", "Saving Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    SaveFileDialog save = new SaveFileDialog();
                    save.Filter = "SQL Server Database Files|*.mdf";
                    save.Title = "Save Inventory File";
                    save.FileName = "Equipment_Record";

                    DialogResult result = save.ShowDialog();

                    if (result == DialogResult.OK && tempForm.IsNewDB == true)
                    {
                        try
                        {
                            if (File.Exists(save.FileName)) // overwrite the existing file
                            {
                                File.Delete(save.FileName);
                                string str = Path.GetFileNameWithoutExtension(save.FileName);
                                str += "_log.ldf";
                                string str2 = Path.GetDirectoryName(save.FileName);
                                File.Delete(str2 + @"\\" + str); // delete the ldf file
                            }
                            tempForm.Db.Dispose(true);
                            File.Move(tempForm.Db.fileName, save.FileName);

                            tempForm.IsNewDB = false;
                            tempForm.Filepath = save.FileName; // load the saved Database and bind it to the DGV

                            tempForm.initalizeDataGrid(tempForm.getDGV());
                            tempForm.PageEquip.ReCount();
                            tempForm.PageEquip.loadPage();
                            tempForm.PageMnf.ReCount();
                            tempForm.PageMnf.loadPage();
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message);
                        }
                    }
                    else if (result == DialogResult.OK && tempForm.IsNewDB == false)
                    {
                        try
                        {
                            if (File.Exists(save.FileName)) // overwrite if the file is exisiting
                            {
                                File.Delete(save.FileName);
                                string str = Path.GetFileNameWithoutExtension(save.FileName);
                                str += "_log.ldf";
                                string str2 = Path.GetDirectoryName(save.FileName);
                                File.Delete(str2 + @"\\" + str); // delete the ldf file
                            }
                            File.Copy(tempForm.Db.fileName, save.FileName); // copy DB to the new DIR
                            tempForm.Db.Dispose(true);

                            tempForm.IsNewDB = false;
                            tempForm.Filepath = save.FileName; // load the saved Database and bind it to the DGV
                            tempForm.initalizeDataGrid(tempForm.getDGV());
                            tempForm.PageEquip.ReCount();
                            tempForm.PageEquip.loadPage();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Failed to Save file, are you trying to overwrite a locked DB?", "Saving Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception)
            { }
        }

        internal void btnSaveAs_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem_Click(sender, e);
        }

        private void viewTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_TableViewer tableViewer_frm = new FRM_TableViewer(openFileName);
            tableViewer_frm.MdiParent = this;
            tableViewer_frm.Show();
        }

        private void byOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild.GetType() == typeof(FRM_EquipmentEditing))
            {
                // get the active mdi child and determine if it is an equipment form
                FRM_EquipmentEditing tempForm = (FRM_EquipmentEditing)ActiveMdiChild;


            }
        }

        private void byConditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConditionReportForm frm = new ConditionReportForm();
            frm.Show();
        }
    }
}
