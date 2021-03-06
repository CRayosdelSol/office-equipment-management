﻿/*
 * LAST MODIFIED BY: CARL RAYOS DEL SOL 5/28/2017 3:04 PM
 */
using System;
using System.Data;
using System.Data.SqlClient; //Imports all needed SQL related syntax.
using System.IO; //Imports syntax related to file streaming.
using Microsoft.Win32.SafeHandles;

namespace DatabaseManagementOperationsLibrary
{
    /// <summary>
    /// This enables the system to manipulate or manage the databse. 
    /// </summary>
    public class DatabaseOperations : IDisposable
    {
        string strConn;
        public string fileName;

        public string StrConn
        {
            get { return strConn; }
            set { strConn = value; }
        }

        public DatabaseOperations(string connString)
        {
            StrConn = connString;
        }

        /// <summary>
        /// Creates a databese with the specified filename
        /// </summary>
        /// <param name="filename">Complete filename and path of the DB</param>
        public void CreateDatabase(string filename)
        {
            fileName = filename;
            string path = filename; //Obtains the absolute path to the databse.
            string databaseName = Path.GetFileNameWithoutExtension(path); //Derived  database name.
            using (var connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=master; Integrated Security=true;"))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText =
                        string.Format("CREATE DATABASE [{0}] ON PRIMARY (NAME=[{0}], FILENAME='{1}')", databaseName, path);
                    command.ExecuteNonQuery();

                    command.CommandText =
                        string.Format("EXEC sp_detach_db '{0}', 'true'", databaseName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void OpenDatabase(string filename)
        {
            fileName = filename;
            string path = filename; //Obtains the absolute path to the databse.
            string databaseName = Path.GetFileNameWithoutExtension(path); //Derived database name.
            using (var connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=master; Integrated Security=true;"))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText =
                        string.Format("CREATE DATABASE [{0}] ON PRIMARY (NAME=[{0}], FILENAME='{1}') FOR ATTACH", databaseName, path);
                    command.ExecuteNonQuery();

                    command.CommandText =
                        string.Format("EXEC sp_detach_db '{0}', 'true'", databaseName);
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Checks if the table already exists in the database.
        /// </summary>
        /// <param name="tableName">The name of the table or entity set to be created.</param>
        /// <returns>Returns 1 if the table already exists and 0 if not.</returns>
        public int checkForTableExistence(string tableName)
        {
            using (SqlConnection connectionString = new SqlConnection(StrConn))
            {
                string checkExistence = @"IF EXISTS(SELECT*FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME=" + "'[" + tableName + "]') SELECT 1 ELSE SELECT 0";
                connectionString.Open();
                SqlCommand sqlCommand = new SqlCommand(checkExistence, connectionString);
                int check = Convert.ToInt32(sqlCommand.ExecuteScalar());
                connectionString.Close();
                return check;
            }
        }

        /// <summary>
        /// Creates a table for the entity set. (Preffered for the creation of the manufacturers table.)
        /// </summary>
        /// <param name="tableName">The name of the table to be created.</param>
        /// <param name="attributeA">The FIRST attribute's name.</param>
        /// <param name="dataTypeA">The datatype of the FIRST attribute.</param>
        /// <param name="attributeB">The SECOND attribute's name.param>
        /// <param name="dataTypeB">The datatype of the SECOND attribute.</param>
        /// <param name="attributeC">The THIRD attribute's name.</param>
        /// <param name="dataTypeC">The datatype of the THIRD attribute.</param>
        public void CreateTable(string tableName, string attributeA, string dataTypeA, string attributeB, string datatypeB,
            string attributeC, string dataTypeC)
        {
            using (SqlConnection connectionString = new SqlConnection(StrConn))
            {
                int checkExistence = checkForTableExistence(tableName);

                if (checkExistence == 0)
                {
                    string createTableCommand = "CREATE TABLE [" + tableName + "] ([" + attributeA + "]" + dataTypeA + "," + "[" + attributeB + "]" + datatypeB
                        + "," + "[" + attributeC + "]" + dataTypeC + ")";
                    SqlCommand sqlCommand = new SqlCommand(createTableCommand, connectionString);
                    connectionString.Open();
                    sqlCommand.ExecuteNonQuery();
                    connectionString.Close();
                }
            }
        }

        public void CreateTable(string tableName, string attributeA, string dataTypeA, string attributeB, string dataTypeB)
        {
            using (SqlConnection connectionString = new SqlConnection(StrConn))
            {
                int checkExistence = checkForTableExistence(tableName);

                if (checkExistence == 0)
                {
                    string temp = string.Format(
                        "CREATE TABLE {0}(" +
                        "{1} {2}," +
                        "{3} {4});",
                        tableName, attributeA, dataTypeA, attributeB, dataTypeB);

                    string createTableCommand = temp;
                    SqlCommand sqlCommand = new SqlCommand(createTableCommand, connectionString);
                    connectionString.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }


        public void updateDeptTable(string tableName,string valA,string valB,string valC,string valD,string valE,string valF,string valG)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string command = "INSERT INTO " + tableName + "(Name,Condition,Quantity,Price,Department,Manufacturer,[Date of Purchase]) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
                SqlCommand sqlcomm = new SqlCommand(command, conn);
                SqlParameter[] pInsert = new SqlParameter[7];

                pInsert[0] = new SqlParameter("@p1",valA);
                pInsert[1] = new SqlParameter("@p2",valB);
                pInsert[2] = new SqlParameter("@p3",valC);
                pInsert[3] = new SqlParameter("@p4",valD);
                pInsert[4] = new SqlParameter("@p5",valE);
                pInsert[5] = new SqlParameter("@p6",valF);
                pInsert[6] = new SqlParameter("@p7",valG);

                sqlcomm.Parameters.AddRange(pInsert);

                sqlcomm.ExecuteNonQuery();
            }
        }


        public void CreateTable(string tableName, string attributeA, string dataTypeA, string attributeB, string dataTypeB, string attributeC, string dataTypeC, string attributeD, string dataTypeD, string attributeE, string dataTypeE, string attributeF, string dataTypeF, string attributeG, string dataTypeG)
        {
            using (SqlConnection connectionString = new SqlConnection(StrConn))
            {
                int checkExistence = checkForTableExistence(tableName);

                if (checkExistence == 0)
                {
                    string temp = string.Format(
                        "CREATE TABLE {0}(" +
                        "{1} {2}," +
                        "{3} {4}," +
                        "{5} {6}," +
                        "{7} {8}," +
                        "{9} {10}," +
                        "{11} {12}," +
                        "{13} {14});",
                        tableName, attributeA, dataTypeA, attributeB, dataTypeB, attributeC, dataTypeC, attributeD, dataTypeD, attributeE, dataTypeE, attributeF, dataTypeF, attributeG, dataTypeG);

                    string createTableCommand = temp;
                    SqlCommand sqlCommand = new SqlCommand(createTableCommand, connectionString);
                    connectionString.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Creates a table for the entity set. (Preffered for the creation of the equipment table.)
        /// </summary>
        /// <param name="tableName">The name of the table to be created.</param>
        /// <param name="attributeA">The FIRST attribute's name.</param>
        /// <param name="dataTypeA">The data type of the FIRST attribute.</param>
        /// <param name="attributeB">The SECOND attribute's name.</param>
        /// <param name="dataTypeB">The datatype of the SECOND attribute.</param>
        /// <param name="attributeC">The THIRD attribute's name./param>
        /// <param name="dataTypeC">The data type of the THIRD attribute.</param>
        /// <param name="attributeD">The FOURTH attribute's name.</param>
        /// <param name="dataTypeD">The FOURTH attribute's data type./param>
        /// <param name="attributeE">The FIFTH attribute's name.</param>
        /// <param name="dataTypeE">The FIFTH attribute's data type.</param>
        /// <param name="attributeF">The SIXTH attribute's name.</param>
        /// <param name="dataTypeF">The SIXTH attribute's data type.</param>
        /// <param name="attributeG">The SEVENTH attribute's name.</param>
        /// <param name="dataTypeG">The SEVENTH attribute's data type.</param>
        /// <param name="attributeH">The EIGTH attribute's name.</param>
        /// <param name="dataTypeH">The EIGTH attribute's data type.</param>
        public void CreateTable(string tableName, string attributeA, string dataTypeA, string attributeB, string dataTypeB, string attributeC, string dataTypeC, string attributeD, string dataTypeD, string attributeE, string dataTypeE, string attributeF, string dataTypeF, string attributeG, string dataTypeG, string attributeH, string dataTypeH)
        {
            using (SqlConnection connectionString = new SqlConnection(StrConn))
            {
                int checkExistence = checkForTableExistence(tableName);

                if (checkExistence == 0)
                {
                    string temp = string.Format(
                        "CREATE TABLE {0}(" +
                        "{1} {2}," +
                        "{3} {4}," +
                        "{5} {6}," +
                        "{7} {8}," +
                        "{9} {10}," +
                        "{11} {12}," +
                        "{13} {14}," +
                        "{15} {16});",
                        tableName, attributeA, dataTypeA, attributeB, dataTypeB, attributeC, dataTypeC, attributeD, dataTypeD, attributeE, dataTypeE, attributeF, dataTypeF, attributeG, dataTypeG, attributeH, dataTypeH);

                    string createTableCommand = temp;
                    SqlCommand sqlCommand = new SqlCommand(createTableCommand, connectionString);
                    connectionString.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEquipDataSet(DataSet ds)
        {
            SqlConnection conn = new SqlConnection(StrConn);

            string sInsert, sUpdate, sDelete;

            sInsert = "INSERT INTO Equipment (Name,Condition,Quantity,Price,Department,Manufacturer,Date_of_Purchase) values(@p2,@p3,@p4,@p5,@p6,@p7,@p8)";

            sUpdate = "UPDATE Equipment SET Name=@p2,Condition=@p3,Quantity=@p4,Price=@p5,Department=@p6,Manufacturer=@p7,Date_of_Purchase=@p8 where ID=@p1";

            sDelete = "DELETE FROM Equipment WHERE ID=@p1";

            SqlParameter[] pInsert = new SqlParameter[7];
            SqlParameter[] pUpdate = new SqlParameter[8];
            SqlParameter[] pDelete = new SqlParameter[1];

            pInsert[0] = new SqlParameter("@p2", SqlDbType.VarChar, 255, "Name");
            pInsert[1] = new SqlParameter("@p3", SqlDbType.VarChar, 20, "Condition");
            pInsert[2] = new SqlParameter("@p4", SqlDbType.Int, 1000, "Quantity");
            pInsert[3] = new SqlParameter("@p5", SqlDbType.Decimal, 10, "Price");
            pInsert[4] = new SqlParameter("@p6", SqlDbType.VarChar, 5, "Department");
            pInsert[5] = new SqlParameter("@p7", SqlDbType.VarChar, 255, "Manufacturer");
            pInsert[6] = new SqlParameter("@p8", SqlDbType.Date, 12, "Date_of_Purchase");

            pUpdate[0] = new SqlParameter("@p1", SqlDbType.Int, 1000, "ID");
            pUpdate[1] = new SqlParameter("@p2", SqlDbType.VarChar, 255, "Name");
            pUpdate[2] = new SqlParameter("@p3", SqlDbType.VarChar, 255, "Condition");
            pUpdate[3] = new SqlParameter("@p4", SqlDbType.Int, 1000, "Quantity");
            pUpdate[4] = new SqlParameter("@p5", SqlDbType.Decimal, 10, "Price");
            pUpdate[5] = new SqlParameter("@p6", SqlDbType.VarChar, 5, "Department");
            pUpdate[6] = new SqlParameter("@p7", SqlDbType.VarChar, 255, "Manufacturer");
            pUpdate[7] = new SqlParameter("@p8", SqlDbType.Date, 12, "Date_of_Purchase");

            pDelete[0] = new SqlParameter("@p1", SqlDbType.Int, 1000, "ID");

            var cmdInsert = new SqlCommand(sInsert, conn);
            var cmdUpdate = new SqlCommand(sUpdate, conn);
            var cmdDelete = new SqlCommand(sDelete, conn);

            cmdInsert.Parameters.AddRange(pInsert);
            cmdUpdate.Parameters.AddRange(pUpdate);
            cmdDelete.Parameters.AddRange(pDelete);

            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = cmdInsert;
            da.UpdateCommand = cmdUpdate;
            da.DeleteCommand = cmdDelete;
            da.Update(ds, "Equipment");
            ds.AcceptChanges();
        }

        public void UpdateDeptDataSet(DataTable dt, string tableName)
        {
            

            string sInsert;

            sInsert = "INSERT INTO " + tableName + "(Name,Condition,Quantity,Price,Department,Manufacturer,[Date of Purchase) values(@p2,@p3,@p4,@p5,@p6,@p7,@p8)";

            SqlParameter[] pInsert = new SqlParameter[7];

            
            var name = string.Empty;
            var condition = string.Empty;
            var quantity = 0;
            var price = 0.00m;
            var dept = string.Empty;
            var manuf = string.Empty;
            var dop = string.Empty;

            foreach(DataRow row in dt.Rows)
            {
                name = row["Name"].ToString();
                condition = row["Condition"].ToString();
                quantity = Convert.ToInt32(row["Quantity"].ToString());
                price = Convert.ToDecimal(row["Price"].ToString());
                manuf = row["Manufacturer"].ToString();
                dept = row["Department"].ToString();
                dop = row["Date of Purchase"].ToString();
            }


            pInsert[0] = new SqlParameter("@p2", name);
            pInsert[1] = new SqlParameter("@p3", condition);
            pInsert[2] = new SqlParameter("@p4", quantity);
            pInsert[3] = new SqlParameter("@p5", price);
            pInsert[4] = new SqlParameter("@p6", dept);
            pInsert[5] = new SqlParameter("@p7", manuf);
            pInsert[6] = new SqlParameter("@p8", dop);
          
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                var cmdInsert = new SqlCommand(sInsert, conn);
                cmdInsert.Parameters.AddRange(pInsert);
                cmdInsert.ExecuteNonQuery();
            }
        }

        public bool checkIfManufacturerIsInUse(string record)
        {
            using(SqlConnection sqlConn = new SqlConnection(strConn))
            {
                sqlConn.Open();
                string command = "SELECT COUNT(*) FROM Equipment WHERE Manufacturer LIKE '" + record + "'";
                SqlCommand sqlComm = new SqlCommand(command, sqlConn);
                int matches = int.Parse(sqlComm.ExecuteScalar().ToString());
                if(matches > 0)
                {
                    return true;
                }

                return false;
            }
        }


        public bool checkIfTableHasContent()
        {
            using(SqlConnection sqlConn = new SqlConnection(strConn))
            {
                sqlConn.Open();
                string command = "SELECT COUNT(*) FROM Manufacturer";
                SqlCommand sqlComm = new SqlCommand(command, sqlConn);
                int rowCount = int.Parse(sqlComm.ExecuteScalar().ToString());
                if(rowCount == 0)
                {
                    return false;
                }

                return true;

            }
        }

        public void updateManufacturerDataSet(DataSet ds)
        {
            SqlConnection conn = new SqlConnection(StrConn);

            string sInsert, sUpdate, sDelete;

            sInsert = "INSERT INTO Manufacturer (Name,Email_Address,Contact_Number,Country_of_Origin,City,Zip_Code) values(@p2,@p3,@p4,@p5,@p6,@p7)";

            sUpdate = "UPDATE Manufacturer SET Name=@p2,Email_Address=@p3,Contact_Number=@p4,Country_of_Origin=@p5,City=@p6,Zip_Code=@p7 WHERE ID=@p1";

            sDelete = "DELETE FROM Manufacturer WHERE ID=@p1";

            SqlParameter[] pInsert = new SqlParameter[6];
            SqlParameter[] pUpdate = new SqlParameter[7];
            SqlParameter[] pDelete = new SqlParameter[1];

            pInsert[0] = new SqlParameter("@p2", SqlDbType.VarChar, 255, "Name");
            pInsert[1] = new SqlParameter("@p3", SqlDbType.VarChar, 255, "Email_Address");
            pInsert[2] = new SqlParameter("@p4", SqlDbType.VarChar, 255, "Contact_Number");
            pInsert[3] = new SqlParameter("@p5", SqlDbType.VarChar, 255, "Country_of_Origin");
            pInsert[4] = new SqlParameter("@p6", SqlDbType.VarChar, 255, "City");
            pInsert[5] = new SqlParameter("@p7", SqlDbType.Int, 1000, "Zip_Code");

            pUpdate[0] = new SqlParameter("@p1", SqlDbType.Int, 1000, "ID");
            pUpdate[1] = new SqlParameter("@p2", SqlDbType.VarChar, 255, "Name");
            pUpdate[2] = new SqlParameter("@p3", SqlDbType.VarChar, 255, "Email_Address");
            pUpdate[3] = new SqlParameter("@p4", SqlDbType.VarChar, 255, "Contact_Number");
            pUpdate[4] = new SqlParameter("@p5", SqlDbType.VarChar, 255, "Country_of_Origin");
            pUpdate[5] = new SqlParameter("@p6", SqlDbType.VarChar, 255, "City");
            pUpdate[6] = new SqlParameter("@p7", SqlDbType.Int, 1000, "Zip_Code");

            pDelete[0] = new SqlParameter("@p1", SqlDbType.Int, 1000, "ID");

            var cmdInsert = new SqlCommand(sInsert, conn);
            var cmdUpdate = new SqlCommand(sUpdate, conn);
            var cmdDelete = new SqlCommand(sDelete, conn);

            cmdInsert.Parameters.AddRange(pInsert);
            cmdUpdate.Parameters.AddRange(pUpdate);
            cmdDelete.Parameters.AddRange(pDelete);

            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = cmdInsert;
            da.UpdateCommand = cmdUpdate;
            da.DeleteCommand = cmdDelete;
            da.Update(ds, "Manufacturer");
            ds.AcceptChanges();
        }

        public void DetachDB(string filename)
        {
            SqlConnection conn = new SqlConnection(StrConn);

            string path = filename; //Obtains the absolute path to the databse.
            string databaseName = Path.GetFileNameWithoutExtension(path); //Derived  database name.
            using (var connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=master; Integrated Security=true;"))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText =
                        string.Format("EXEC sp_detach_db '{0}', 'true'", databaseName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DropTable(string tableName)
        {
            using (SqlConnection connectionString = new SqlConnection(StrConn))
            {
                string temp = string.Format("DROP TABLE {0}", tableName);
                string createTableCommand = temp;
                SqlCommand sqlCommand = new SqlCommand(createTableCommand, connectionString);
                connectionString.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls      

        public virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    SqlConnection.ClearAllPools();
                }
                disposedValue = true;
            }
        }

        // ~DatabaseOperations() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
