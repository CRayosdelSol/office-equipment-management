/*
 * PLEASE MAKE A BACKUP BEFORE COMMITING!
 * Programmers:
 *  Alavarez, Arvin Kenneth
 *  Aguas, Nathaniael Johnn
 *  Lim, Jasmin Rose
 *  Pelipas, Mary Tricia Ann
 *  Rayos del Sol, Carl Ivan

 * Purpose: To serve as an inventory sysetm for a speecific company.
 * Data started: Arvin knows. I forgot lol.
 * Submission Date: I don't know. Sorry.
 
 * LAST MODIFIED BY: CARL RAYOS DEL SOL 5/28/2017 3:04 PM
 * Please change this when you modify ANYTHING so we know who touched this thing last. :)
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
            
            //check if the database exists, if it does, fuck off. Otherwise, create it.
            if (!File.Exists("SystemDatabase.mdf"))
            {
                DatabaseOperations.CreateDatabase();
            }
        }

        private void updateTime(object sender, EventArgs e)
        {
            striplbl.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
        }
    }
}
