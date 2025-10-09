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
    public partial class frnIngresos : UserControl
    {
        public frnIngresos()
        {
            InitializeComponent();
        }

        public void CargarIngresos()
        {
            dgvIngresos.DataSource = null;
            dgvIngresos.DataSource = Reserva.CargarReservas();
        }

        private void frnIngresos_Load(object sender, EventArgs e)
        {
            CargarIngresos();
        }
    }
}
