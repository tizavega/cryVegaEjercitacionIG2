namespace cryVegaEjercitacionIG2
{
    partial class frmConversor
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
            lblResultado = new Label();
            lblValor = new Label();
            lblDesde = new Label();
            lblHasta = new Label();
            cmbDesde = new ComboBox();
            cmbHasta = new ComboBox();
            btmConvertir = new Button();
            mtbValor = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(58, 201);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 0;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(73, 29);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 1;
            lblValor.Text = "Valor";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(73, 78);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(39, 15);
            lblDesde.TabIndex = 2;
            lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(73, 117);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(37, 15);
            lblHasta.TabIndex = 3;
            lblHasta.Text = "Hasta";
            // 
            // cmbDesde
            // 
            cmbDesde.FormattingEnabled = true;
            cmbDesde.Items.AddRange(new object[] { "centimetros", "metros" });
            cmbDesde.Location = new Point(164, 75);
            cmbDesde.Name = "cmbDesde";
            cmbDesde.Size = new Size(100, 23);
            cmbDesde.TabIndex = 4;
            cmbDesde.SelectedIndexChanged += cmbDesde_SelectedIndexChanged;
            // 
            // cmbHasta
            // 
            cmbHasta.FormattingEnabled = true;
            cmbHasta.Items.AddRange(new object[] { "centimetros", "metros" });
            cmbHasta.Location = new Point(164, 114);
            cmbHasta.Name = "cmbHasta";
            cmbHasta.Size = new Size(100, 23);
            cmbHasta.TabIndex = 5;
            // 
            // btmConvertir
            // 
            btmConvertir.Location = new Point(189, 162);
            btmConvertir.Name = "btmConvertir";
            btmConvertir.Size = new Size(75, 23);
            btmConvertir.TabIndex = 6;
            btmConvertir.Text = "Convertir";
            btmConvertir.UseVisualStyleBackColor = true;
            btmConvertir.Click += btmConvertir_Click;
            // 
            // mtbValor
            // 
            mtbValor.Location = new Point(164, 26);
            mtbValor.Name = "mtbValor";
            mtbValor.Size = new Size(100, 23);
            mtbValor.TabIndex = 7;
            // 
            // frmConversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 240);
            Controls.Add(mtbValor);
            Controls.Add(btmConvertir);
            Controls.Add(cmbHasta);
            Controls.Add(cmbDesde);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(lblValor);
            Controls.Add(lblResultado);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmConversor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor";
            Load += frmConversor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Label lblValor;
        private Label lblDesde;
        private Label lblHasta;
        private ComboBox cmbDesde;
        private ComboBox cmbHasta;
        private Button btmConvertir;
        private MaskedTextBox mtbValor;
    }
}