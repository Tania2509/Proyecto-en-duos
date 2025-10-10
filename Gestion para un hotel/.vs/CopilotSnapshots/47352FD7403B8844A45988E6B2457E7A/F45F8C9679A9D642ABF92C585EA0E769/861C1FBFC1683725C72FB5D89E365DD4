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
    public partial class frnCheckIn : UserControl
    {
        private frnGestionReservas gestionReservas;

        public frnCheckIn(frnGestionReservas gestionReservas)
        {
            InitializeComponent();
            this.gestionReservas = gestionReservas;
            CheckOut = new frnCheckOut(gestionReservas);
        }

        private frnCheckOut CheckOut;

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una reserva para realizar el Check-In.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idReserva = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["idReserva"].Value);

            bool resultado = CheckInOut.RealizarCheckInPorId(idReserva);

            if (resultado)
            {
                MessageBox.Show("Check-In realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gestionReservas.CargarReserva();
                MostrarEspera();
                CheckOut.MostrarEstancia();
            }
            else
            {
                MessageBox.Show("No se pudo completar el Check-In.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frnCheckIn_Load(object sender, EventArgs e)
        {
            MostrarEspera();
        }
        public void MostrarEspera()
        {
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = CheckInOut.MostrarReservasCheckIN();
        }
    }

 
}
