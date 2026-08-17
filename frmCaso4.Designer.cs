namespace cryVegaEjercitacionIG2
{
    partial class frmCaso4
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
            lblDNI = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            lblSexo = new Label();
            rbnMasculino = new RadioButton();
            rbnFemenino = new RadioButton();
            lblTurno = new Label();
            rbnMañana = new RadioButton();
            rbnTarde = new RadioButton();
            rbnNoche = new RadioButton();
            lblCarrera = new Label();
            cmbCarrera = new ComboBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(44, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(44, 77);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(44, 105);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(172, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(172, 74);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(172, 102);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 5;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(44, 157);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 6;
            lblSexo.Text = "Sexo";
            // 
            // rbnMasculino
            // 
            rbnMasculino.AutoSize = true;
            rbnMasculino.Location = new Point(129, 155);
            rbnMasculino.Name = "rbnMasculino";
            rbnMasculino.Size = new Size(80, 19);
            rbnMasculino.TabIndex = 7;
            rbnMasculino.TabStop = true;
            rbnMasculino.Text = "Masculino";
            rbnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbnFemenino
            // 
            rbnFemenino.AutoSize = true;
            rbnFemenino.Location = new Point(251, 155);
            rbnFemenino.Name = "rbnFemenino";
            rbnFemenino.Size = new Size(78, 19);
            rbnFemenino.TabIndex = 8;
            rbnFemenino.TabStop = true;
            rbnFemenino.Text = "Femenino";
            rbnFemenino.UseVisualStyleBackColor = true;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(44, 211);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(38, 15);
            lblTurno.TabIndex = 9;
            lblTurno.Text = "Turno";
            // 
            // rbnMañana
            // 
            rbnMañana.AutoSize = true;
            rbnMañana.Location = new Point(109, 209);
            rbnMañana.Name = "rbnMañana";
            rbnMañana.Size = new Size(68, 19);
            rbnMañana.TabIndex = 10;
            rbnMañana.TabStop = true;
            rbnMañana.Text = "Mañana";
            rbnMañana.UseVisualStyleBackColor = true;
            // 
            // rbnTarde
            // 
            rbnTarde.AutoSize = true;
            rbnTarde.Location = new Point(199, 209);
            rbnTarde.Name = "rbnTarde";
            rbnTarde.Size = new Size(53, 19);
            rbnTarde.TabIndex = 11;
            rbnTarde.TabStop = true;
            rbnTarde.Text = "Tarde";
            rbnTarde.UseVisualStyleBackColor = true;
            // 
            // rbnNoche
            // 
            rbnNoche.AutoSize = true;
            rbnNoche.Location = new Point(282, 209);
            rbnNoche.Name = "rbnNoche";
            rbnNoche.Size = new Size(60, 19);
            rbnNoche.TabIndex = 12;
            rbnNoche.TabStop = true;
            rbnNoche.Text = "Noche";
            rbnNoche.UseVisualStyleBackColor = true;
            // 
            // lblCarrera
            // 
            lblCarrera.AutoSize = true;
            lblCarrera.Location = new Point(44, 270);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 13;
            lblCarrera.Text = "Carrera";
            // 
            // cmbCarrera
            // 
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Location = new Point(172, 267);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(121, 23);
            cmbCarrera.TabIndex = 15;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(148, 317);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // frmCaso4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 384);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbCarrera);
            Controls.Add(lblCarrera);
            Controls.Add(rbnNoche);
            Controls.Add(rbnTarde);
            Controls.Add(rbnMañana);
            Controls.Add(lblTurno);
            Controls.Add(rbnFemenino);
            Controls.Add(rbnMasculino);
            Controls.Add(lblSexo);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmCaso4";
            Text = "Registro De Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private Label lblSexo;
        private RadioButton rbnMasculino;
        private RadioButton rbnFemenino;
        private Label lblTurno;
        private RadioButton rbnMañana;
        private RadioButton rbnTarde;
        private RadioButton rbnNoche;
        private Label lblCarrera;
        private ComboBox cmbCarrera;
        private Button btnRegistrar;
    }
}