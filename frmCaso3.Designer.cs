namespace cryVegaEjercitacionIG2
{
    partial class frmCaso3
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
            lblValor = new Label();
            txtValor = new TextBox();
            lblDesde = new Label();
            lblHacia = new Label();
            cmbCentimetros = new ComboBox();
            cmbMetros = new ComboBox();
            btmConvertir = new Button();
            SuspendLayout();
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(101, 47);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 0;
            lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(197, 44);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 1;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(95, 101);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(39, 15);
            lblDesde.TabIndex = 2;
            lblDesde.Text = "Desde";
            // 
            // lblHacia
            // 
            lblHacia.AutoSize = true;
            lblHacia.Location = new Point(95, 131);
            lblHacia.Name = "lblHacia";
            lblHacia.Size = new Size(37, 15);
            lblHacia.TabIndex = 3;
            lblHacia.Text = "Hacia";
            // 
            // cmbCentimetros
            // 
            cmbCentimetros.FormattingEnabled = true;
            cmbCentimetros.Location = new Point(185, 98);
            cmbCentimetros.Name = "cmbCentimetros";
            cmbCentimetros.Size = new Size(121, 23);
            cmbCentimetros.TabIndex = 4;
            cmbCentimetros.Text = "Centimetros";
            // 
            // cmbMetros
            // 
            cmbMetros.FormattingEnabled = true;
            cmbMetros.Location = new Point(185, 127);
            cmbMetros.Name = "cmbMetros";
            cmbMetros.Size = new Size(121, 23);
            cmbMetros.TabIndex = 5;
            cmbMetros.Text = "Metros";
            // 
            // btmConvertir
            // 
            btmConvertir.Location = new Point(158, 206);
            btmConvertir.Name = "btmConvertir";
            btmConvertir.Size = new Size(75, 23);
            btmConvertir.TabIndex = 6;
            btmConvertir.Text = "Convertir";
            btmConvertir.UseVisualStyleBackColor = true;
            // 
            // frmCaso3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 310);
            Controls.Add(btmConvertir);
            Controls.Add(cmbMetros);
            Controls.Add(cmbCentimetros);
            Controls.Add(lblHacia);
            Controls.Add(lblDesde);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Name = "frmCaso3";
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor;
        private TextBox txtValor;
        private Label lblDesde;
        private Label lblHacia;
        private ComboBox cmbCentimetros;
        private ComboBox cmbMetros;
        private Button btmConvertir;
    }
}