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
    public partial class frnReservasRecepcionista : UserControl
    {
        public frnReservasRecepcionista(frnGestionReservas gestionReservas)
        {
            InitializeComponent();
            CheckIn = new frnCheckIn(gestionReservas);
            Reservas = gestionReservas; // Inicialización necesaria
        }

        private frnCheckIn CheckIn;
        private frnGestionReservas Reservas;

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

        private void frnReservasRecepcionista_Load(object sender, EventArgs e)
        {
            CargarComboboxReserva();
            SincronizarComboboxClientes();
        }

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
                Reservas.CargarReserva(); // Método para recargar la lista de reservas

                MessageBox.Show("Se registró correctamente la reserva", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la reserva: " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
