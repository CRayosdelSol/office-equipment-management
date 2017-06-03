/*
 * LAST MODIFIED BY: CARL RAYOS DEL SOL 5/28/2017 3:04 PM
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; //Imports all needed SQL related syntax.
using System.IO; //Imports syntax related to file streaming.
using System.Text.RegularExpressions;
using Microsoft.Win32.SafeHandles;

namespace DatabaseManagementOperationsLibrary
{
    /// <summary>
    /// This enables the system to manipulate or manage the databse. 
    /// </summary>
    public class DatabaseOperations : IDisposable
    {
        bool disposed = false;
        SafeFileHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        /// <summary>
        /// Creates a databese
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="savepath"></param>
        public void CreateDatabase(string filename)
        {
            string path = filename; //Obtains the absolute path to the databse.
            string databaseName = Path.GetFileNameWithoutExtension(path); //Derived database name.
            using (var connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=master; Integrated Security=true;"))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText =
                        string.Format("CREATE DATABASE {0} ON PRIMARY (NAME={0}, FILENAME='{1}')", databaseName, path);
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
        public int checkForTableExistence(string tableName, string connString)
        {
            using (SqlConnection connectionString = new SqlConnection(connString))
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
        public void CreateTable(string tableName, string connString, string attributeA, string dataTypeA, string attributeB, string datatypeB,
            string attributeC, string dataTypeC)
        {
            using (SqlConnection connectionString = new SqlConnection(connString))
            {
                int checkExistence = checkForTableExistence(tableName, connString);

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
        public void CreateTable(string tableName, string connString, string attributeA, string dataTypeA, string attributeB, string dataTypeB, string attributeC, string dataTypeC, string attributeD, string dataTypeD, string attributeE, string dataTypeE, string attributeF, string dataTypeF, string attributeG, string dataTypeG, string attributeH, string dataTypeH, string attributeI, string dataTypeI)
        {
            using (SqlConnection connectionString = new SqlConnection(connString))
            {
                int checkExistence = checkForTableExistence(tableName, connString);

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
                        "{15} {16}," +
                        "{17} {18}," +
                        "PRIMARY KEY ({1}) );",
                        tableName, attributeA, dataTypeA, attributeB, dataTypeB, attributeC, dataTypeC, attributeD, dataTypeD, attributeE, dataTypeE, attributeF, dataTypeF, attributeG, dataTypeG, attributeH, dataTypeH, attributeI, dataTypeI);

                    string createTableCommand = temp;
                    SqlCommand sqlCommand = new SqlCommand(createTableCommand, connectionString);
                    connectionString.Open();
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Insert new values to the table. This is preffered for the Manufacturer entity set.
        /// </summary>
        /// <param name="tableName">The name of the table where the values are to be added or inserted into.</param>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <param name="valueC"></param>
        /// <param name="valueD"></param>
        /// <param name="valueE"></param>
        /// <param name="valueF"></param>
        public void InsertIntoTable(string tableName, string connString, string valueA, string valueB, string valueC, string valueD, string valueE, int valueF)
        {
            using (SqlConnection connectionString = new SqlConnection(connString))
            {
                connectionString.Open();
                SqlCommand sqlCommand = connectionString.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "INSERT INTO [" + tableName + "]" + "values('" + valueA + "','" + valueB + "','" + valueC + "','" + valueD + "','" + valueE + "'," + valueF + ")";
                sqlCommand.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Insert new values into the table. This is preffered for the equipment entity set.
        /// </summary>
        /// <param name="tableName">The name of the table where the values are to be added or inserted into.</param>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <param name="valueC"></param>
        /// <param name="valueD"></param>
        /// <param name="valueE"></param>
        /// <param name="valueF"></param>
        /// <param name="valueG"></param>
        /// <param name="valueH"></param>
        public void InsertIntoTable(string tableName, string connString, string valueA, string valueB, string valueC, string valueD, string valueE, string valueF, string valueG, string valueH)
        {

            using (SqlConnection connectionString = new SqlConnection(connString))
            {
                connectionString.Open();
                SqlCommand sqlCommand = connectionString.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "INSERT INTO [" + tableName + "]" + "values('" + valueA + "','" + valueB + "','" + valueC + "','" + valueD + "','" + valueE + "','" + valueF + "','" + valueG + "','" + valueH + "')";
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void updateTable(string tableName)
        {
            //lol. Chill.
        }
        public void updateTable(string tableName, string chill)
        {
            //Once again, chill.
        }

        /// <summary>
        /// Delete the selected entity occurence (row) from the database. 
        /// </summary>
        /// <param name="tableName">The name of the table.</param>
        /// <param name="itemToBeDeleted">The entity occurence to be deleted from the databse.</param>
        public void deleteFromTable(string tableName, string connString, string itemToBeDeleted)
        {
            using (SqlConnection connectionString = new SqlConnection(connString))
            {
                connectionString.Open();
                SqlCommand sqlCommand = connectionString.CreateCommand();
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = "DELETE FROM [" + tableName + "] where [Serial Number]='" + itemToBeDeleted + "'";
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
                    GC.SuppressFinalize(this);
                    SqlConnection.ClearAllPools();
                }
                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~DatabaseOperations() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
