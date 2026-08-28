namespace cryVegaEjercitacionIG2
{
    partial class frmAgendaDeContactos
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
            lblTelefeno = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            btmAgregar = new Button();
            btmEliminar = new Button();
            gbxAgenda = new GroupBox();
            lstContactos = new ListBox();
            gbxAgenda.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(94, 48);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblTelefeno
            // 
            lblTelefeno.AutoSize = true;
            lblTelefeno.Location = new Point(94, 93);
            lblTelefeno.Name = "lblTelefeno";
            lblTelefeno.Size = new Size(52, 15);
            lblTelefeno.TabIndex = 1;
            lblTelefeno.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(178, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(178, 90);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 3;
            // 
            // btmAgregar
            // 
            btmAgregar.Location = new Point(203, 147);
            btmAgregar.Name = "btmAgregar";
            btmAgregar.Size = new Size(75, 23);
            btmAgregar.TabIndex = 4;
            btmAgregar.Text = "Agregar";
            btmAgregar.UseVisualStyleBackColor = true;
            btmAgregar.Click += btmAgregar_Click;
            // 
            // btmEliminar
            // 
            btmEliminar.Location = new Point(94, 147);
            btmEliminar.Name = "btmEliminar";
            btmEliminar.Size = new Size(75, 23);
            btmEliminar.TabIndex = 5;
            btmEliminar.Text = "Eliminar";
            btmEliminar.UseVisualStyleBackColor = true;
            btmEliminar.Click += btmEliminar_Click;
            // 
            // gbxAgenda
            // 
            gbxAgenda.Controls.Add(lstContactos);
            gbxAgenda.Location = new Point(36, 176);
            gbxAgenda.Name = "gbxAgenda";
            gbxAgenda.Size = new Size(296, 153);
            gbxAgenda.TabIndex = 6;
            gbxAgenda.TabStop = false;
            gbxAgenda.Text = "Agenda";
            // 
            // lstContactos
            // 
            lstContactos.FormattingEnabled = true;
            lstContactos.ItemHeight = 15;
            lstContactos.Location = new Point(6, 22);
            lstContactos.Name = "lstContactos";
            lstContactos.Size = new Size(284, 124);
            lstContactos.TabIndex = 0;
            // 
            // frmAgendaDeContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 351);
            Controls.Add(gbxAgenda);
            Controls.Add(btmEliminar);
            Controls.Add(btmAgregar);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(lblTelefeno);
            Controls.Add(lblNombre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAgendaDeContactos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda de contactos";
            gbxAgenda.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblTelefeno;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private Button btmAgregar;
        private Button btmEliminar;
        private GroupBox gbxAgenda;
        private ListBox lstContactos;
    }
}
