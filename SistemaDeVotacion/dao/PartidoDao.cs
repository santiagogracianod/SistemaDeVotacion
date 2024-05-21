using SistemaDeVotacion.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVotacion.dao
{
    internal class PartidoDao
    {

        public List<Partido> buscarPartido()
        {
            DbConnection db = new DbConnection();
            List<Partido> partidos = new List<Partido>();
            
            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT id, nombre FROM partido", db.GetConnection());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        Object[] properties = row.ItemArray;
                        Partido partido = new Partido();
                        partido.Id = Convert.ToInt32(properties[0]);
                        partido.Nombre = properties[1].ToString();

                        partidos.Add(partido);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
                finally
                {
                    db.CloseConnection();
                }

            }
           
            return partidos;
        }

        public List<KeyValuePair<string, int>> votosPorPartido()
        {
            DbConnection db = new DbConnection();
            List<KeyValuePair<string, int>> votosPorPartido = new List<KeyValuePair<string, int>>();

            if (db.OpenConnection())
            {
                try
                {
                    string query = "SELECT p.nombre, COUNT(v.id) AS votos " +
                                   "FROM partido p " +
                                   "LEFT JOIN candidato c ON p.id = c.id_partido " +
                                   "LEFT JOIN votos v ON c.id = v.id_candidato " +
                                   "GROUP BY p.nombre";

                    SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string nombrePartido = Convert.ToString(reader["nombre"]);
                        int votos = Convert.ToInt32(reader["votos"]);
                        votosPorPartido.Add(new KeyValuePair<string, int>(nombrePartido, votos));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los votos por partido: " + ex.Message);
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

            return votosPorPartido;
        }


    }
}
