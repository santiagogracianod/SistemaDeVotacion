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
    internal class CandidatoDao
    {
        public List<Candidato> buscarCandidatosPorDepartamento(String departamento) { 
            DbConnection db = new DbConnection();
            List<Candidato> candidatos = new List<Candidato>();

            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT id, nombre, apellidos FROM candidato WHERE id_departamento = @idDepartamento", db.GetConnection());
                    cmd.Parameters.AddWithValue("idDepartamento", departamento);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach(DataRow row in dt.Rows) {
                        Object[] properties = row.ItemArray;
                        Candidato candidato = new Candidato();
                        candidato.Id = Convert.ToInt32(properties[0]);
                        candidato.Nombre = properties[1].ToString();
                        candidato.Apellido = properties[2].ToString();
                        candidatos.Add(candidato);

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
            else
            {
                //error en la conexion
                // MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
            }
            return candidatos;
        }


    }
}
