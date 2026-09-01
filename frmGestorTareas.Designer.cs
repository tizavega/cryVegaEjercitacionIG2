namespace cryVegaEjercitacionIG2
{
    partial class frmGestorTareas
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
            lblTarea = new Label();
            lblPrioridad = new Label();
            lblFecha = new Label();
            txtTarea = new TextBox();
            cmbPrioridad = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btmAgregar = new Button();
            btmEliminar = new Button();
            btmCompletar = new Button();
            clbTareas = new CheckedListBox();
            SuspendLayout();
            // 
            // lblTarea
            // 
            lblTarea.AutoSize = true;
            lblTarea.Location = new Point(115, 51);
            lblTarea.Name = "lblTarea";
            lblTarea.Size = new Size(34, 15);
            lblTarea.TabIndex = 0;
            lblTarea.Text = "Tarea";
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Location = new Point(115, 89);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(55, 15);
            lblPrioridad.TabIndex = 1;
            lblPrioridad.Text = "Prioridad";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(115, 127);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // txtTarea
            // 
            txtTarea.Location = new Point(191, 48);
            txtTarea.Name = "txtTarea";
            txtTarea.Size = new Size(100, 23);
            txtTarea.TabIndex = 4;
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.FormattingEnabled = true;
            cmbPrioridad.Items.AddRange(new object[] { "alta", "media", "baja" });
            cmbPrioridad.Location = new Point(191, 86);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(121, 23);
            cmbPrioridad.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(191, 124);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // btmAgregar
            // 
            btmAgregar.Location = new Point(115, 178);
            btmAgregar.Name = "btmAgregar";
            btmAgregar.Size = new Size(75, 23);
            btmAgregar.TabIndex = 7;
            btmAgregar.Text = "Agregar";
            btmAgregar.UseVisualStyleBackColor = true;
            btmAgregar.Click += btmAgregar_Click;
            // 
            // btmEliminar
            // 
            btmEliminar.Location = new Point(16, 395);
            btmEliminar.Name = "btmEliminar";
            btmEliminar.Size = new Size(75, 23);
            btmEliminar.TabIndex = 9;
            btmEliminar.Text = "Eliminar";
            btmEliminar.UseVisualStyleBackColor = true;
            btmEliminar.Click += btmEliminar_Click;
            // 
            // btmCompletar
            // 
            btmCompletar.Location = new Point(115, 395);
            btmCompletar.Name = "btmCompletar";
            btmCompletar.Size = new Size(75, 23);
            btmCompletar.TabIndex = 10;
            btmCompletar.Text = "Completar";
            btmCompletar.UseVisualStyleBackColor = true;
            btmCompletar.Click += btmCompletar_Click;
            // 
            // clbTareas
            // 
            clbTareas.FormattingEnabled = true;
            clbTareas.Location = new Point(12, 233);
            clbTareas.Name = "clbTareas";
            clbTareas.Size = new Size(376, 148);
            clbTareas.TabIndex = 11;
            // 
            // frmGestorTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 452);
            Controls.Add(clbTareas);
            Controls.Add(btmCompletar);
            Controls.Add(btmEliminar);
            Controls.Add(btmAgregar);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbPrioridad);
            Controls.Add(txtTarea);
            Controls.Add(lblFecha);
            Controls.Add(lblPrioridad);
            Controls.Add(lblTarea);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGestorTareas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor De Tareas";
            Load += frmGestorTareas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTarea;
        private Label lblPrioridad;
        private Label lblFecha;
        private TextBox txtTarea;
        private ComboBox cmbPrioridad;
        private DateTimePicker dateTimePicker1;
        private Button btmAgregar;
        private Button btmEliminar;
        private Button btmCompletar;
        private CheckedListBox clbTareas;
    }
}

