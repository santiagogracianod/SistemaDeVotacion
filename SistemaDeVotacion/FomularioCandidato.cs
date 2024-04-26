﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeVotacion.dao;
using SistemaDeVotacion.model;

namespace SistemaDeVotacion
{
    public partial class FomularioCandidato : Form
    {
        private CandidatoDao candidatoDao;

        public FomularioCandidato()
        {
            InitializeComponent();
            cargarDepartamentos();
            cargarPartido();
            candidatoDao = new CandidatoDao();
        }

        // Método para cargar los departamentos en el ComboBox
        public void cargarDepartamentos()
        {
            DepartamentoDao departamentoDao = new DepartamentoDao();
            List<Departamento> departamentos = departamentoDao.buscarDepartamentos();

            comboBoxDepartamento.ValueMember = "id";
            comboBoxDepartamento.DisplayMember = "nombre";
            comboBoxDepartamento.DataSource = departamentos;
        }

        // Método para cargar los partidos en el ComboBox
        public void cargarPartido()
        {
            PartidoDao partidoDao = new PartidoDao();
            List<Partido> partidos = partidoDao.buscarPartido();

            comboBoxPartido.ValueMember = "id";
            comboBoxPartido.DisplayMember = "nombre";
            comboBoxPartido.DataSource = partidos;
        }

        // Evento Click del botón Aceptar para agregar un nuevo candidato
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            // Crea un nuevo objeto Candidato con los datos ingresados
            Partido partido = new Partido();
            partido.Id = (int)comboBoxPartido.SelectedValue;
            Candidato nuevoCandidato = new Candidato
            {
                Nombre = textBoxNombre.Text,
                Apellido = textBoxApellido.Text,
                Edad = int.Parse(textBoxEdad.Text),
                IdDepartamento = (int)comboBoxDepartamento.SelectedValue,
                Partido = partido
            };

            // Llama al método agregarCandidato del CandidatoDao
            bool resultado = candidatoDao.agregarCandidato(nuevoCandidato);

            // Verifica el resultado de la operación y muestra un mensaje
            if (resultado)
            {
                MessageBox.Show("Candidato agregado correctamente.");
                // Aquí puedes realizar acciones adicionales después de agregar el candidato, si es necesario
            }
            else
            {
                MessageBox.Show("Error al agregar candidato.");
                // Aquí puedes manejar el caso en que no se pueda agregar el candidato
            }
        }

        // Evento Click del botón Cancelar para cerrar el formulario
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento Load del formulario para guardar el texto original de cada TextBox
        private void FomularioCandidato_Load(object sender, EventArgs e)
        {
            GuardarTextoOriginal(this);
        }

        // Método para guardar el texto original de cada TextBox
        private void GuardarTextoOriginal(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    c.Tag = c.Text; // Guarda el texto original en la propiedad Tag
                    c.Enter += LimpiarTexto; // Asigna el evento Enter para limpiar el texto
                    c.Leave += RestaurarTextoOriginal; // Asigna el evento Leave para restaurar el texto original
                }
                else if (c.Controls.Count > 0)
                {
                    GuardarTextoOriginal(c); // Llama recursivamente al método para los controles dentro de controles, como Paneles
                }
            }
        }

        // Evento Enter para limpiar el texto del TextBox cuando se hace clic en él
        private void LimpiarTexto(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                textBox.Text = ""; // Borra el texto cuando se hace clic en el TextBox
            }
        }

        // Evento Leave para restaurar el texto original si no se ha ingresado nuevo texto
        private void RestaurarTextoOriginal(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string textoOriginal = textBox.Tag.ToString(); // Obtiene el texto original almacenado en Tag
                if (string.IsNullOrWhiteSpace(textBox.Text)) // Verifica si no se ha ingresado nuevo texto
                {
                    textBox.Text = textoOriginal; // Restaura el texto original
                }
            }
        }
    }
}
