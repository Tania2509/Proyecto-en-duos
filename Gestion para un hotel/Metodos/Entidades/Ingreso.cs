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
    public class Ingreso
    {

        public static DataTable CargarIngresos()
        {
            try
            {
                SqlConnection conexion = Conexion.Conexion.conectar();
                string cadena = "select *from Ingreso";
                SqlDataAdapter data = new SqlDataAdapter(cadena, conexion);
                DataTable tablavirtual = new DataTable();
                data.Fill(tablavirtual);
                return tablavirtual;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos" + ex);
                return null;
            }
        }
        public static bool RegistrarIngreso(int idReserva)
        {
            try
            {
                using (SqlConnection con = Conexion.Conexion.conectar())
                {
                    // 1️⃣ Obtener precio de habitación
                    string sqlHabitacion = @"SELECT H.precio
                                         FROM Reserva R
                                         INNER JOIN Habitacion H ON R.id_Habitacion = H.idHabitaciones
                                         WHERE R.idReserva = @idReserva";

                    SqlCommand cmdHab = new SqlCommand(sqlHabitacion, con);
                    cmdHab.Parameters.AddWithValue("@idReserva", idReserva);
                    decimal precioHabitacion = Convert.ToDecimal(cmdHab.ExecuteScalar());

                    // 2️⃣ Calcular total de servicios
                    string sqlServicios = @"SELECT ISNULL(SUM(S.precio), 0)
                                        FROM Consumo C
                                        INNER JOIN Servicio S ON C.id_Servicio = S.idServicio
                                        WHERE C.id_Reserva = @idReserva";

                    SqlCommand cmdServ = new SqlCommand(sqlServicios, con);
                    cmdServ.Parameters.AddWithValue("@idReserva", idReserva);
                    decimal totalServicios = Convert.ToDecimal(cmdServ.ExecuteScalar());

                    decimal totalGeneral = precioHabitacion + totalServicios;

                    // 3Insertar el ingreso
                    string sqlInsert = @"INSERT INTO Ingreso (id_Reserva, fecha, habitación, servicio, general)
                                     VALUES (@idReserva, GETDATE(), @montoHabitacion, @montoServicios, @montoTotal)";

                    SqlCommand cmdInsert = new SqlCommand(sqlInsert, con);
                    cmdInsert.Parameters.AddWithValue("@idReserva", idReserva);
                    cmdInsert.Parameters.AddWithValue("@montoHabitacion", precioHabitacion);
                    cmdInsert.Parameters.AddWithValue("@montoServicios", totalServicios);
                    cmdInsert.Parameters.AddWithValue("@montoTotal", totalGeneral);
                    cmdInsert.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar ingreso: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
