using SistemaDeVotacion.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaDeVotacion.dao
{
    public class CandidatoDao
    {
        private DbConnection db;

        public CandidatoDao()
        {
            db = new DbConnection();
        }

        public int ObtenerMaximoID()
        {
            int maxID = 0;

            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT MAX(id) FROM candidato", db.GetConnection());
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maxID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el máximo ID de candidato: " + ex.Message);
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
                    SqlCommand cmd = new SqlCommand("SELECT MIN(id) FROM candidato", db.GetConnection());
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        minId= Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el minimo ID de candidato: " + ex.Message);
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


        // Otros métodos del CandidatoDao

        public List<Candidato> buscarCandidatosPorDepartamento(string departamento)
        {
            List<Candidato> candidatos = new List<Candidato>();

            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT c.id, c.nombre, c.apellidos, c.id_departamento, c.id_partido, p.nombre FROM candidato c JOIN partido p ON p.id = c.id_partido WHERE c.id_departamento = @idDepartamento", db.GetConnection());
                    cmd.Parameters.AddWithValue("idDepartamento", departamento);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        Object[] properties = row.ItemArray;
                        Candidato candidato = new Candidato();
                        candidato.Id = Convert.ToInt32(properties[0]);
                        candidato.Nombre = properties[1].ToString();
                        candidato.Apellido = properties[2].ToString();

                        Partido partido = new Partido();
                        partido.Id = Convert.ToInt32(properties[4]);
                        partido.Nombre = properties[5].ToString();
                        candidato.Partido = partido;

                        candidatos.Add(candidato);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos de candidatos: " + ex.Message);
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
            return candidatos;
        }

        public bool agregarCandidato(Candidato candidato)
        {
            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO candidato (nombre, apellidos, edad, id_departamento, id_partido) VALUES (@Nombre, @Apellidos, @Edad, @IdDepartamento, @IdPartido)", db.GetConnection());
                    cmd.Parameters.AddWithValue("@Nombre", candidato.Nombre);
                    cmd.Parameters.AddWithValue("@Apellidos", candidato.Apellido);
                    cmd.Parameters.AddWithValue("@Edad", candidato.Edad);
                    cmd.Parameters.AddWithValue("@IdDepartamento", candidato.IdDepartamento);
                    cmd.Parameters.AddWithValue("@IdPartido", candidato.Partido.Id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Verificar si se insertó correctamente
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
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
                MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
                return false;
            }
        }

        public List<Candidato> votosPorCandidato()
        {
            DbConnection db = new DbConnection();
            List<Candidato> candidatos = new List<Candidato>();

            if (db.OpenConnection())
            {
                try
                {
                    string sql = "SELECT c.id, c.nombre, c.apellidos as apellido, COUNT(v.id) AS 'Votos' " +
                            "FROM candidato c LEFT JOIN votos v ON c.id = v.id_candidato " +
                            "GROUP BY c.id, c.nombre,c.apellidos";
                    SqlCommand cmd = new SqlCommand(sql, db.GetConnection());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Iterar sobre cada fila de la tabla y agregar un objeto Candidato a la lista
                    foreach (DataRow row in dt.Rows)
                    {
                        Candidato candidato = new Candidato
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Nombre = Convert.ToString(row["nombre"]),
                            Apellido = Convert.ToString(row["apellido"]),
                            Votos = Convert.ToInt32(row["Votos"])
                        };
                        candidatos.Add(candidato);
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

            return candidatos;
        }

    }
}
