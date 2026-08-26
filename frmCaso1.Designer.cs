namespace cryVegaEjercitacionIG2
{
    partial class frmCaso1
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
            lblNombre = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblEdad = new Label();
            lblCarrera = new Label();
            txtEdad = new TextBox();
            btnPresentar = new Button();
            cmbCarrera = new ComboBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(92, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(92, 94);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(191, 57);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(191, 91);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(121, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(92, 132);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(92, 169);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 5;
            lblCarrera.Text = "Carrera";
            lblCarrera.Click += label3_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(191, 129);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(55, 23);
            txtEdad.TabIndex = 6;
            // 
            // btnPresentar
            // 
            btnPresentar.Location = new Point(237, 208);
            btnPresentar.Name = "btnPresentar";
            btnPresentar.Size = new Size(75, 23);
            btnPresentar.TabIndex = 8;
            btnPresentar.Text = "Presentar";
            btnPresentar.UseVisualStyleBackColor = true;
            btnPresentar.Click += btnPresentar_Click;
            // 
            // cmbCarrera
            // 
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Items.AddRange(new object[] { "Analista En Sistemas", "Programacion", "Creador De Videojuegos", "Comercio Exterior", "Diseño grafico" });
            cmbCarrera.Location = new Point(191, 166);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(121, 23);
            cmbCarrera.TabIndex = 9;
            cmbCarrera.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // frmCaso1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 288);
            Controls.Add(cmbCarrera);
            Controls.Add(btnPresentar);
            Controls.Add(txtEdad);
            Controls.Add(lblCarrera);
            Controls.Add(lblEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCaso1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mi Presentación";
            Load += frmCaso1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblEdad;
        private Label lblCarrera;
        private TextBox txtEdad;
        private Button btnPresentar;
        private ComboBox cmbCarrera;
    }
}