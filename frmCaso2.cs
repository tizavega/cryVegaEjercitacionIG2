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
    public partial class frmCaso2 : Form
    {
        public frmCaso2()
        {
            InitializeComponent();
        }

        private void frmCaso2_Load(object sender, EventArgs e)
        {

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            double num1 = double.Parse(txtNumero1.Text);
            double num2 = double.Parse(txtNumero2.Text);
            double resultado = num1 * num2;
            lblResultado.Text = "resultado: " + resultado.ToString();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            double num1 = double.Parse(txtNumero1.Text);
            double num2 = double.Parse(txtNumero2.Text);
            double resultado = num1 + num2;
            lblResultado.Text = "resultado: " + resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            double num1 = double.Parse(txtNumero1.Text);
            double num2 = double.Parse(txtNumero2.Text);
            double resultado = num1 - num2;
            lblResultado.Text = "resultado: " + resultado.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            double num1 = double.Parse(txtNumero1.Text);
            double num2 = double.Parse(txtNumero2.Text);
            double resultado = num1 / num2;
            lblResultado.Text = "resultado: " + resultado.ToString();
        }

        private void btmReiniciar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "";

            txtNumero1.Focus();
        }
        private bool ValidarCampos()

        {
            // Validar que los campos de texto no estén vacíos
            if(string.IsNullOrWhiteSpace(txtNumero1.Text) ||
                string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos requeridos.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;

            }
            return true;
        }
    }
}
