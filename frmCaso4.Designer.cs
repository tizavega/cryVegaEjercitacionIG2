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
            rbnMasculino = new RadioButton();
            rbnFemenino = new RadioButton();
            rbnMañana = new RadioButton();
            rbnTarde = new RadioButton();
            rbnNoche = new RadioButton();
            lblCarrera = new Label();
            cmbCarrera = new ComboBox();
            btnRegistrar = new Button();
            mtbDni = new MaskedTextBox();
            gbxSexo = new GroupBox();
            gbxTurno = new GroupBox();
            gbxSexo.SuspendLayout();
            gbxTurno.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(44, 21);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(44, 50);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(44, 78);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(159, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(134, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(159, 47);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(134, 23);
            txtApellido.TabIndex = 4;
            // 
            // rbnMasculino
            // 
            rbnMasculino.AutoSize = true;
            rbnMasculino.Location = new Point(11, 22);
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
            rbnFemenino.Location = new Point(101, 22);
            rbnFemenino.Name = "rbnFemenino";
            rbnFemenino.Size = new Size(78, 19);
            rbnFemenino.TabIndex = 8;
            rbnFemenino.TabStop = true;
            rbnFemenino.Text = "Femenino";
            rbnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbnMañana
            // 
            rbnMañana.AutoSize = true;
            rbnMañana.Location = new Point(10, 22);
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
            rbnTarde.Location = new Point(100, 22);
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
            rbnNoche.Location = new Point(183, 22);
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
            lblCarrera.Location = new Point(44, 235);
            lblCarrera.Name = "lblCarrera";
            lblCarrera.Size = new Size(45, 15);
            lblCarrera.TabIndex = 13;
            lblCarrera.Text = "Carrera";
            // 
            // cmbCarrera
            // 
            cmbCarrera.FormattingEnabled = true;
            cmbCarrera.Items.AddRange(new object[] { "analista en sistemas", "programacion", "diseño grafico", "recursos humanos", "derecho", "comunicacion social" });
            cmbCarrera.Location = new Point(172, 232);
            cmbCarrera.Name = "cmbCarrera";
            cmbCarrera.Size = new Size(121, 23);
            cmbCarrera.TabIndex = 15;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(218, 289);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // mtbDni
            // 
            mtbDni.Location = new Point(159, 78);
            mtbDni.Name = "mtbDni";
            mtbDni.Size = new Size(134, 23);
            mtbDni.TabIndex = 17;
            // 
            // gbxSexo
            // 
            gbxSexo.Controls.Add(rbnFemenino);
            gbxSexo.Controls.Add(rbnMasculino);
            gbxSexo.Location = new Point(44, 111);
            gbxSexo.Name = "gbxSexo";
            gbxSexo.Size = new Size(200, 46);
            gbxSexo.TabIndex = 19;
            gbxSexo.TabStop = false;
            gbxSexo.Text = "sexo";
            // 
            // gbxTurno
            // 
            gbxTurno.Controls.Add(rbnNoche);
            gbxTurno.Controls.Add(rbnMañana);
            gbxTurno.Controls.Add(rbnTarde);
            gbxTurno.Location = new Point(44, 163);
            gbxTurno.Name = "gbxTurno";
            gbxTurno.Size = new Size(251, 53);
            gbxTurno.TabIndex = 20;
            gbxTurno.TabStop = false;
            gbxTurno.Text = "turno";
            // 
            // frmCaso4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 362);
            Controls.Add(gbxTurno);
            Controls.Add(gbxSexo);
            Controls.Add(mtbDni);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbCarrera);
            Controls.Add(lblCarrera);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblDNI);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCaso4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro De Alumno";
            Load += frmCaso4_Load;
            gbxSexo.ResumeLayout(false);
            gbxSexo.PerformLayout();
            gbxTurno.ResumeLayout(false);
            gbxTurno.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private RadioButton rbnMasculino;
        private RadioButton rbnFemenino;
        private Label lblTurno;
        private RadioButton rbnMañana;
        private RadioButton rbnTarde;
        private RadioButton rbnNoche;
        private Label lblCarrera;
        private ComboBox cmbCarrera;
        private Button btnRegistrar;
        private MaskedTextBox mtbDni;
        private GroupBox gbxSexo;
        private GroupBox gbxTurno;
    }
}