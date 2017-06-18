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
        string connString, selectCommand, deptName;
        Equipment equip;


        public DepartmentEquipmentBuilder(string connectionString,string deptName)
        {
            connString = connectionString;
            equip = Equipment.createEquipment();
            this.deptName = deptName;
        }

        public Equipment Equip
        {
            get { return equip; }
        }

        public void identifyCondition()
        {
            using (sqlConnection = new SqlConnection(connString))
            {
                selectCommand = "SELECT * FROM Equipment WHERE Condition= @departmentName";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                sqlComm.Parameters.AddWithValue("@departmentName", deptName);
                using (reader = sqlComm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equip.Condition = reader["Condition"].ToString();
                    }
                }
            }
        }

        public void identifyManufacturer()
        {
            using (sqlConnection = new SqlConnection(connString))
            {
                selectCommand = "SELECT * FROM Equipment WHERE Condition= @departmentName";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                sqlComm.Parameters.AddWithValue("@departmentName", deptName);
                using (reader = sqlComm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equip.Manufacturer.Name = reader["Manufacturer"].ToString();
                    }
                }
            }
        }

        public void identifyPrice()
        {
            using (sqlConnection = new SqlConnection(connString))
            {
                selectCommand = "SELECT * FROM Equipment WHERE Condition= @departmentName";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                sqlComm.Parameters.AddWithValue("@departmentName", deptName);
                using (reader = sqlComm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equip.Price = Convert.ToDecimal(reader["Price"].ToString());
                    }
                }
            }
        }

        public void identifyQuantity()
        {
            using (sqlConnection = new SqlConnection(connString))
            {
                selectCommand = "SELECT * FROM Equipment WHERE Condition= @departmentName";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                sqlComm.Parameters.AddWithValue("@departmentName", deptName);
                using (reader = sqlComm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equip.Quantity = Convert.ToInt32(reader["Quantity"].ToString());
                    }
                }
            }
        }

        public void identifyDepartment()
        {
            //This is not to be implemented here.
        }

        public void nameItem()
        {
            using (sqlConnection = new SqlConnection(connString))
            {
                selectCommand = "SELECT * FROM Equipment WHERE Condition= @departmentName";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                sqlComm.Parameters.AddWithValue("@departmentName", deptName);
                using (reader = sqlComm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equip.Name = reader["Name"].ToString();
                    }
                }
            }
        }
    }
}
