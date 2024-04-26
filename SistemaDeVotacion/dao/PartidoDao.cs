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
    }
}
