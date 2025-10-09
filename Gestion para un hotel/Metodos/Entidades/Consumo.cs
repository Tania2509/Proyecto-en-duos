using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos.Entidades
{
    public class Consumo
    {

        public static DataTable CargarServicios()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "SELECT idServicio, nombreServicio FROM Servicio";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaCarga = new DataTable();
            add.Fill(tablaCarga);
            return tablaCarga;
        }         

        public static bool InsertarConsumo(int idReserva, int idServicio)
        {
            try
            {
                using (SqlConnection con = Conexion.Conexion.conectar())
                {
                    string sql = @"INSERT INTO Consumo (id_Reserva, id_Servicio, fecha)
                           VALUES (@idReserva, @idServicio, GETDATE())";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idReserva", idReserva);
                    cmd.Parameters.AddWithValue("@idServicio", idServicio);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar consumo: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
