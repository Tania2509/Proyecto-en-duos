using Metodos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Vistas
{
    public partial class frnCheckOut : UserControl
    {
        private frnGestionReservas gestionReservas; // Campo privado

        public frnCheckOut(frnGestionReservas gestionReservas)
        {
            InitializeComponent();
            this.gestionReservas = gestionReservas;
        }

        private void txtDui_TextChanged(object sender, EventArgs e)
        {
            string dui = txtDui.Text.Trim();

            // Si no hay nada escrito, limpiamos la tabla
            if (string.IsNullOrEmpty(txtDui.Text))
            {
                dgvReservas.DataSource = null;
                return;
            }

            // Buscar en la base de datos
            DataTable resultados = CheckInOut.BuscarReservasCheckIn(dui);
            dgvReservas.DataSource = resultados; // Asignar los resultados obtenidos
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una reserva primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el idReserva de la fila seleccionada
            int idReserva = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["idReserva"].Value);

            // Ejecutar el proceso usando el idReserva directamente
            bool resultado = CheckInOut.RealizarCheckOut(idReserva);

            if (resultado)
            {
                MessageBox.Show("Check-Out realizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDui.Clear();
                dgvReservas.DataSource = null;
                gestionReservas.CargarReserva(); // Actualizar la lista de reservas en frnGestionReservas
            }
            else
            {
                MessageBox.Show("No se pudo completar el Check-Out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Mostrar detalles en consola o labels si quieres
                string idReserva = dgvReservas.Rows[e.RowIndex].Cells["idReserva"].Value.ToString();
                Console.WriteLine("Reserva seleccionada: " + idReserva);
            }
        }
    }
}
