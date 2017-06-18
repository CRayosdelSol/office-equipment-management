using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DatabaseManagementOperationsLibrary;

namespace EquipmentLibrary
{
    public class DepartmentEquipmentBuilder : IEquipmentBuilder
    {

        SqlDataReader reader;
        SqlConnection sqlConnection;
        SqlCommand sqlComm;
        string connString, selectCommand, deptName, manufName;
        Equipment equipment;


        public DepartmentEquipmentBuilder(string connectionString, string manufName, string deptName)
        {
            connString = connectionString;
            equipment = Equipment.createEquipment();
            this.manufName = manufName;
            this.deptName = deptName;
        }

        public Equipment Equipment
        {
            get { return equipment; }
        }

        public void identifyCondition()
        {
            using (sqlConnection = new SqlConnection(connString))
            {
                selectCommand = "SELECT * FROM Equipment WHERE Department= @DepartmentName";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                using (reader = sqlComm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equipment.Condition = reader["Condition"].ToString();
                    }
                }
            }
        }

        public void identifyManufacturer()
        {
            IManufacturerBuilder manufacturerBuilder = new EquipmentManufacturerBuilder(connString, manufName);
            equipment.Manufacturer.Name = manufacturerBuilder.Manufacturer.Name;
        }

        public void identifyPrice()
        {
            using (sqlConnection = new SqlConnection(connString))
            {
                selectCommand = "SELECT * FROM Equipment WHERE Department= @DepartmentName";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                using (reader = sqlComm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equipment.Price = Convert.ToDecimal(reader["Price"].ToString());
                    }
                }
            }
        }

        public void identifyQuantity()
        {
            using (sqlConnection = new SqlConnection(connString))
            {
                selectCommand = "SELECT * FROM Equipment WHERE Department= @DepartmentName";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                using (reader = sqlComm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equipment.Quantity = Convert.ToInt32(reader["Quantity"].ToString());
                    }
                }
            }
        }

        public void nameItem()
        {
            using (sqlConnection = new SqlConnection(connString))
            {
                selectCommand = "SELECT * FROM Equipment WHERE Department= @DepartmentName";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                using (reader = sqlComm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equipment.Name = reader["Name"].ToString();
                    }
                }
            }
        }
    }
}
