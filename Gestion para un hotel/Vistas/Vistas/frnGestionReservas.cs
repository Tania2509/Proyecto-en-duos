using Metodos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Vistas
{
    public partial class frnGestionReservas : UserControl
    {
        
        public frnGestionReservas()
        {
            InitializeComponent();
            CheckIn = new frnCheckIn(this); 
        }


        private frnCheckIn CheckIn;
        public void CargarReserva()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = Reserva.CargarReservas();
        }


        #region Combobox

        private void CargarComboboxReserva()
        {
            // Cargar Métodos de Pago
            cbPago.DataSource = null;
            cbPago.DataSource = Pago.CargarMetodosPago();
            cbPago.DisplayMember = "nombreMetodo";
            cbPago.ValueMember = "idPago";
            cbPago.SelectedIndex = -1;

            // Cargar Clientes - ComboBox para Nombre y Apellido
            cbCliente.DataSource = null;
            DataTable clientes = Cliente.CargarClientes();

            // Crear columna combinada para nombre completo
            clientes.Columns.Add("NombreCompleto", typeof(string), "nombreCli + ' ' + apellidoCli");

            cbCliente.DataSource = clientes;
            cbCliente.DisplayMember = "NombreCompleto";
            cbCliente.ValueMember = "idCliente";
            cbCliente.SelectedIndex = -1;

            // Cargar Clientes - ComboBox separado para DUI
            cbDui.DataSource = null;
            cbDui.DataSource = clientes; // Mismo DataTable
            cbDui.DisplayMember = "duiCli";
            cbDui.ValueMember = "idCliente";
            cbDui.SelectedIndex = -1;

            // Cargar Habitaciones
            cbHabitacion.DataSource = null;
            cbHabitacion.DataSource = Habitacion.CargarHabitaciones();
            cbHabitacion.DisplayMember = "numeroHabitacion";
            cbHabitacion.ValueMember = "idHabitaciones";
            cbHabitacion.SelectedIndex = -1;
        }

        private void SincronizarComboboxClientes()
        {
            // Cuando cambie la selección en el ComboBox de nombre
            cbCliente.SelectedIndexChanged += (sender, e) =>
            {
                if (cbCliente.SelectedValue != null && cbCliente.SelectedValue != DBNull.Value)
                {
                    cbDui.SelectedValue = cbCliente.SelectedValue;
                }
            };

            // Cuando cambie la selección en el ComboBox de DUI
            cbDui.SelectedIndexChanged += (sender, e) =>
            {
                if (cbDui.SelectedValue != null && cbDui.SelectedValue != DBNull.Value)
                {
                    cbCliente.SelectedValue = cbDui.SelectedValue;
                }
            };
        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        { 
            try
            {
                // Validaciones de campos vacíos
                if (string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                    cbHabitacion.SelectedIndex == -1 ||
                    cbPago.SelectedIndex == -1 ||
                    cbCliente.SelectedIndex == -1 ||
                    dtpEntrada.Value == null ||
                    dtpSalida.Value == null)
                {
                    MessageBox.Show("No puedes dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    return;
                }

                // Validar que la fecha de salida sea mayor a la de entrada
                if (dtpSalida.Value <= dtpEntrada.Value)
                {
                    MessageBox.Show("La fecha de salida debe ser mayor a la fecha de entrada", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpSalida.Focus();
                    return;
                }

                // Validar para que la cantidad no sea mayor o igual a 0
                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número válido mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    return;
                }

                    //Verificar capacidad de la habitación
                int idHabitacion = Convert.ToInt32(cbHabitacion.SelectedValue);
                int capacidadHabitacion = Reserva.CapacidadHabitacion(idHabitacion);

                if (cantidad > capacidadHabitacion)
                {
                    MessageBox.Show($"La habitación seleccionada tiene capacidad para {capacidadHabitacion} persona(s). " +
                                   $"No puede alojar {cantidad} persona(s).",
                                   "Capacidad excedida",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                    txtCantidad.Focus();
                    return;
                }

                // Crear objeto Reserva y asignar valores
                Reserva reserva = new Reserva();
                reserva.Cantidad = cantidad;
                reserva.FechaEntrada = dtpEntrada.Value;
                reserva.FechaSalida = dtpSalida.Value;
                reserva.IdPago = Convert.ToInt32(cbPago.SelectedValue);
                reserva.IdHabitacion = Convert.ToInt32(cbHabitacion.SelectedValue);
                reserva.IdCliente = Convert.ToInt32(cbCliente.SelectedValue);

                // Insertar la reserva
                reserva.InsertarReserva();
                CheckIn.MostrarEspera(); // Actualizar la vista de Check-In
                CargarReserva(); // Método para recargar la lista de reservas

                MessageBox.Show("Se registró correctamente la reserva", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la reserva: " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frnGestionReservas_Load(object sender, EventArgs e)
        {
            CargarComboboxReserva();
            SincronizarComboboxClientes();
            CargarReserva();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una reserva para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el idReserva de la fila seleccionada
            int idReserva = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["idReserva"].Value);

            // Crear instancia y asignar propiedades desde los controles
            Reserva reserva = new Reserva
            {
                IdReserva = idReserva,
                Cantidad = int.TryParse(txtCantidad.Text, out int cantidad) ? cantidad : 0,
                FechaEntrada = dtpEntrada.Value,
                FechaSalida = dtpSalida.Value,
                IdPago = Convert.ToInt32(cbPago.SelectedValue),
                IdHabitacion = Convert.ToInt32(cbHabitacion.SelectedValue),
                IdCliente = Convert.ToInt32(cbCliente.SelectedValue)
            };

            // Llamar al método de actualización
            bool actualizado = reserva.ActualizarReserva();

            if (actualizado)
            {
                MessageBox.Show("Reserva actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarReserva(); // Refresca la lista de reservas
            }
            else
            {
                MessageBox.Show("No se pudo actualizar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Reserva reservaEliminar = new Reserva();
            int id = int.Parse(dgvReservas.CurrentRow.Cells[0].Value.ToString());
            string registroEliminar = dgvReservas.CurrentRow.Cells[1].Value.ToString();
            DialogResult respueta = MessageBox.Show("¿Quieres eliminar este registro?" + registroEliminar, "Advertencia eliminaras un regsitro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respueta == DialogResult.Yes)
            {
                if (reservaEliminar.eliminarReserva(id) == true)
                { 
                    MessageBox.Show("Se elimino correctamente el registro", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarReserva();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvReservas_DoubleClick(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow != null)
            {

                txtCantidad.Text = dgvReservas.CurrentRow.Cells["Cantidad de personas"].Value.ToString();
                dtpEntrada.Value = Convert.ToDateTime(dgvReservas.CurrentRow.Cells["Fecha de entrada"].Value);
                dtpSalida.Value = Convert.ToDateTime(dgvReservas.CurrentRow.Cells["Fecha de salida"].Value);

                cbCliente.Text = dgvReservas.CurrentRow.Cells["Nombre del Cliente"].Value.ToString();
                cbHabitacion.Text = dgvReservas.CurrentRow.Cells["Número de habitación"].Value.ToString();
                cbPago.Text = dgvReservas.CurrentRow.Cells["Pago"].Value.ToString();
                cbDui.Text = dgvReservas.CurrentRow.Cells["DUI del cliente"].Value.ToString();
            }
        }
    }
}
