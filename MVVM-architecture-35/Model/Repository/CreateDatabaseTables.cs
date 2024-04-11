using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_architecture_35.Model.Repository
{
    public class CreateDatabaseTables
    {
        private string databaseName;

        public CreateDatabaseTables(string databaseName)
        {
            this.databaseName = databaseName;
        }

        public void CreateDataBase()
        {
            string connectionString = "Server=BOGDAN\\SQLEXPRESS;";
            connectionString += "Integrated Security=True;database=master";
            SqlConnection connection = new SqlConnection(connectionString);
            string str = "CREATE DATABASE " + databaseName + " ON PRIMARY " +
             "(NAME =  " + databaseName + "_Data, " +
             "FILENAME = 'D:\\Surse\\SSMS\\" + databaseName + ".mdf', " +
             "SIZE = 5MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
             "LOG ON (NAME = " + databaseName + "_Log, " +
             "FILENAME = 'D:\\Surse\\SSMS\\" + databaseName + ".ldf', " +
             "SIZE = 1MB, MAXSIZE = 5MB, FILEGROWTH = 10%)";

            SqlCommand commandSQL = new SqlCommand(str, connection);
            try
            {
                connection.Open();
                commandSQL.ExecuteNonQuery();
                Debug.WriteLine("Database created successfully!");
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

        public bool CreateTablePlayer()
        {
            Repository repository = new Repository(this.databaseName);
            string commandInput = "CREATE TABLE Player (ID INT CONSTRAINT PkeyId PRIMARY KEY IDENTITY(1,1),";
            commandInput += "isAdmin VARCHAR(5),FullName VARCHAR(50),Email VARCHAR(50) UNIQUE,Age INT,Password VARCHAR(50),Score INT);";
            bool result = true;
            try
            {
                repository.OpenConnection();
                SqlCommand command = new SqlCommand(commandInput, repository.Connection);
                if (command.ExecuteNonQuery() == 0)
                    result = false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                result = false;
            }
            finally
            {
                repository.CloseConnection();
            }
            return result;
        }
    }
}
