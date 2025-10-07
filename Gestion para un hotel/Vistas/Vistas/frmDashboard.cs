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

        #region

        private Form activarForm = null;
        //Creando el metodo que me va permitir activar los formularios

        private void AbrirForm(Form formularioPintar)
        {
            if (activarForm != null)
            {
                //esto detecta si hay un formulario abierto
                activarForm.Close();
            }

            activarForm = formularioPintar;
            formularioPintar.TopLevel = false;

            formularioPintar.FormBorderStyle = FormBorderStyle.None;
            formularioPintar.Dock = DockStyle.Fill;

            pnlPrincipal.Controls.Add(formularioPintar);
            formularioPintar.BringToFront();
            formularioPintar.Show();
        }

        #endregion

    }
}
