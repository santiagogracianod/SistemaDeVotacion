using SistemaDeVotacion.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVotacion
{
    public partial class DistribucionForm : Form
    {
        private List<Candidato> candidatosOrdenados; // Cambiar el tipo de datos a List<Candidato>
        private List<KeyValuePair<string, int>> votosPorPartido;

        public DistribucionForm(List<Candidato> candidatosOrdenados) // Modificar el constructor
        {
            InitializeComponent();
            this.candidatosOrdenados = candidatosOrdenados;
            MostrarVotosOrdenados();
        }

        public DistribucionForm(List<KeyValuePair<string, int>> votosPorPartido)
        {
            this.votosPorPartido = votosPorPartido;
        }

        private void DistribucionForm_Load(object sender, EventArgs e)
        {

        }
        private void MostrarVotosOrdenados()
        {
            // Opción 1: Usando LINQ para seleccionar propiedades específicas
            var dataForGrid = candidatosOrdenados.Select(c => new { Nombre = c.Nombre, Apellido = c.Apellido, VotosTotales = c.Votos });
            dataGridView1.DataSource = dataForGrid.ToList(); // Convertir a Lista para enlace

            // Asignar los votos ordenados al DataSource del DataGridView
            //  dataGridView1.DataSource = candidatosOrdenados; // No es necesario crear un nuevo BindingSource
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
