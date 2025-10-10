using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos.Entidades
{
    public class Usuario
    {

        public bool VerificarLogin(string correo, string clave)
        {

            string hashEnBaseDeDatos = "";
            SqlConnection conn = Conexion.Conexion.conectar();
            string query = "SELECT contrasena FROM Usuario WHERE nombreUsu = @nombreUsu";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@nombreUsu", correo);
            MessageBox.Show("executescalar" + cmd.ExecuteScalar());

            if (cmd.ExecuteScalar() == null)
            {
                return false;
            }
            else
            {
                hashEnBaseDeDatos = cmd.ExecuteScalar().ToString();
                return BCrypt.Net.BCrypt.Verify(clave, hashEnBaseDeDatos);
            }
        }

        public string ObtenerRol(string correo)
        {
            string rol = "";
            using (SqlConnection conn = Conexion.Conexion.conectar())
            {
                string query = "SELECT id_Rol FROM Usuario WHERE nombreUsu = @nombreUsu";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombreUsu", correo);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                        rol = result.ToString();
                }
            }
            return rol;
        }
    }
}
