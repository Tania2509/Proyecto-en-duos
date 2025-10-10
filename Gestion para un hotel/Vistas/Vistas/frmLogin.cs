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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
    

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtContraseña.Text)))
            {
                Usuario usuario = new Usuario();
                if (usuario.VerificarLogin(txtNombre.Text, txtContraseña.Text))
                {
                    Program.RolUsuario = usuario.ObtenerRol(txtNombre.Text);
                    RedirigirPorRol(Program.RolUsuario);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor llena los campos requeridos");
            }
        }

        public void RedirigirPorRol(string rol)
        {
            Form formulario = null;
            switch (rol)
            {
                case "1":
                    formulario = new frmDashboard();
                    break;
                case "2":
                    formulario = new frmDashboarRecepcionista();
                    break;
                case "3":
                    formulario = new frmClientes();
                    break;
                // Agrega más roles y formularios según tu necesidad
                default:
                    MessageBox.Show("Rol no reconocido.");
                    return;
            }
            formulario.Show();
        }
    }
}

