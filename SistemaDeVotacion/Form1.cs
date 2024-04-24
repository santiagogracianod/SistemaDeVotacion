using SistemaDeVotacion.dao;
using SistemaDeVotacion.model;
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

            comboBox2.DataSource = candidatos;
            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "nombre";

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
