namespace SistemaDeVotacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pMenu = new Panel();
            buttonAdmin = new Button();
            button1 = new Button();
            buttonVotantes = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panelVotantes = new Panel();
            panelAdministrador = new Panel();
            buttonAgregarCandidato = new Button();
            button8 = new Button();
            button2 = new Button();
            btnVotosCandidato = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button4 = new Button();
            pMenu.SuspendLayout();
            panelVotantes.SuspendLayout();
            panelAdministrador.SuspendLayout();
            SuspendLayout();
            // 
            // pMenu
            // 
            pMenu.BackColor = Color.FromArgb(51, 62, 80);
            pMenu.Controls.Add(buttonAdmin);
            pMenu.Controls.Add(button1);
            pMenu.Controls.Add(buttonVotantes);
            pMenu.Dock = DockStyle.Top;
            pMenu.Location = new Point(0, 0);
            pMenu.Margin = new Padding(3, 4, 3, 4);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(562, 60);
            pMenu.TabIndex = 1;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Cursor = Cursors.Hand;
            buttonAdmin.FlatAppearance.BorderSize = 0;
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdmin.ForeColor = Color.White;
            buttonAdmin.Location = new Point(289, 0);
            buttonAdmin.Margin = new Padding(3, 4, 3, 4);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(160, 53);
            buttonAdmin.TabIndex = 2;
            buttonAdmin.Text = "Administrador";
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += buttonAdmin_Click;
            buttonAdmin.MouseEnter += btnMouseEnter;
            buttonAdmin.MouseLeave += btnMouseLeave;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(859, -4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(51, 60);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonVotantes
            // 
            buttonVotantes.Cursor = Cursors.Hand;
            buttonVotantes.FlatAppearance.BorderSize = 0;
            buttonVotantes.FlatStyle = FlatStyle.Flat;
            buttonVotantes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVotantes.ForeColor = Color.White;
            buttonVotantes.Location = new Point(90, 0);
            buttonVotantes.Margin = new Padding(3, 4, 3, 4);
            buttonVotantes.Name = "buttonVotantes";
            buttonVotantes.Size = new Size(160, 53);
            buttonVotantes.TabIndex = 1;
            buttonVotantes.Text = "Votantes";
            buttonVotantes.UseVisualStyleBackColor = true;
            buttonVotantes.Click += buttonVotantes_Click;
            buttonVotantes.MouseEnter += btnMouseEnter;
            buttonVotantes.MouseLeave += btnMouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 62, 80);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 60);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 540);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 62, 80);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(556, 60);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 529);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(51, 62, 80);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(6, 589);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(556, 11);
            panel3.TabIndex = 4;
            // 
            // panelVotantes
            // 
            panelVotantes.BackColor = Color.LightGray;
            panelVotantes.BorderStyle = BorderStyle.Fixed3D;
            panelVotantes.Controls.Add(panelAdministrador);
            panelVotantes.Controls.Add(button4);
            panelVotantes.Controls.Add(comboBox1);
            panelVotantes.Controls.Add(comboBox2);
            panelVotantes.Dock = DockStyle.Fill;
            panelVotantes.Location = new Point(6, 60);
            panelVotantes.Margin = new Padding(3, 4, 3, 4);
            panelVotantes.Name = "panelVotantes";
            panelVotantes.Size = new Size(556, 529);
            panelVotantes.TabIndex = 5;
            // 
            // panelAdministrador
            // 
            panelAdministrador.BackColor = Color.LightGray;
            panelAdministrador.BorderStyle = BorderStyle.Fixed3D;
            panelAdministrador.Controls.Add(buttonAgregarCandidato);
            panelAdministrador.Controls.Add(button8);
            panelAdministrador.Controls.Add(button2);
            panelAdministrador.Controls.Add(btnVotosCandidato);
            panelAdministrador.Controls.Add(button5);
            panelAdministrador.Dock = DockStyle.Fill;
            panelAdministrador.Location = new Point(0, 0);
            panelAdministrador.Margin = new Padding(3, 4, 3, 4);
            panelAdministrador.Name = "panelAdministrador";
            panelAdministrador.Size = new Size(552, 525);
            panelAdministrador.TabIndex = 3;
            panelAdministrador.UseWaitCursor = true;
            panelAdministrador.Visible = false;
            panelAdministrador.Paint += panelAdministrador_Paint;
            // 
            // buttonAgregarCandidato
            // 
            buttonAgregarCandidato.Location = new Point(42, 21);
            buttonAgregarCandidato.Margin = new Padding(3, 4, 3, 4);
            buttonAgregarCandidato.Name = "buttonAgregarCandidato";
            buttonAgregarCandidato.Size = new Size(137, 52);
            buttonAgregarCandidato.TabIndex = 4;
            buttonAgregarCandidato.Text = "Agregar candidatos";
            buttonAgregarCandidato.UseVisualStyleBackColor = true;
            buttonAgregarCandidato.UseWaitCursor = true;
            buttonAgregarCandidato.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(355, 21);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(137, 52);
            button8.TabIndex = 5;
            button8.Text = "Simular votación";
            button8.UseVisualStyleBackColor = true;
            button8.UseWaitCursor = true;
            button8.Click += button8_Click;
            // 
            // button2
            // 
            button2.Location = new Point(194, 173);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(170, 52);
            button2.TabIndex = 0;
            button2.Text = "Votos por departamento";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // btnVotosCandidato
            // 
            btnVotosCandidato.Location = new Point(194, 244);
            btnVotosCandidato.Margin = new Padding(3, 4, 3, 4);
            btnVotosCandidato.Name = "btnVotosCandidato";
            btnVotosCandidato.Size = new Size(170, 56);
            btnVotosCandidato.TabIndex = 1;
            btnVotosCandidato.Text = "Votos por candidato";
            btnVotosCandidato.UseVisualStyleBackColor = true;
            btnVotosCandidato.UseWaitCursor = true;
            btnVotosCandidato.Click += btnVotosCandidato_Click;
            // 
            // button5
            // 
            button5.Location = new Point(194, 325);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(170, 56);
            button5.TabIndex = 2;
            button5.Text = "Votos por partido";
            button5.UseVisualStyleBackColor = true;
            button5.UseWaitCursor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(209, 311);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(106, 49);
            button4.TabIndex = 2;
            button4.Text = "Votar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.Black;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(194, 67);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 28);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Departamento";
            comboBox1.UseWaitCursor = true;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.FlatStyle = FlatStyle.Flat; 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; 
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(42, 135);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(457, 28);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "Candidato";
            comboBox2.UseWaitCursor = true;
            comboBox2.BackColor = Color.White;
            comboBox2.ForeColor = Color.Black;
            comboBox2.FlatStyle = FlatStyle.Flat; // Esto cambia el estilo del borde
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList; //
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 600);
            Controls.Add(panel2);
            Controls.Add(panelVotantes);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pMenu.ResumeLayout(false);
            panelVotantes.ResumeLayout(false);
            panelAdministrador.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pMenu;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Panel panelVotantes;
        private Button buttonVotantes;
        private Button buttonAdmin;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button4;
        private Panel panelAdministrador;
        private Button button2;
        private Button btnVotosCandidato;
        private Button button5;
        private Button button8;
        private Button buttonAgregarCandidato;
    }
}
