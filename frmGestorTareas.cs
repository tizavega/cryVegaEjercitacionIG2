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
    public partial class frmGestorTareas : Form
    {
        public frmGestorTareas()
        {
            InitializeComponent();
            //Cargar prioridades por defecto
            cmbPrioridad.Items.Add("Alta");
            cmbPrioridad.Items.Add("Media");
            cmbPrioridad.Items.Add("Baja");
            cmbPrioridad.SelectedIndex = 0; // Selecciona la primera prioridad por defecto

        }
        public class Tarea
        {
            public string Nombre { get; set; }
            public string Prioridad { get; set; }
            public DateTime Fecha { get; set; }
            public bool completada { get; set; }

            public Tarea(string nombre, string prioridad, DateTime fecha)
            {
                Nombre = nombre;
                Prioridad = prioridad;
                Fecha = fecha;
                completada = false;
            }
            public override string ToString()
            {
                string estado = completada ? "[x]" : "[ ]";
                return $"{estado} {Nombre} - {Prioridad} - {Fecha.ToShortDateString()}";
            }
        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                MessageBox.Show("Por favor, ingresa una tarea.");
                return;
            }

            // Crear la tarea y luego agregarla al CheckedListBox (clbTareas)
            Tarea nuevaTarea = new Tarea(txtTarea.Text, cmbPrioridad.SelectedItem.ToString(), dateTimePicker1.Value);
            clbTareas.Items.Add(nuevaTarea);

            // limpiar campos
            txtTarea.Clear();
            txtTarea.Focus();
        }

        private void frmGestorTareas_Load(object sender, EventArgs e)
        {

        }

        private void btmCompletar_Click(object sender, EventArgs e)
        {
            int index = clbTareas.SelectedIndex;
            if (index != -1)
            {
                bool estadoActual = clbTareas.GetItemChecked(index);
                clbTareas.SetItemChecked(index, !estadoActual);

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una tarea para marcarla como completada.");
            }
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            if (clbTareas.SelectedIndex != -1)
            {
                clbTareas.Items.RemoveAt(clbTareas.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecciona una tarea para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
