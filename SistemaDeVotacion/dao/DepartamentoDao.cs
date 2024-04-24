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
    internal class DepartamentoDao
    {
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
            else
            {
                //error en la conexion
                //MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
            }
            return departamentos;
        }
    }
}
