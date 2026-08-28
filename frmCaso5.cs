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
    public partial class frmCaso5 : Form
    {
        public frmCaso5()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }
           if (clave == "1234")
           {
               MessageBox.Show("Ingreso exitoso.", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
               lblRespuesta.ForeColor = Color.Red;
                lblRespuesta.Text = "usuario o clave incorrectos, intente nuevamente.";
            }
        }
    }
}
