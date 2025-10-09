using Metodos.Conexion;
using Metodos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Vistas
{
    public partial class frnConsumos : UserControl
    {
        private int idClienteSeleccionado = 0;

        public frnConsumos()
        {
            InitializeComponent();
        }

        #region Combobox

        private void CargarServicios()
        {
            // Cargar servicios
            cbServicios.DataSource = null;
            cbServicios.DataSource = Consumo.CargarServicios();
            cbServicios.DisplayMember = "nombreServicio";
            cbServicios.ValueMember = "idServicio";
            cbServicios.SelectedIndex = -1;
        }

        #endregion

        private void CargarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Cliente.MostrarClientes();
        }

        private void frnConsumos_Load(object sender, EventArgs e)
        {
            CargarServicios();
            CargarClientes();
            dgvClientes.CellClick += dgvClientes_CellClick_1;
            CargarTodosConsumos(); // Mostrar todos los consumos al cargar
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar la reserva activa del cliente usando el idCliente
            int idReserva = CheckInOut.ObtenerReservaPorIdCliente(idClienteSeleccionado); // Cambiar método para obtener un int
            if (idReserva == 0)
            {
                MessageBox.Show("El cliente no tiene una reserva activa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idServicio = Convert.ToInt32(cbServicios.SelectedValue);

            bool resultado = Consumo.InsertarConsumo(idReserva, idServicio);

            if (resultado)
            {
                MessageBox.Show("Consumo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarConsumos(idReserva);
            }
        }

        private void CargarConsumos(int idReserva)
        {
            SqlConnection con = Metodos.Conexion.Conexion.conectar();
            string sql = @"SELECT C.idConsumo, S.nombreServicio, S.precio, C.fecha
                       FROM Consumo C
                       INNER JOIN Servicio S ON C.id_Servicio = S.idServicio
                       WHERE C.id_Reserva = @idReserva";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@idReserva", idReserva);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvConsumos.DataSource = dt;
        }

        private void CargarTodosConsumos()
        {
            SqlConnection con = Metodos.Conexion.Conexion.conectar();
            string sql = @"SELECT idConsumo, nombreServicio, precio, fecha, id_Reserva, nombreCli, apellidoCli
                           FROM Consumo C
                           INNER JOIN Servicio S ON C.id_Servicio = S.idServicio
                           INNER JOIN Reserva R ON C.id_Reserva = R.idReserva
                           INNER JOIN Cliente Cl ON R.id_Cliente = Cl.idCliente";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvConsumos.DataSource = dt;
        }

        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idClienteSeleccionado = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["Cliente"].Value);
            }
            else
            {
                MessageBox.Show("No hay datos");
            }
        }
    }
}


