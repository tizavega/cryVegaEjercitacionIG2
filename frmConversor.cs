using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryVegaEjercitacionIG2
{
    public partial class frmConversor : Form
    {
        public frmConversor()
        {
            InitializeComponent();
        }

        private void frmConversor_Load(object sender, EventArgs e)
        {

        }

        private void btmConvertir_Click(object sender, EventArgs e)
        {
            if (cmbDesde.SelectedItem == null || cmbHasta.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona las dos unidades antes de calcular.");
                return;
            }

            if (!double.TryParse(mtbValor.Text, out double cantidad))
            {
                MessageBox.Show("Introduce un valor numérico válido.");
                return;
            }

            double resultado = 0;
            string desde = cmbDesde.SelectedItem.ToString();
            string hasta = cmbHasta.SelectedItem.ToString();
            string unidadMedida = "";

            if (desde == hasta)
            {
                MessageBox.Show("Seleccione unidades diferentes para convertir.");
                return;
            }

            if (desde == "metros" && hasta == "centimetros")
            {
                resultado = cantidad * 100;
                unidadMedida = "cm";
            }
            else if (desde == "centimetros" && hasta == "metros")
            {
                resultado = cantidad / 100;
                unidadMedida = "m";
            }
            else
            {
                MessageBox.Show("Conversión no soportada.");
                return;
            }

            lblResultado.Text = "Resultado " + resultado.ToString() + "  " + unidadMedida;
        }

        private void cmbDesde_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
