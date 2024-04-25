namespace SistemaDeVotacion
{
    partial class FomularioCandidato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAceptar = new Button();
            buttonCancelar = new Button();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            comboBoxPartido = new ComboBox();
            comboBoxDepartamento = new ComboBox();
            textBoxEdad = new TextBox();
            SuspendLayout();
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(50, 243);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(120, 39);
            buttonAceptar.TabIndex = 0;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(322, 243);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(120, 39);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Microsoft Sans Serif", 9.75F);
            textBoxNombre.Location = new Point(50, 55);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(150, 22);
            textBoxNombre.TabIndex = 2;
            textBoxNombre.Text = "Nombre";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Font = new Font("Microsoft Sans Serif", 9.75F);
            textBoxApellido.Location = new Point(50, 112);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(150, 22);
            textBoxApellido.TabIndex = 3;
            textBoxApellido.Text = "Apellido";
            // 
            // comboBoxPartido
            // 
            comboBoxPartido.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxPartido.FormattingEnabled = true;
            comboBoxPartido.Location = new Point(264, 169);
            comboBoxPartido.Name = "comboBoxPartido";
            comboBoxPartido.Size = new Size(200, 24);
            comboBoxPartido.TabIndex = 4;
            comboBoxPartido.Text = "Partido";
            // 
            // comboBoxDepartamento
            // 
            comboBoxDepartamento.Font = new Font("Microsoft Sans Serif", 9.75F);
            comboBoxDepartamento.FormattingEnabled = true;
            comboBoxDepartamento.Location = new Point(264, 64);
            comboBoxDepartamento.Name = "comboBoxDepartamento";
            comboBoxDepartamento.Size = new Size(200, 24);
            comboBoxDepartamento.TabIndex = 5;
            comboBoxDepartamento.Text = "Departamento";
            // 
            // textBoxEdad
            // 
            textBoxEdad.Font = new Font("Microsoft Sans Serif", 9.75F);
            textBoxEdad.Location = new Point(50, 170);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(150, 22);
            textBoxEdad.TabIndex = 6;
            textBoxEdad.Text = "Edad";
            // 
            // FomularioCandidato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(476, 305);
            Controls.Add(textBoxEdad);
            Controls.Add(comboBoxDepartamento);
            Controls.Add(comboBoxPartido);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAceptar);
            Name = "FomularioCandidato";
            Text = "FomularioCandidato";
            Load += FomularioCandidato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAceptar;
        private Button buttonCancelar;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private ComboBox comboBoxPartido;
        private ComboBox comboBoxDepartamento;
        private TextBox textBoxEdad;
    }
}