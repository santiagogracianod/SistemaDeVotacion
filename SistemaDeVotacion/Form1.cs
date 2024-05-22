using SistemaDeVotacion.dao;
using SistemaDeVotacion.model;
using System.Data.SqlClient;
using SistemaDeVotacion.servicios;


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
            Console.WriteLine("********************");

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
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona un candidato y un departamento.");
                return;
            }

            int candidatoID = (int)comboBox2.SelectedValue;

            int departamentoID = (int)comboBox1.SelectedValue;
   
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
            panelAdministrador.BringToFront(); 
            panelAdministrador.Visible = true;
        }

        private void buttonVotantes_Click(object sender, EventArgs e)
        {
            panelAdministrador.Visible = false;
            panelVotantes.BringToFront(); 
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

            Dictionary<string, int> votosOrdenados = OrdenamientoMezcla.votosPorDepartamento(votosPorDepartamentos);

            MergeSortForm mergeSortForm = new MergeSortForm(votosOrdenados);
            mergeSortForm.Show();
        }

        private void SimularVotos(int cantidadVotos)
        {
            CandidatoDao candidatoDao = new CandidatoDao();
            DepartamentoDao departamentoDao = new DepartamentoDao();

            int maxCandidatoID = candidatoDao.ObtenerMaximoID();
            int minCandidatoId = candidatoDao.ObtenerMinimoID();
            int maxDepartamentoId = departamentoDao.ObtenerMaximoID();
            int minDepartamentoId = departamentoDao.ObtenerMinimoID();

            Random random = new Random();

            if (db.OpenConnection())
            {
                try
                {
                    for (int i = 0; i < cantidadVotos; i++)
                    {
                        int candidatoID = random.Next(minCandidatoId, maxCandidatoID);
                        int departamentoID = random.Next(minDepartamentoId, maxDepartamentoId);
             
                        SqlCommand cmd = new SqlCommand("INSERT INTO votos (id_candidato, fecha) VALUES (@CandidatoID, GETDATE())", db.GetConnection());
                        cmd.Parameters.AddWithValue("@CandidatoID", candidatoID);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(cantidadVotos + " votos simulados registrados exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al simular y guardar votos: " + ex.Message);
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

        public static int MostrarInputBox(string prompt, string title)
        {
            Form promptForm = new Form();
            promptForm.Width = 300;
            promptForm.Height = 150;
            promptForm.Text = title;

            Label lblPrompt = new Label() { Left = 20, Top = 20, Text = prompt };
            TextBox txtInput = new TextBox() { Left = 20, Top = 50, Width = 200 };
            Button btnOk = new Button() { Text = "Aceptar", Left = 20, Width = 80, Top = 80 };
            Button btnCancel = new Button() { Text = "Cancelar", Left = 120, Width = 80, Top = 80 };

            btnOk.Click += (sender, e) => { promptForm.DialogResult = DialogResult.OK; };
            btnCancel.Click += (sender, e) => { promptForm.DialogResult = DialogResult.Cancel; };

            promptForm.Controls.Add(lblPrompt);
            promptForm.Controls.Add(txtInput);
            promptForm.Controls.Add(btnOk);
            promptForm.Controls.Add(btnCancel);

            if (promptForm.ShowDialog() == DialogResult.OK)
            {
                if (int.TryParse(txtInput.Text, out int result))
                {
                    return result;
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un número entero válido.");
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string prompt = "Ingrese votos:";
            string title = "Ingresar Cantidad de Votos";

            int cantidadVotos = MostrarInputBox(prompt, title);

            if (cantidadVotos > 0)
            {
                SimularVotos(cantidadVotos);
            }
            else if (cantidadVotos == 0)
            {
                MessageBox.Show("La cantidad de votos no puede ser cero.");
            }
            else
            {
                MessageBox.Show("Operación cancelada o cantidad de votos no válida.");
            }
        }

        private void btnVotosCandidato_Click(object sender, EventArgs e)
        {
            CandidatoDao candidatoDao = new CandidatoDao();
            List<Candidato> votosPorCandidatos = candidatoDao.votosPorCandidato();

            List<Candidato> votosOrdenados = OrdenemientoCountingSort.OrdenarPorVotos(votosPorCandidatos);


            DistribucionForm distribucion = new DistribucionForm(votosOrdenados);
            distribucion.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PartidoDao partidoDao = new PartidoDao();

            List<KeyValuePair<string, int>> votosPorPartido = partidoDao.votosPorPartido();
            OrdenamientoMezclaMultivía.OrdenarMultiVias(votosPorPartido); 

            OrdenamientoMultiviaForm distribucion = new OrdenamientoMultiviaForm(votosPorPartido); 
            distribucion.Show();
        }

        private void panelAdministrador_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
