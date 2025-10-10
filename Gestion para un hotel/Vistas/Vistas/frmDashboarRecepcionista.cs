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
    public partial class frmDashboarRecepcionista : Form
    {
        public frmDashboarRecepcionista()
        {
            InitializeComponent();
            gestionReservasInstance = new frnGestionReservas();
            GestionReservas = new frnReservasRecepcionista(gestionReservasInstance);
        }

        frnGestionReservas gestionReservasInstance;
        frnReservasRecepcionista GestionReservas;
        frnCheckIn CheckIn;
        frnCheckOut CheckOut;

        private void lblGestionReserva_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(GestionReservas);
        }

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
    }
}
