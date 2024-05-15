using SistemaDeVotacion.model;
using System.Data.SqlClient;
using System.Data;


namespace SistemaDeVotacion.dao
{
    

    internal class DepartamentoDao
    {
        private DbConnection db;

        public DepartamentoDao()
        {
            db = new DbConnection();
        }

        public List<Departamento> buscarDepartamentos() {
            DbConnection db = new DbConnection();
            List<Departamento> departamentos = new List<Departamento>();

            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT id, nombre FROM departamento", db.GetConnection());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows) 
                    {
                        Object[] properties = row.ItemArray;
                        Departamento departamento = new Departamento();
                        departamento.Id = Convert.ToInt32(properties[0]);
                        departamento.Nombre = properties[1].ToString();

                        departamentos.Add(departamento);
                    }
                }
                catch (Exception ex)
                {
                    //error al cargar datos
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }

            }
         
            return departamentos;
        }

        public int ObtenerMaximoID()
        {
            int maxID = 0;

            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT MAX(id) FROM departamento", db.GetConnection());
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maxID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el máximo ID de departamento: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
            }

            return maxID;
        }

        public int ObtenerMinimoID()
        {
            int minId = 0;

            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT MIN(id) FROM departamento", db.GetConnection());
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        minId = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el minimo ID de departamento: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
            }

            return minId;
        }

        public Dictionary<string, int> votosPorDepartamento() {
            DbConnection db = new DbConnection();
            Dictionary<string, int> votosPorDepartamento = new Dictionary<string, int>();

            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT d.nombre,count(d.id) AS 'votos' from candidato c JOIN votos v ON c.id= v.id_candidato JOIN departamento d ON c.id_departamento = d.id GROUP By d.nombre", db.GetConnection());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        Object[] properties = row.ItemArray;
                        votosPorDepartamento.Add(properties[0].ToString(), Convert.ToInt32(properties[1]));
                    }
                }
                catch (Exception ex)
                {
                    //error al cargar datos
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }

            }

            return votosPorDepartamento;

        }
    }
}
