using System;
using System.Windows.Forms;
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
        }

        private void updateTime(object sender, EventArgs e)
        {
            striplbl.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //File_Browser browser = new File_Browser();
            //browser.ShowDialog();

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XML Files|*.xml|Database Files|*.db";           
            open.Title = "Open Inventory File";

            if (open.ShowDialog() == DialogResult.OK) // if the user pressed OK on the form then read the file
            {
                this.Cursor = new Cursor(open.OpenFile());
            }
          
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML Files|*.xml|Database Files|*.db";

            if (save.ShowDialog() == DialogResult.OK)
            {
                this.Cursor = new Cursor(save.OpenFile());
            }
        }
    }
}
