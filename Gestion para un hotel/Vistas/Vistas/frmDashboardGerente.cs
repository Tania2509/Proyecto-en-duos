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
    public partial class frmDashboardGerente : Form
    {
        public frmDashboardGerente()
        {
            InitializeComponent();
        }

        frnIngresos ingresos;

        private void lblIngresos_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(ingresos);
        }
    }
}
