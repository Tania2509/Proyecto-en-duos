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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vistas.Vistas
{
    public partial class frmServicios : Form
    {
        public frmServicios()
        {
            InitializeComponent();
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {
            CargarServicio();
        }

        public void CargarServicio()
        {
            dgvServicios.DataSource = null;
            dgvServicios.DataSource = Servicio.MostrarServicios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de campos vacíos
                if ((string.IsNullOrWhiteSpace(txtdescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text)))

                {
                    MessageBox.Show("No puedes dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtdescripcion.Focus();
                    return;
                }
                // Crear objeto Reserva y asignar valores
                Servicio S = new Servicio();

                S.NombreServicio = txtNombre.Text;
                S.Descripcion = txtdescripcion.Text;
                S.Precio = Convert.ToDouble(txtPrecio.Text);

                // Insertar la reserva
                S.InsertarServicio();
                CargarServicio();

                MessageBox.Show("Se registró correctamente el servicio", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar e servicio: " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Selecciona la linea completa
            if (dgvServicios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un servicio para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el IDSERVICIO de la fila seleccionada
            int idServicio = Convert.ToInt32(dgvServicios.SelectedRows[0].Cells["Servicio"].Value);

            // Crear instancia y asignar propiedades desde los controles
            Servicio S = new Servicio
            {
                Id = idServicio,
                Descripcion = txtdescripcion.Text,
                NombreServicio = txtNombre.Text,
                Precio = double.Parse(txtPrecio.Text)
            };

            // Llamar al método de actualización
            bool actualizado = S.ActualizarServicio();

            if (actualizado)
            {
                MessageBox.Show("Servicio actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarServicio(); // Refresca la lista de reservas
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el servicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Servicio Eliminar = new Servicio();
            int id = int.Parse(dgvServicios.CurrentRow.Cells["Servicio"].Value.ToString());
            string registroEliminar = dgvServicios.CurrentRow.Cells[1].Value.ToString();
            DialogResult respueta = MessageBox.Show("¿Quieres eliminar este registro?" + registroEliminar, "Advertencia eliminaras un registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respueta == DialogResult.Yes)
            {
                if (Eliminar.EliminarServicio(id) == true)
                {
                    MessageBox.Show("Se elimino correctamente el registro", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarServicio();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void dgvServicios_DoubleClick(object sender, EventArgs e)
        {
            if (dgvServicios.CurrentRow != null)
            {

                txtNombre.Text = dgvServicios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtdescripcion.Text = dgvServicios.CurrentRow.Cells["Descripción"].Value.ToString();
                txtPrecio.Text = dgvServicios.CurrentRow.Cells["Precio"].Value.ToString();

            }
        }
    }
}