namespace SistemaDeVotacion
{
    partial class MergeSortForm
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
            dataGridView1 = new DataGridView();
            buttonRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(250, 420);
            dataGridView1.TabIndex = 0;
            // 
            // buttonRegresar
            // 
            buttonRegresar.Location = new Point(100, 464);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(100, 35);
            buttonRegresar.TabIndex = 1;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = true;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // MergeSortForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(284, 511);
            Controls.Add(buttonRegresar);
            Controls.Add(dataGridView1);
            Name = "MergeSortForm";
            Text = "MergeSortForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonRegresar;
    }
}