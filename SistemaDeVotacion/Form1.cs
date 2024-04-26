using SistemaDeVotacion.dao;
using SistemaDeVotacion.model;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SistemaDeVotacion.servicios;
using System.Text;

namespace SistemaDeVotacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cargarDepartamentos();
        }

        Panel p = new Panel();
        DbConnection db = new DbConnection();

        private void Form1_Load(object sender, EventArgs e)
        {
            panelAdministrador.Visible = false;
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

        public void cargarDepartamentos()
        {
            DepartamentoDao departamentoDao = new DepartamentoDao();
            List<Departamento> departamentos = departamentoDao.buscarDepartamentos();

            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "nombre";
            comboBox1.DataSource = departamentos;

        }

        public void cargarCandidatos(string idDepartamento)
        {
            CandidatoDao candidatoDao = new CandidatoDao();

            List<Candidato> candidatos = candidatoDao.buscarCandidatosPorDepartamento(idDepartamento);

            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "NombreCompletoYPartido";
            comboBox2.DataSource = candidatos;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string idDepartamento = comboBox1.SelectedValue.ToString();
                cargarCandidatos(idDepartamento);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Verificar si se han seleccionado candidato y departamento
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona un candidato y un departamento.");
                return;
            }

            // Obtener el ID del departamento seleccionado en el ComboBox
            int candidatoID = (int)comboBox1.SelectedValue;

            // Obtener el ID del cantidado seleccionado en el ComboBox
            int departamentoID = (int)comboBox2.SelectedValue;

            // Guardar el voto en la base de datos
            if (db.OpenConnection())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO votos (id_candidato, fecha) VALUES (@CandidatoID, GETDATE())", db.GetConnection());
                    cmd.Parameters.AddWithValue("@CandidatoID", candidatoID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Voto registrado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el voto: " + ex.Message);
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

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            // panelVotantes.SendToBack(); // Asegura que panelVotantes esté detrás de panelAdministrador
            panelAdministrador.BringToFront(); // Asegura que panelAdministrador esté en la parte superior
            //panelVotantes.Visible = false;
            panelAdministrador.Visible = true;


        }

        private void buttonVotantes_Click(object sender, EventArgs e)
        {
            panelAdministrador.Visible = false;
            panelVotantes.BringToFront(); // Asegura que panelVotantes esté en la parte superior
            panelVotantes.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FomularioCandidato formularioCandidato = new FomularioCandidato();
            formularioCandidato.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepartamentoDao departamentoDao = new DepartamentoDao();
            Dictionary<string, int> votosPorDepartamentos = departamentoDao.votosPorDepartamento();

            Dictionary<string,int> votosOrdenados =            OrdenamientoMezcla.votosPorDepartamento(votosPorDepartamentos);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Votos por Departamento (Ordenados de Mayor a Menor):");
            foreach (var kvp in votosOrdenados)
            {
                sb.AppendLine($"{kvp.Key}: {kvp.Value}");
            }

            // Mostrar la cadena en un MessageBox
            MessageBox.Show(sb.ToString(), "Votos Ordenados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }
    }
}
