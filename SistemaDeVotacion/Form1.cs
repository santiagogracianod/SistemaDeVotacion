using System.Data;
using System.Data.SqlClient;

namespace SistemaDeVotacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargarDatos();
        }

        Panel p = new Panel();
        DbConnection db = new DbConnection();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pMenu.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(140, 5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            pMenu.Controls.Remove(p);
        }

        public void cargarDatos()
        {

            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT id, nombre FROM departamento", db.GetConnection());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow dr = dt.NewRow();
                    dr["nombre"] = "Selecciona un departamento";
                    dt.Rows.InsertAt(dr, 0);

                    comboBox1.ValueMember = "id";
                    comboBox1.DisplayMember = "nombre";
                    comboBox1.DataSource = dt;

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
                MessageBox.Show("No se pudo abrir la conexión a la base de datos.");
            }


        }

        public void cargarCandidatos(string idDepartamento)
        {
            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT id, nombre, apellidos FROM candidato WHERE id_departamento = @idDepartamento", db.GetConnection());
                    cmd.Parameters.AddWithValue("idDepartamento", idDepartamento);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow dr = dt.NewRow();
                    dr["nombre"] = "Selecciona un candidato";
                    dt.Rows.InsertAt(dr, 0);

                    comboBox2.ValueMember = "id";
                    comboBox2.DisplayMember = "nombre";
                    comboBox2.DataSource = dt;

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

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue.ToString != null) 
            {
                string idDepartamento = comboBox1.SelectedValue.ToString();
                cargarCandidatos(idDepartamento);


            }
        }
    }
}
