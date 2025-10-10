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
    public partial class frmHabitaciones : Form
    {
        public frmHabitaciones()
        {
            InitializeComponent();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de campos vacíos
                if ((string.IsNullOrWhiteSpace(txtNumero.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text)))
                {
                    MessageBox.Show("No puedes dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    return;
                }

                Habitacion Hab = new Habitacion();
                Hab.Cantidad =  int.Parse(txtCantidad.Text);
                Hab.NumeroHabitacion = txtNumero.Text;
                Hab.Precio = Convert.ToDouble(txtPrecio.Text);

                // Insertar la reserva
                Hab.InsertarHabitación();
                CargarHabitacion();

                MessageBox.Show("Se registró correctamente la reserva", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la reserva: " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmHabitaciones_Load(object sender, EventArgs e)
        {
            CargarHabitacion();
        }

        public void CargarHabitacion()
        {
            dgvHabitaciones.DataSource = null;
            dgvHabitaciones.DataSource = Habitacion.MostrarHabitaciones();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una reserva para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el idReserva de la fila seleccionada
            int idReserva = Convert.ToInt32(dgvHabitaciones.SelectedRows[0].Cells["idHabitaciones"].Value);

            // Crear instancia y asignar propiedades desde los controles
            Habitacion hab = new Habitacion
            {
                Id = idReserva,
                Cantidad = int.Parse(txtCantidad.Text),
                NumeroHabitacion = txtNumeroHab.Text,
                Precio = double.Parse(txtPrecio.Text)
            };

            // Llamar al método de actualización
            bool actualizado = hab.ActualizarReserva();

            if (actualizado)
            {
                MessageBox.Show("Reserva actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHabitacion(); // Refresca la lista de reservas
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Habitacion Eliminar = new Habitacion();
            int id = int.Parse(dgvHabitaciones.CurrentRow.Cells[0].Value.ToString());
            string registroEliminar = dgvHabitaciones.CurrentRow.Cells[1].Value.ToString();
            DialogResult respueta = MessageBox.Show("¿Quieres eliminar este registro?" + registroEliminar, "Advertencia eliminaras un regsitro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respueta == DialogResult.Yes)
            {
                if (Eliminar.EliminarHabitacion(id) == true)
                {
                    MessageBox.Show("Se elimino correctamente el registro", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarHabitacion();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvHabitaciones_DoubleClick(object sender, EventArgs e)
        {
            if (dgvHabitaciones.CurrentRow != null)
            {

                txtPrecio.Text = dgvHabitaciones.CurrentRow.Cells["precio"].Value.ToString();
                txtNumero.Text = dgvHabitaciones.CurrentRow.Cells["numeroHabitacion"].Value.ToString();
                txtCantidad.Text = dgvHabitaciones.CurrentRow.Cells["cantidad"].Value.ToString();

            }
        }
    }
}
