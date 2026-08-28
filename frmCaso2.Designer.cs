namespace cryVegaEjercitacionIG2
{
    partial class frmCaso2
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
            lblNúmero1 = new Label();
            lblNúmero2 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnMultiplicacion = new Button();
            btnSuma = new Button();
            btnResta = new Button();
            btnDividir = new Button();
            lblResultado = new Label();
            btmReiniciar = new Button();
            SuspendLayout();
            // 
            // lblNúmero1
            // 
            lblNúmero1.AutoSize = true;
            lblNúmero1.Location = new Point(99, 45);
            lblNúmero1.Name = "lblNúmero1";
            lblNúmero1.Size = new Size(60, 15);
            lblNúmero1.TabIndex = 0;
            lblNúmero1.Text = "Número 1";
            // 
            // lblNúmero2
            // 
            lblNúmero2.AutoSize = true;
            lblNúmero2.Location = new Point(99, 88);
            lblNúmero2.Name = "lblNúmero2";
            lblNúmero2.Size = new Size(57, 15);
            lblNúmero2.TabIndex = 1;
            lblNúmero2.Text = "Número2";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(209, 42);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(209, 85);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 3;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Location = new Point(12, 156);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(75, 23);
            btnMultiplicacion.TabIndex = 4;
            btnMultiplicacion.Text = "( X )";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(99, 156);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(75, 23);
            btnSuma.TabIndex = 5;
            btnSuma.Text = "( + )";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(191, 156);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(75, 23);
            btnResta.TabIndex = 6;
            btnResta.Text = "( - )";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(286, 156);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "( / )";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(271, 233);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 8;
            // 
            // btmReiniciar
            // 
            btmReiniciar.Location = new Point(84, 229);
            btmReiniciar.Name = "btmReiniciar";
            btmReiniciar.Size = new Size(75, 23);
            btmReiniciar.TabIndex = 9;
            btmReiniciar.Text = "Reiniciar";
            btmReiniciar.UseVisualStyleBackColor = true;
            btmReiniciar.Click += btmReiniciar_Click;
            // 
            // frmCaso2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 330);
            Controls.Add(btmReiniciar);
            Controls.Add(lblResultado);
            Controls.Add(btnDividir);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(btnMultiplicacion);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNúmero2);
            Controls.Add(lblNúmero1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCaso2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += frmCaso2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNúmero1;
        private Label lblNúmero2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnMultiplicacion;
        private Button btnSuma;
        private Button btnResta;
        private Button btnDividir;
        private Label lblResultado;
        private Button btmReiniciar;
    }
}