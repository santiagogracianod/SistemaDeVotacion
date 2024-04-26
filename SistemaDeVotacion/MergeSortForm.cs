

namespace SistemaDeVotacion
{
    public partial class MergeSortForm : Form
    {
        private Dictionary<string, int> votosOrdenados;

        public MergeSortForm(Dictionary<string, int> votosOrdenados)
        {
            InitializeComponent();
            this.votosOrdenados = votosOrdenados;

            // Llamar al método para configurar y mostrar los datos en el DataGridView
            MostrarVotosOrdenados();
        }

        private void MostrarVotosOrdenados()
        {
            // Asignar los votos ordenados al DataSource del DataGridView
            dataGridView1.DataSource = new BindingSource(votosOrdenados, null);
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}