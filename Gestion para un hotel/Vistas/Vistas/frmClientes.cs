using Metodos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Vistas
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }


        private bool EsMayorDeEdad(DateTime fechaNacimiento)
        {

            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajustar si aún no ha cumplido años este año
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
                edad--;

            // Validar rango de edad (1 a 80 años)
            if (edad < 1)
            {
                MessageBox.Show("La edad mínima debe ser 18 años", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNaciPa.Focus();
                return false;
            }

            if (edad > 40)
            {
                MessageBox.Show("La edad máxima no puede superar los 45 años", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNaciPa.Focus();
                return false;
            }

            return true;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de campos vacíos
                if ((string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtNumTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDui.Text) ||
                string.IsNullOrWhiteSpace(txtCorreoElectronico.Text)))
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!EsMayorDeEdad(dtpFechaNaciPa.Value))
                    return;

                Cliente Cli = new Cliente();
                Cli.Nombre = txtNombre.Text;
                Cli.Apellido = txtApellido.Text;
                Cli.Dui = txtDui.Text;
                Cli.Fecha = dtpFechaNaciPa.Value;
                Cli.Telefono = txtNumTelefono.Text;
                Cli.Email = txtCorreoElectronico.Text;

                Cli.InsertarCliente();
                MostrarCliente();

                MessageBox.Show("Se registró correctamente el cliente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el cliente: " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void MostrarCliente()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Cliente.MostrarCliente();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            MostrarCliente();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una reserva para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el idReserva de la fila seleccionada
            int idReserva = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Cliente"].Value);

            // Crear instancia y asignar propiedades desde los controles
            Cliente C = new Cliente
            {
                Id = idReserva,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtCorreoElectronico.Text,
                Fecha = dtpFechaNaciPa.Value,
                Dui = txtDui.Text,
                Telefono = txtNumTelefono.Text

            };

            // Llamar al método de actualización
            bool actualizado = C.ActualizarReserva();

            if (actualizado)
            {
                MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarCliente(); // Refresca la lista de clientes
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente Eliminar = new Cliente();
            int id = int.Parse(dgvClientes.CurrentRow.Cells[0].Value.ToString());
            string registroEliminar = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            DialogResult respueta = MessageBox.Show("¿Quieres eliminar este registro?" + registroEliminar, "Advertencia eliminaras un regsitro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respueta == DialogResult.Yes)
            {
                if (Eliminar.EliminarCliente(id) == true)
                {
                    MessageBox.Show("Se elimino correctamente el registro", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCliente();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {

                txtNombre.Text = dgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtDui.Text = dgvClientes.CurrentRow.Cells["DUI"].Value.ToString();
                txtCorreoElectronico.Text = dgvClientes.CurrentRow.Cells["Email"].Value.ToString();
                dtpFechaNaciPa.Value = Convert.ToDateTime(dgvClientes.CurrentRow.Cells["Fecha"].Value);
                txtNumTelefono.Text = dgvClientes.CurrentRow.Cells["Teléfono"].Value.ToString();

            }
        }
    }
}
