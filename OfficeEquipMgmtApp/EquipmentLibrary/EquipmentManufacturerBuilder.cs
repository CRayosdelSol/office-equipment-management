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
    public class EquipmentManufacturerBuilder : IManufacturerBuilder
    {
        Manufacturer manufacturer;
        SqlDataReader reader;
        SqlConnection sqlConnection;
        SqlCommand sqlComm;
        string connString, selectCommand, manufName;

        public SqlConnection SqlConnection
        {
            get { return sqlConnection; }
            set { sqlConnection = value; }
        }

        public Manufacturer Manufacturer
        {
            get { return manufacturer; }
        }

        public EquipmentManufacturerBuilder(string connectionString, string manufName)
        {
            Address address = new Address();
            connString = connectionString;
            this.manufName = manufName;
            manufacturer = Manufacturer.CreateManufacturer(manufName, address);
        }

        public void establishUserCommunicationMethods()
        {
            selectCommand = "SELECT * FROM Manufacturer WHERE Name= @name";
            using (sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                sqlComm = new SqlCommand(selectCommand, SqlConnection);
                sqlComm.Parameters.AddWithValue("@name", manufName);
                reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    manufacturer.Contact_number = reader["Contact_Number"].ToString();
                    manufacturer.Email_add = reader["Email_Address"].ToString();
                }
            }
        }

        public void identifyAddress()
        {
            selectCommand = "SELECT * FROM Manufacturer WHERE Name= @name";
            using (sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                sqlComm = new SqlCommand(selectCommand, sqlConnection);
                sqlComm.Parameters.AddWithValue("@name", manufName);
                reader = sqlComm.ExecuteReader();
                while (reader.Read())
                {
                    manufacturer.MnfctrrAdd.City = reader["City"].ToString();
                    manufacturer.MnfctrrAdd.Country = reader["Country_of_Origin"].ToString();
                    manufacturer.MnfctrrAdd.Zipcode = Convert.ToInt32(reader["Zip_Code"].ToString());
                }
            }
        }
    }
}
