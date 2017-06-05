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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EquipmentLibrary;
using DatabaseManagementOperationsLibrary;

namespace OfficeEquipMgmtApp
{
    public partial class Main : Form
    {
        // this keeps track of how many times the "New" menu item has been pressed 
        public int fileCounter = 0;

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
                //string dir = @"C:\Users\" + user + @"\Desktop\.managementapp\";
                //string folder = @"C:\Users\" + user + @"\Desktop\.managementapp";
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
            {

            }
        }

        private void updateTime(object sender, EventArgs e)
        {
            striplbl.Text = DateTime.Now.ToString("MM /dd/yyyy hh:mm tt");
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File_Browser browser = new File_Browser();
            //browser.ShowDialog();

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "SQL Server Database Files|*.mdf";
            open.Title = "Open Inventory File";

            if (open.ShowDialog() == DialogResult.OK) // if the user pressed OK on the form then read the file
            {
                this.Cursor = new Cursor(open.OpenFile());
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "SQL Server Database Files|*.mdf";
            save.Title = "Save Inventory File";
            save.FileName = "Equipment_Record";

            DatabaseOperations db = new DatabaseOperations();

            if (save.ShowDialog() == DialogResult.OK)
            {
                db.CreateDatabase(save.FileName);
            }
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileCounter++;
            frm_EquipmentView frm = new frm_EquipmentView();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                string user = Environment.UserName; // Get whatever the current computer's username is
                //string dir = @"C:\Users\" + user + @"\Desktop\.managementapp\";
                //string folder = @"C:\Users\" + user + @"\Desktop\.managementapp";
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
            {

            }
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        //private void toolHover(object sender, EventArgs e)
        //{
        //    ((Button)sender).Text
        //}
    }
}
