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
            txtCarrera = new TextBox();
            btnPresentar = new Button();
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
            txtNombre.Location = new Point(191, 52);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(191, 86);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
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
            txtEdad.Location = new Point(191, 124);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(55, 23);
            txtEdad.TabIndex = 6;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(191, 161);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(100, 23);
            txtCarrera.TabIndex = 7;
            // 
            // btnPresentar
            // 
            btnPresentar.Location = new Point(144, 215);
            btnPresentar.Name = "btnPresentar";
            btnPresentar.Size = new Size(75, 23);
            btnPresentar.TabIndex = 8;
            btnPresentar.Text = "Presentar";
            btnPresentar.UseVisualStyleBackColor = true;
            // 
            // frmCaso1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 288);
            Controls.Add(btnPresentar);
            Controls.Add(txtCarrera);
            Controls.Add(txtEdad);
            Controls.Add(lblCarrera);
            Controls.Add(lblEdad);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "frmCaso1";
            Text = "Mi Presentación";
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
        private TextBox txtCarrera;
        private Button btnPresentar;
    }
}