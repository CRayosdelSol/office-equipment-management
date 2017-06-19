using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseManagementOperationsLibrary;
using System.Data.SqlClient;

namespace OfficeEquipMgmtApp
{
    public partial class FRM_AddDepartment : Form
    {
        // Database variables
        DatabaseOperations db;
        DataSet ds;

        string connstring;

        public FRM_AddDepartment(string connstring, DataSet ds)
        {
            InitializeComponent();
            this.connstring = connstring;
            this.ds = ds;
        }


        private void btn_AddDept_Click(object sender, EventArgs e)
        {
            db = new DatabaseOperations(connstring);
            db.fillDeptDataset(ds);
            db.UpdateDeptDataSet(ds);
        }
    }
}
