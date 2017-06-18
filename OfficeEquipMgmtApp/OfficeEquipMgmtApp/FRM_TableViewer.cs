using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DatabaseManagementOperationsLibrary;
using EquipmentLibrary;

namespace OfficeEquipMgmtApp
{

    public partial class FRM_TableViewer : Form
    {
        Main mainForm;

        // Database variables
        SqlDataAdapter dataAdapter;
        DataSet ds;
        DatabaseOperations db;

        Manufacturer manufacturer;
        Address address;
        Equipment equipment;
        Department department;

        string dir;
        string file;
        protected string connString;
        bool isEquipmentTable;

        public FRM_TableViewer()
        {
            InitializeComponent();
        }

        public FRM_TableViewer(string filepath, string dir)
        {
            InitializeComponent();
            this.dir = dir;
            file = filepath;
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayTable("Equipment", connString, dtgrd_Tables);
            sttts_TableDisplayed.Text = "\"Equipment\"";
            isEquipmentTable = true;
            grpbx_GeneralEquipmentSummary.Visible = true;
            grpbx_summaryPerDept.Visible = true;
            grpbx_ManufacturerInfo.Visible = true;
        }

        private void manufacturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayTable("Manufacturer", connString, dtgrd_Tables);
            sttts_TableDisplayed.Text = "\"Manufacturer\"";
            isEquipmentTable = false;
            grpbx_GeneralEquipmentSummary.Visible = false;
            grpbx_summaryPerDept.Visible = false;
            grpbx_ManufacturerInfo.Visible = false;

        }

        public void initializeGrid(DataGridView grid)
        {
            mainForm = ((Main)MdiParent);


            // DB Connection Setup
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + file + "; Integrated Security=True;Connect Timeout=30";
            db = new DatabaseOperations(connString);

            displayTable("Equipment", connString, dtgrd_Tables);
        }

        public void displayTable(string tableName, string connString, DataGridView grid)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string selectCommand =  string.Format("SELECT * FROM {0}",tableName);

                try // database binding happens here
                {
                    dataAdapter = new SqlDataAdapter(selectCommand, connString);
                    ds = new DataSet();
                    dataAdapter.Fill(ds, tableName);
                    grid.DataMember = tableName;
                    grid.DataSource = ds;
                }

                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }

            scaleDatagrid(dtgrd_Tables);
        }
        public void scaleDatagrid(DataGridView grid)
        {
            //Scale the datagridview so that all of its contents are properly shown to the user.
            grid.Width = grid.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width) +
            (grid.RowHeadersVisible ? dtgrd_Tables.RowHeadersWidth : 0) + 3;
        }

        public void summarizeEquipmentConditions()
        {
            List<string> DepartmentList = new List<string>();

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM @table",sqlConnection);
                sqlCommand.Parameters.AddWithValue("@table", "departments");
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        department = new Department(dataReader["Name"].ToString());
                        DepartmentList.Add(department.DepartmentID);
                    }
                }

                foreach(string departmentName in DepartmentList)
                {
                    db.CreateTable(departmentName, "ID", "int IDENTITY(1,1) not null PRIMARY KEY", "Name", "varchar(255)", "Condition", "varchar(255)", "Quantity", "int", "Price", "decimal(19,2)", "Department", "varchar(255)", "Manufacturer", "varchar(255)", "[Date of Purchase]", "date");
                    string selectCommand = "SELECT * FROM Equipment WHERE Department= " + departmentName;
                    sqlCommand = new SqlCommand(selectCommand, sqlConnection);
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    ds = new DataSet();
                    da.Fill(ds, departmentName);
                }
            }
        }

        public void DisplayEquipmentCondtionSummary()
        {
            int good = 0, underRepair = 0, needsReplacement = 0, lost = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM @table", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@table", "Equipment");
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        department = new Department();
                        manufacturer = new Manufacturer(dataReader["Manufacturer"].ToString());
                        equipment = new Equipment(manufacturer, Convert.ToInt32(dataReader["Quantity"]), department.DepartmentID, Convert.ToDecimal(dataReader["Price"]), dataReader["Name"].ToString(), Convert.ToInt32(dataReader["ID"]), dataReader["Condition"].ToString());
                    }

                    if (equipment.Condition == "Good")
                    {
                        good++;
                    }
                    else if (equipment.Condition == "Under Repair")
                    {
                        underRepair++;
                    }
                    else if (equipment.Condition == "Needs Replacement")
                    {
                        needsReplacement++;
                    }
                    else
                    {
                        lost++;
                    }
                }
            }

            lbl_GenGoodCondition.Text = good.ToString();
            lbl_GenLostCondition.Text = lost.ToString();
            lbl_GenNeedsReplacementCondition.Text = needsReplacement.ToString();
            lbl_GenUnderRepairCondition.Text = underRepair.ToString();

        }

        public void DisplayDepartmentEquipmentConditionSummary()
        {
            List<string> DepartmentList = new List<string>();
            int good=0, underRepair=0, needsReplacement=0, lost=0;
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM @table", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@table", "departments");
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        department = new Department(dataReader["Name"].ToString());
                        DepartmentList.Add(department.DepartmentID);
                    }
                }

                foreach (string departmentName in DepartmentList)
                {
                    sqlCommand = new SqlCommand("SELECT * FROM @table", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@table", "equipment");
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            if (departmentName == dtgrd_Tables.SelectedRows[0].Cells[5].Value.ToString())
                            {
                                department = new Department(departmentName);
                                manufacturer = new Manufacturer(dataReader["Manufacturer"].ToString());
                                equipment = new Equipment(manufacturer, Convert.ToInt32(dataReader["Quantity"]), departmentName, Convert.ToDecimal(dataReader["Price"]), dataReader["Name"].ToString(), Convert.ToInt32(dataReader["ID"]), dataReader["Condition"].ToString());

                                if (equipment.Condition == "Good")
                                {
                                    good++;
                                }
                                else if (equipment.Condition == "Under Repair")
                                {
                                    underRepair++;
                                }
                                else if (equipment.Condition == "Needs Replacement")
                                {
                                    needsReplacement++;
                                }
                                else
                                {
                                    lost++;
                                }
                            }
                        }
                    }
                }
            }

            grpbx_summaryPerDept.Text = department.DepartmentID;
            lbl_GoodCondition.Text = good.ToString();
            lbl_UnderRepairCondition.Text = underRepair.ToString();
            lbl_LostCondition.Text = lost.ToString();
            lbl_needsReplacement.Text = needsReplacement.ToString();
        }

        public void establishManufacturingCompany(IManufacturerBuilder manufacturerBuilder)
        {
            manufacturerBuilder.establishUserCommunicationMethods();
            manufacturerBuilder.identifyAddress();
        }

        public void displayManufacturerInformation()
        {
            IManufacturerBuilder manufacturerBuilder = null;
            manufacturerBuilder = new EquipmentManufacturerBuilder(connString, dtgrd_Tables.SelectedRows[0].Cells[6].Value.ToString());

            lbl_ManufName.Text = manufacturerBuilder.Manufacturer.Name;
            lbl_Manufemail.Text = manufacturerBuilder.Manufacturer.Email_add;
            lbl_CountryOfOrigin.Text = manufacturerBuilder.Manufacturer.MnfctrrAdd.Country;
        }

        private void dtgrd_Tables_SelectionChanged(object sender, EventArgs e)
        {
            if (isEquipmentTable)
            {
                DisplayDepartmentEquipmentConditionSummary();
                displayManufacturerInformation();
            }
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            summarizeEquipmentConditions();
        }

        private void FRM_TableViewer_Load(object sender, EventArgs e)
        {
            initializeGrid(dtgrd_Tables);
            displayTable("Equipment", connString, dtgrd_Tables);
            DisplayEquipmentCondtionSummary();
        }
    }
}
