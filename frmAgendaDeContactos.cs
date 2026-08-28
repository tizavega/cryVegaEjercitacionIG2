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
    public partial class frmAgendaDeContactos : Form
    {
        public frmAgendaDeContactos()
        {
            InitializeComponent();
        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }
            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            //formato del contacto
            string contacto = $"{nombre} - {telefono}";

            //Agregar al listBox
            lstContactos.Items.Add(contacto);

            txtNombre.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();



        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            // Si no hay ningún elemento seleccionado, avisar y salir
            if (lstContactos.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Por favor, selecciona el contacto que desees eliminar",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Eliminar el contacto seleccionado
            lstContactos.Items.RemoveAt(lstContactos.SelectedIndex);
            MessageBox.Show("contacto eliminado correctamente.",
                "exito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}
