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

namespace DatabaseManagementOperationsLibrary
{
    /// <summary>
    /// This enables the system to manipulate or manage the databse. 
    /// </summary>
    public class DatabaseOperations
    {
        /// <summary>
        /// This is the connection string to be used for the system.
        /// </summary>
        public static SqlConnection connectionString = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "SystemDatabase.mdf" + "; Integrated Security=True;Connect Timeout=30");

        /// <summary>
        /// Creates the databse needed for the system.
        /// </summary>
        public static void CreateDatabase()
        {
            string filename = AppDomain.CurrentDomain.BaseDirectory + "SystemDatabase.mdf"; //Obtains the absolute path to the databse.
            string databaseName = Path.GetFileNameWithoutExtension(filename); //Derived database name.
            using (var connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog=master; Integrated Security=true;"))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText =
                        string.Format("CREATE DATABASE {0} ON PRIMARY (NAME={0}, FILENAME='{1}')", databaseName, filename);
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
        public static int checkForTableExistance(string tableName)
        {
            string checkExistance = @"IF EXISTS(SELECT*FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME=" + "'[" + tableName + "]') SELECT 1 ELSE SELECT 0";
            connectionString.Open();
            SqlCommand sqlCommand = new SqlCommand(checkExistance, connectionString);
            int check = Convert.ToInt32(sqlCommand.ExecuteScalar());
            connectionString.Close();
            return check;
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
        public static void CreateTable(string tableName, string attributeA, string dataTypeA, string attributeB, string datatypeB, 
            string attributeC, string dataTypeC)
        {
            int checkExistance = checkForTableExistance(tableName);

            if (checkExistance == 0)
            {
                string createTableCommand = "CREATE TABLE [" + tableName + "] ([" + attributeA + "]" + dataTypeA + "," + "[" + attributeB + "]" + datatypeB 
                    + "," + "[" + attributeC + "]" + dataTypeC +")";
                SqlCommand sqlCommand = new SqlCommand(createTableCommand, connectionString);
                connectionString.Open();
                sqlCommand.ExecuteNonQuery();
                connectionString.Close();
            }
            else
            {
                connectionString.Close();
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
        public static void CreateTable(string tableName, string attributeA, string dataTypeA, string attributeB, string dataTypeB , string attributeC, string dataTypeC, 
            string attributeD, string dataTypeD, string attributeE, string dataTypeE, string attributeF, string dataTypeF, string attributeG, string dataTypeG, string attributeH,
            string dataTypeH)
        {
            int checkExistance = checkForTableExistance(tableName);

            if (checkExistance == 0)
            {
                string createTableCommand = "CREATE TABLE [" + tableName + "] ([" + attributeA + "]" + dataTypeA + "," + "[" + attributeB + "]" + dataTypeB + "," + "[" + attributeC + "]" + dataTypeC + "," 
                    + "[" + attributeD + "]" + dataTypeD + "," + "[" + attributeE + "]" + dataTypeE +"," + "[" + attributeF + "]" + dataTypeF + ")";
                SqlCommand sqlCommand = new SqlCommand(createTableCommand, connectionString);
                connectionString.Open();
                sqlCommand.ExecuteNonQuery();
                connectionString.Close();
            }
            else
            {
                connectionString.Close();
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
        public static void InsertIntoTable(string tableName, string valueA, string valueB, string valueC, string valueD, string valueE, int valueF)
        {
            connectionString.Open();
            SqlCommand sqlCommand = connectionString.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "INSERT INTO [" + tableName + "]" + "values('" + valueA + "','" + valueB + "','" + valueC + "','" + valueD + "','" + valueE + "'," + valueF + ")";
            sqlCommand.ExecuteNonQuery();
            connectionString.Close();
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
        public static void InsertIntoTable(string tableName, string valueA, string valueB, string valueC, string valueD, string valueE, string valueF, string valueG, string valueH)
        {
            connectionString.Open();
            SqlCommand sqlCommand = connectionString.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "INSERT INTO [" + tableName + "]" + "values('" + valueA + "','" + valueB + "','" + valueC + "','" + valueD + "','" + valueE + "','" + valueF + "','" + valueG + "','" + valueH + "')";
            sqlCommand.ExecuteNonQuery();
            connectionString.Close();
        }

        public static void updateTable(string tableName)
        {
            //lol. Chill.
        }
        public static void updateTable(string tableName, string chill)
        {
            //Once again, chill.
        }
        public static void deleteFromTable(string tableName)
        {
            //Chill.
        }
        public static void deleteFromTable(string tableName, string chill)
        {
            //calm down.
        }






    }
}
