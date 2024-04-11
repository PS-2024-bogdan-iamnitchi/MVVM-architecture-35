using System;
using System.Data;
using System.Data.SqlClient;

namespace MVVM_architecture_35.Model.Repository
{
    public class Repository
    {
        private SqlConnection connection;

        public Repository()
        {
            string connectionString = "Data Source=BOGDAN\\SQLEXPRESS;";
            connectionString += "Initial Catalog=PS_MVP_35;";
            connectionString += "Integrated Security=True;";
            this.connection = new SqlConnection(connectionString);
        }

        public Repository(string dataBaseName)
        {
            string connectionString = "Data Source=BOGDAN\\SQLEXPRESS;";
            connectionString += "Initial Catalog=" + dataBaseName + ";";
            connectionString += "Integrated Security=True;";
            this.connection = new SqlConnection(connectionString);
        }

        public SqlConnection Connection
        {
            get { return connection; }
            set { this.connection = value; }
        }

        public void OpenConnection()
        {
            if(this.connection.State != ConnectionState.Open)
            {
                this.connection.Open();
            }
        }

        public void CloseConnection()
        {
            if(this.connection.State != ConnectionState.Closed)
            {
                this.connection.Close();
            }
        }

        public bool CommandSQL(string commandInput)
        {
            bool result = true;
            try
            {
                this.OpenConnection();
                SqlCommand command = new SqlCommand(commandInput, this.connection);
                if(command.ExecuteNonQuery() == 0)
                {
                    result = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;
            }
            finally
            {
                this.CloseConnection();
            }
            return result;
        }

        public DataTable GetTable(string commandInput)
        {
            DataTable result = new DataTable();
            try
            {
                this.OpenConnection();
                SqlCommand command = new SqlCommand(commandInput, this.connection);
                SqlDataAdapter readData = new SqlDataAdapter(command);
                readData.Fill(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = null;
            }
            finally
            {
                this.CloseConnection();
            }
            return result;
        }
    }
}