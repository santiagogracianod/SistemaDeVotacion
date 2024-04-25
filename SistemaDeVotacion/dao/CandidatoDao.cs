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
        public List<Candidato> buscarCandidatosPorDepartamento(String departamento) 
        { 
            DbConnection db = new DbConnection();
            List<Candidato> candidatos = new List<Candidato>();

            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT id, nombre, apellidos,id_partido FROM candidato WHERE id_departamento = @idDepartamento", db.GetConnection());
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
                        candidato.IdPartido = Convert.ToInt32(properties[3]);
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

        public bool agregarCandidato(Candidato candidato)
        {
            DbConnection db = new DbConnection();

            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO candidato (nombre, apellidos, edad, id_departamento, id_partido) VALUES (@Nombre, @Apellidos,@Edad, @IdDepartamento,@IdPartido)", db.GetConnection());
                    cmd.Parameters.AddWithValue("@Nombre", candidato.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", candidato.Apellido);
                    cmd.Parameters.AddWithValue("@Edad", candidato.Edad);
                    cmd.Parameters.AddWithValue("@IdDepartamento", candidato.IdDepartamento);
                    cmd.Parameters.AddWithValue("@IdPartido", candidato.IdPartido);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Verificar si se insertó correctamente
                    if (rowsAffected > 0)
                    {
                        return true; // La inserción fue exitosa
                    }
                    else
                    {
                        return false; // No se insertó ninguna fila (posiblemente debido a un error)
                    }
                }
                catch (Exception ex)
                {
                    // Error al ejecutar la consulta
                    MessageBox.Show("Error al agregar candidato: " + ex.Message);
                    return false;
                }
                finally
                {
                    db.CloseConnection();
                }
            }
            else
            {
                // Error al abrir la conexión
                MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                return false;
            }
        }

    }
}
