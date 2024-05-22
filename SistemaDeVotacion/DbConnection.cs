using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaDeVotacion
{
    internal class DbConnection
    {
        private SqlConnection connection;
        private string connectionString;
        public string ErrorMessage { get; private set; }

        public DbConnection()
        {
            // Aquí puedes establecer tu cadena de conexión
            connectionString = "Data Source=JUAN;Initial Catalog=sistema_votacion; Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

    }
}
