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
    public class ConditionalEquipmentBuilder:IEquipmentBuilder
    {
        SqlDataReader reader;
        SqlConnection sqlConnection;
        SqlCommand sqlComm;

        string connString, selectCommand,condition;
        Equipment equip;

        public Equipment Equip
        {
            get { return equip; }
        }

        public ConditionalEquipmentBuilder(string connString,string condition)
        {
            this.connString = connString;
            this.condition = condition;
            equip = Equipment.createEquipment();
        }

        public void identifyCondition()
        {
            using (sqlConnection = new SqlConnection(connString))
            {
                selectCommand = "SELECT * FROM Equipment WHERE Condition= @condition";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                sqlComm.Parameters.AddWithValue("@condition", condition);

                using (reader = sqlComm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equip.Condition = reader["Condition"].ToString();
                    }
                }
            }
        }

        public void identifyDepartment()
        {
            using (sqlConnection = new SqlConnection(connString))
            {
                selectCommand = "SELECT * FROM Equipment WHERE Condition= @condition";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                sqlComm.Parameters.AddWithValue("@condition", condition);

                using (reader = sqlComm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equip.DepartmentID = reader["Department"].ToString();
                    }
                }
            }
        }

        public void identifyManufacturer()
        {
            using (sqlConnection = new SqlConnection(connString))
            {
                selectCommand = "SELECT * FROM Equipment WHERE Condition= @condition";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                sqlComm.Parameters.AddWithValue("@condition", condition);

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
                selectCommand = "SELECT * FROM Equipment WHERE Condition= @condition";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                sqlComm.Parameters.AddWithValue("@condition", condition);

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
                selectCommand = "SELECT * FROM Equipment WHERE Condition= @condition";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                sqlComm.Parameters.AddWithValue("@condition", condition);

                using (reader = sqlComm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equip.Quantity = Convert.ToInt32(reader["Quantity"].ToString());
                    }
                }
            }
        }

        public void nameItem()
        {
            using (sqlConnection = new SqlConnection(connString))
            {
                selectCommand = "SELECT * FROM Equipment WHERE Condition= @condition";
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                sqlComm.Parameters.AddWithValue("@condition", condition);

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
