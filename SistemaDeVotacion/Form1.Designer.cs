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
            btnVotar = new Button();
            pMenu = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // btnVotar
            // 
            btnVotar.Location = new Point(231, 313);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(75, 23);
            btnVotar.TabIndex = 0;
            btnVotar.Text = "Votar";
            btnVotar.UseVisualStyleBackColor = true;
            // 
            // pMenu
            // 
            pMenu.BackColor = Color.FromArgb(51, 62, 80);
            pMenu.Dock = DockStyle.Top;
            pMenu.Location = new Point(0, 0);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(800, 100);
            pMenu.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 62, 80);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 350);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 62, 80);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(795, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 350);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(51, 62, 80);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(5, 442);
            panel3.Name = "panel3";
            panel3.Size = new Size(790, 8);
            panel3.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pMenu);
            Controls.Add(btnVotar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVotar;
        private Panel pMenu;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
