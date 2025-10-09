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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        frnGestionReservas GestionReservas = new frnGestionReservas();
        frnConsumos Consumos = new frnConsumos();
        frnIngresos Ingresos = new frnIngresos();
        frnCheckIn CheckIn;
        frnCheckOut CheckOut;


        private void lblCheckIn_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(CheckIn);
        }

        private void lblCheckOut_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(CheckOut);
        }

        private void lblGestionReserva_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(GestionReservas);
        }

        private void frmDashboard_Load_1(object sender, EventArgs e)
        {
            CheckIn = new frnCheckIn(GestionReservas);
            CheckOut = new frnCheckOut(GestionReservas);
        }

        private void lblConsumos_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(Consumos);
        }

        private void lblIngresos_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(Ingresos);
        }
    }
}
