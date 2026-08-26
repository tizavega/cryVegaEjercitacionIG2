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
    public partial class frmCaso1 : Form
    {
        public frmCaso1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPresentar_Click(object sender, EventArgs e)
        {
            
            // 1. Validar que los campos de texto no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                cmbCarrera.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, llene todos los campos requeridos.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2. Formatear la cadena de datos
            string datosAlumno = $"{txtApellido.Text.Trim()}, {txtNombre.Text.Trim()} | Edad: {txtEdad.Text} años | Carrera: {cmbCarrera.SelectedItem}";
            MessageBox.Show(datosAlumno);

          // 4. Limpiar los campos para el siguiente registro
          txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Text = "0";
            cmbCarrera.SelectedIndex = 0;
            txtNombre.Focus();
        }
        private void frmCaso1_Load(object sender, EventArgs e)
        {

        }
    }
}
