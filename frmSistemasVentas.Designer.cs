namespace cryVegaEjercitacionIG2
{
    partial class frmSistemasVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Añadir estas declaraciones:
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btmAgregar;
        private System.Windows.Forms.ListBox ltsAgregados;

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
            lblProducto = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            nudPrecio = new NumericUpDown();
            nudCantidad = new NumericUpDown();
            txtProducto = new TextBox();
            btmAgregar = new Button();
            ltsAgregados = new ListBox();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(101, 45);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            lblProducto.Click += label1_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(101, 87);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 1;
            lblPrecio.Text = "Precio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(101, 131);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(216, 85);
            nudPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudPrecio.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(80, 23);
            nudPrecio.TabIndex = 3;
            nudPrecio.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(216, 129);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(80, 23);
            nudCantidad.TabIndex = 4;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(216, 42);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(108, 23);
            txtProducto.TabIndex = 5;
            // 
            // btmAgregar
            // 
            btmAgregar.Location = new Point(172, 181);
            btmAgregar.Name = "btmAgregar";
            btmAgregar.Size = new Size(75, 23);
            btmAgregar.TabIndex = 6;
            btmAgregar.Text = "Agregar";
            btmAgregar.UseVisualStyleBackColor = true;
            btmAgregar.Click += btmAgregar_Click;
            // 
            // ltsAgregados
            // 
            ltsAgregados.FormattingEnabled = true;
            ltsAgregados.ItemHeight = 15;
            ltsAgregados.Location = new Point(12, 217);
            ltsAgregados.Name = "ltsAgregados";
            ltsAgregados.Size = new Size(396, 124);
            ltsAgregados.TabIndex = 7;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(13, 356);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 8;
            // 
            // frmSistemasVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 382);
            Controls.Add(lblTotal);
            Controls.Add(ltsAgregados);
            Controls.Add(btmAgregar);
            Controls.Add(txtProducto);
            Controls.Add(nudCantidad);
            Controls.Add(nudPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(lblPrecio);
            Controls.Add(lblProducto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSistemasVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de ventas";
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label lblTotal;
    }
}