using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryVegaEjercitacionIG2
{
    public partial class frmSistemasVentas : Form
    {
        private decimal totalgeneral;

        public frmSistemasVentas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            if (nudPrecio.Value <= 0)
            {
                MessageBox.Show("Por favor, ingrese un precio mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudPrecio.Focus();
                return;
            }

            decimal subtotal = nudPrecio.Value * nudCantidad.Value;

            //formatear el texto que se ingresara en al Listbox
            string lineaventa = $"{txtProducto.Text.Trim()} | cant: {nudCantidad.Value} | P.Unidad ${nudPrecio.Value:F2} | subtotal: ${subtotal:F2}";
            // agragar el registro al listbox y sumar el total general
            ltsAgregados.Items.Add(lineaventa);
            totalgeneral += subtotal;

            //actualizar la etiqueta del total 
            lblTotal.Text = $"Total Acumulado: ${totalgeneral:F2}";
            txtProducto.Clear();
            nudPrecio.Value = 1;
            nudCantidad.Value = 1;
            txtProducto.Focus();




        }



    }
}
