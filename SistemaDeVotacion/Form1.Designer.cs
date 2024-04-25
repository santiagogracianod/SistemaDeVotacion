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
            buttonVotantes = new Button();
            buttonAdmin = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panelVotantes = new Panel();
            button4 = new Button();
            panelAdministrador = new Panel();
            buttonAgregarCandidato = new Button();
            button8 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
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
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(492, 45);
            pMenu.TabIndex = 1;
            // 
            // buttonVotantes
            // 
            buttonVotantes.Cursor = Cursors.Hand;
            buttonVotantes.FlatAppearance.BorderSize = 0;
            buttonVotantes.FlatStyle = FlatStyle.Flat;
            buttonVotantes.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVotantes.ForeColor = Color.White;
            buttonVotantes.Location = new Point(79, 0);
            buttonVotantes.Name = "buttonVotantes";
            buttonVotantes.Size = new Size(140, 40);
            buttonVotantes.TabIndex = 1;
            buttonVotantes.Text = "Votantes";
            buttonVotantes.UseVisualStyleBackColor = true;
            buttonVotantes.Click += buttonVotantes_Click;
            buttonVotantes.MouseEnter += btnMouseEnter;
            buttonVotantes.MouseLeave += btnMouseLeave;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Cursor = Cursors.Hand;
            buttonAdmin.FlatAppearance.BorderSize = 0;
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdmin.ForeColor = Color.White;
            buttonAdmin.Location = new Point(253, 0);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(140, 40);
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
            button1.Location = new Point(752, -3);
            button1.Name = "button1";
            button1.Size = new Size(45, 45);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 62, 80);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 405);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 62, 80);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(487, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 397);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(51, 62, 80);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(5, 442);
            panel3.Name = "panel3";
            panel3.Size = new Size(487, 8);
            panel3.TabIndex = 4;
            // 
            // panelVotantes
            // 
            panelVotantes.BackColor = Color.LightGray;
            panelVotantes.BorderStyle = BorderStyle.Fixed3D;
            panelVotantes.Controls.Add(panelAdministrador);
            panelVotantes.Controls.Add(button4);
            panelVotantes.Dock = DockStyle.Fill;
            panelVotantes.Location = new Point(5, 45);
            panelVotantes.Name = "panelVotantes";
            panelVotantes.Size = new Size(487, 397);
            panelVotantes.TabIndex = 5;
            panelVotantes.Controls.Add(comboBox2);
            panelVotantes.Controls.Add(comboBox1);
            // 
            // button4
            // 
            button4.Location = new Point(183, 233);
            button4.Name = "button4";
            button4.Size = new Size(93, 37);
            button4.TabIndex = 2;
            button4.Text = "Votar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panelAdministrador
            // 
            panelAdministrador.BackColor = Color.LightGray;
            panelAdministrador.BorderStyle = BorderStyle.Fixed3D;
            panelAdministrador.Controls.Add(buttonAgregarCandidato);
            panelAdministrador.Controls.Add(button8);
            panelAdministrador.Controls.Add(button2);
            panelAdministrador.Controls.Add(button3);
            panelAdministrador.Controls.Add(button5);
            panelAdministrador.Dock = DockStyle.Fill;
            panelAdministrador.Location = new Point(0, 0);
            panelAdministrador.Name = "panelAdministrador";
            panelAdministrador.Size = new Size(483, 393);
            panelAdministrador.TabIndex = 3;
            panelAdministrador.UseWaitCursor = true;
            panelAdministrador.Visible = false;
            // 
            // buttonAgregarCandidato
            // 
            buttonAgregarCandidato.Location = new Point(37, 16);
            buttonAgregarCandidato.Name = "buttonAgregarCandidato";
            buttonAgregarCandidato.Size = new Size(120, 39);
            buttonAgregarCandidato.TabIndex = 4;
            buttonAgregarCandidato.Text = "Agregar candidatos";
            buttonAgregarCandidato.UseVisualStyleBackColor = true;
            buttonAgregarCandidato.UseWaitCursor = true;
            buttonAgregarCandidato.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(311, 16);
            button8.Name = "button8";
            button8.Size = new Size(120, 39);
            button8.TabIndex = 5;
            button8.Text = "Simular votación";
            button8.UseVisualStyleBackColor = true;
            button8.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.Location = new Point(170, 130);
            button2.Name = "button2";
            button2.Size = new Size(149, 39);
            button2.TabIndex = 0;
            button2.Text = "Votos por departamento";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            // 
            // button3
            // 
            button3.Location = new Point(170, 183);
            button3.Name = "button3";
            button3.Size = new Size(149, 42);
            button3.TabIndex = 1;
            button3.Text = "Votos por candidato";
            button3.UseVisualStyleBackColor = true;
            button3.UseWaitCursor = true;
            // 
            // button5
            // 
            button5.Location = new Point(170, 244);
            button5.Name = "button5";
            button5.Size = new Size(149, 42);
            button5.TabIndex = 2;
            button5.Text = "Votos por partido";
            button5.UseVisualStyleBackColor = true;
            button5.UseWaitCursor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(141, 101);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 1;
            comboBox2.Text = "Candidato";
            comboBox2.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Departamento";
            comboBox1.UseWaitCursor = true;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 450);
            Controls.Add(panel2);
            Controls.Add(panelVotantes);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pMenu);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button button3;
        private Button button5;
        private Button button8;
        private Button buttonAgregarCandidato;
    }
}
