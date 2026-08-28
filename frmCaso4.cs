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
    public partial class frmCaso4 : Form
    {
        public frmCaso4()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Datos
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string dni = mtbDni.Text.Trim();

            // campos vacíos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // GENEROS
            string genero = "";
            if (rbnMasculino.Checked)
                genero = "Masculino";
            else if (rbnFemenino.Checked)
                genero = "Femenino";
            string turno = "";
            // TURNOS
            if (rbnMañana.Checked)
                turno = "Mañana";
            else if (rbnTarde.Checked)
                turno = "Tarde";
            else if (rbnNoche.Checked)
                turno = "Noche";
            // CARRERAS
            if (cmbCarrera.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una carrera.");
                return;
            }
            string carrera = cmbCarrera.SelectedItem.ToString();

            // Mostrar mensaje de registro exitoso
            string mensaje = $"Registro exitoso:\nNombre: {nombre}\nApellido: {apellido}\nDNI: {dni}\nGénero: {genero}\nTurno: {turno}\nCarrera: {carrera}";
            MessageBox.Show(mensaje, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmCaso4_Load(object sender, EventArgs e)
        {

        }
    }
}
