namespace Clase_3Mayo
{
    partial class Form2
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
            btnSync = new Button();
            btnAsync = new Button();
            lblEstado = new Label();
            lblCafe = new Label();
            lblTostadas = new Label();
            lblJugo = new Label();
            SuspendLayout();
            // 
            // btnSync
            // 
            btnSync.Location = new Point(27, 28);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(187, 46);
            btnSync.TabIndex = 0;
            btnSync.Text = "Preparar Sincrono";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // btnAsync
            // 
            btnAsync.Location = new Point(295, 27);
            btnAsync.Name = "btnAsync";
            btnAsync.Size = new Size(148, 42);
            btnAsync.TabIndex = 1;
            btnAsync.Text = "Preparar Async";
            btnAsync.UseVisualStyleBackColor = true;
            btnAsync.Click += btnAsync_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(35, 115);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(88, 20);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Esperando...";
            // 
            // lblCafe
            // 
            lblCafe.AutoSize = true;
            lblCafe.Location = new Point(37, 159);
            lblCafe.Name = "lblCafe";
            lblCafe.Size = new Size(42, 20);
            lblCafe.TabIndex = 3;
            lblCafe.Text = "Café:";
            // 
            // lblTostadas
            // 
            lblTostadas.AutoSize = true;
            lblTostadas.Location = new Point(35, 199);
            lblTostadas.Name = "lblTostadas";
            lblTostadas.Size = new Size(70, 20);
            lblTostadas.TabIndex = 4;
            lblTostadas.Text = "Tostadas:";
            // 
            // lblJugo
            // 
            lblJugo.AutoSize = true;
            lblJugo.Location = new Point(33, 245);
            lblJugo.Name = "lblJugo";
            lblJugo.RightToLeft = RightToLeft.No;
            lblJugo.Size = new Size(43, 20);
            lblJugo.TabIndex = 5;
            lblJugo.Text = "Jugo:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblJugo);
            Controls.Add(lblTostadas);
            Controls.Add(lblCafe);
            Controls.Add(lblEstado);
            Controls.Add(btnAsync);
            Controls.Add(btnSync);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSync;
        private Button btnAsync;
        private Label lblEstado;
        private Label lblCafe;
        private Label lblTostadas;
        private Label lblJugo;
    }
}