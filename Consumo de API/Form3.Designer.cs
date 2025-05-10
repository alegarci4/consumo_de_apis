namespace Clase_3Mayo
{
    partial class Form3
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
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblPeso = new Label();
            lblAltura = new Label();
            pictureBox1 = new PictureBox();
            btnConsulta = new Button();
            label1 = new Label();
            buttonLimpiar = new Button();
            buttonArchivo = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(333, 17);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(169, 27);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(167, 71);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(167, 124);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(42, 20);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(167, 184);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(52, 20);
            lblAltura.TabIndex = 3;
            lblAltura.Text = "Altura:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(431, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 176);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(266, 259);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(149, 47);
            btnConsulta.TabIndex = 7;
            btnConsulta.Text = "Consultar";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(315, 20);
            label1.TabIndex = 8;
            label1.Text = "Ingrese el nombre del Pokemon que desea ver";
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(468, 260);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(143, 46);
            buttonLimpiar.TabIndex = 9;
            buttonLimpiar.Text = "Limpiar Busqueda";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // buttonArchivo
            // 
            buttonArchivo.Location = new Point(371, 321);
            buttonArchivo.Name = "buttonArchivo";
            buttonArchivo.Size = new Size(166, 51);
            buttonArchivo.TabIndex = 10;
            buttonArchivo.Text = "Guardar resultados en TXT";
            buttonArchivo.UseVisualStyleBackColor = true;
            buttonArchivo.Click += buttonArchivo_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonArchivo);
            Controls.Add(buttonLimpiar);
            Controls.Add(label1);
            Controls.Add(btnConsulta);
            Controls.Add(pictureBox1);
            Controls.Add(lblAltura);
            Controls.Add(lblPeso);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblPeso;
        private Label lblAltura;
        private PictureBox pictureBox1;
        private Button btnConsulta;
        private Label label1;
        private Button buttonLimpiar;
        private Button buttonArchivo;
    }
}