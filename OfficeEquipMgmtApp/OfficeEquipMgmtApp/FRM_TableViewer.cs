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

        Department department;

        string file;
        protected string connString;
        bool isEquipmentTable;

        public FRM_TableViewer()
        {
            InitializeComponent();
        }

        public FRM_TableViewer(string filepath)
        {
            InitializeComponent();
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

        public void summarizeEquipmentPerDepartment()
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

            foreach (DataGridViewRow row in dtgrd_Tables.Rows)
            {
                IEquipmentBuilder equipmentBuilder = new ConditionalEquipmentBuilder(connString,row.Cells[2].Value.ToString());
                buildConditionSpecificEquipment(equipmentBuilder);
                if (equipmentBuilder.Equip.Condition == "Good")
                {
                    good++;
                }
                else if (equipmentBuilder.Equip.Condition == "Under Repair")
                {
                    underRepair++;
                }
                else if (equipmentBuilder.Equip.Condition == "Needs Replacement")
                {
                    needsReplacement++;
                }
                else
                {
                    lost++;
                }

            }

            lbl_GenGoodCondition.Text = good.ToString();
            lbl_GenLostCondition.Text = lost.ToString();
            lbl_GenNeedsReplacementCondition.Text = needsReplacement.ToString();
            lbl_GenUnderRepairCondition.Text = underRepair.ToString();
        }

        public void DisplayDepartmentEquipmentConditionSummary()
        {
            int good = 0, underRepair = 0, needsReplacement = 0, lost = 0;

            foreach (DataGridViewRow row in dtgrd_Tables.Rows)
            {
                if (row.Cells[5].Value.ToString() == dtgrd_Tables.SelectedRows[0].Cells[5].Value.ToString())
                {
                    IEquipmentBuilder equipmentBuilder = new DepartmentEquipmentBuilder(connString, dtgrd_Tables.SelectedRows[0].Cells[5].Value.ToString());
                    buildDepartmentSpecificEquipment(equipmentBuilder);
                    if (equipmentBuilder.Equip.Condition == "Good")
                    {
                        good++;
                    }
                    else if (equipmentBuilder.Equip.Condition == "Under Repair")
                    {
                        underRepair++;
                    }
                    else if (equipmentBuilder.Equip.Condition == "Needs Replacement")
                    {
                        needsReplacement++;
                    }
                    else
                    {
                        lost++;
                    }
                }
            }

            grpbx_summaryPerDept.Text = dtgrd_Tables.SelectedRows[0].Cells[5].Value.ToString();
            lbl_GoodCondition.Text = good.ToString();
            lbl_UnderRepairCondition.Text = underRepair.ToString();
            lbl_LostCondition.Text = lost.ToString();
            lbl_needsReplacement.Text = needsReplacement.ToString();
        }

        public void buildDepartmentSpecificEquipment(IEquipmentBuilder equipmentBuilder)
        {
            equipmentBuilder.identifyCondition();
            equipmentBuilder.identifyManufacturer();
            equipmentBuilder.identifyPrice();
            equipmentBuilder.nameItem();
            equipmentBuilder.identifyQuantity();
        }

        public void buildConditionSpecificEquipment(IEquipmentBuilder equipmentBuilder)
        {
            equipmentBuilder.identifyCondition();
            equipmentBuilder.identifyManufacturer();
            equipmentBuilder.identifyPrice();
            equipmentBuilder.nameItem();
            equipmentBuilder.identifyQuantity();
            equipmentBuilder.identifyDepartment();
        }

        public void establishManufacturingCompany(IManufacturerBuilder manufacturerBuilder)
        {
            manufacturerBuilder.establishUserCommunicationMethods();
            manufacturerBuilder.identifyAddress();
        }

        public void displayManufacturerInformation()
        {
            IManufacturerBuilder manufacturerBuilder = new EquipmentManufacturerBuilder(connString, dtgrd_Tables.SelectedRows[0].Cells[6].Value.ToString());
            establishManufacturingCompany(manufacturerBuilder);

            lbl_ManufName.Text = manufacturerBuilder.Manufacturer.Name;
            lbl_Manufemail.Text = manufacturerBuilder.Manufacturer.Email_add;
            lbl_CountryOfOrigin.Text = manufacturerBuilder.Manufacturer.MnfctrrAdd.Country;
            lbl_ManufContactNumber.Text = manufacturerBuilder.Manufacturer.Contact_number;
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
            summarizeEquipmentPerDepartment();
        }

        private void FRM_TableViewer_Load(object sender, EventArgs e)
        {
            initializeGrid(dtgrd_Tables);
            displayTable("Equipment", connString, dtgrd_Tables);
            DisplayEquipmentCondtionSummary();
        }
    }
}
