﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaDeVotacion
{
    public partial class OrdenamientoMultiviaForm : Form
    {
        private List<KeyValuePair<string, int>> votosOrdenados;

        public OrdenamientoMultiviaForm(List<KeyValuePair<string, int>> votosOrdenados)
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

        private void OrdenamientoMultiviaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
