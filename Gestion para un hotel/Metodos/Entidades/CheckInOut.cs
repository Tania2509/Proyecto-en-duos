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
    public class CheckInOut
    {

        #region buscar reservas

        public static int ObtenerReservaPorIdCliente(int idCliente)
        {
            try
            {
                SqlConnection con = Conexion.Conexion.conectar();

                string sql = @"SELECT TOP 1 R.idReserva
                       FROM Reserva R
                       INNER JOIN Cliente C ON R.id_Cliente = C.idCliente
                       WHERE C.idCliente = @idCliente AND R.id_Estado = 2";
                // 2 = En estancia (Check-In activo)

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                    return Convert.ToInt32(resultado);
                else
                    return 0; // No hay reserva activa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la reserva: " + ex.Message);
                return 0;
            }
        }

        public static DataTable BuscarReservasCheckIn(string termino)
        {
            try
            {
                SqlConnection con = Conexion.Conexion.conectar();

                string sql = $"select *from ReservaId WHERE DUI LIKE '%{termino}%' and nombreEstadoRe = 'En espera'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar reservas: " + ex.Message);
                return null;
            }
        }

        public static DataTable BuscarReservasCheckOut(string termino)
        {
            try
            {
                SqlConnection con = Conexion.Conexion.conectar();

                string sql = $"select *from ReservaId WHERE DUI LIKE '%{termino}%' and nombreEstadoRe = 'En estancia'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar reservas: " + ex.Message);
                return null;
            }
        }

        #endregion

        public static int ObtenerReserva(string duiCliente)
        {
            try
            {
                SqlConnection con = Conexion.Conexion.conectar();

                string sql = @"SELECT TOP 1 R.idReserva
                       FROM Reserva R
                       INNER JOIN Cliente C ON R.id_Cliente = C.idCliente
                       WHERE C.dui = @dui AND R.id_Estado = 2";
                // 2 = En estancia (Check-In activo)

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@dui", duiCliente);

                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                    return Convert.ToInt32(resultado);
                else
                    return 0; // No hay reserva activa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la reserva: " + ex.Message);
                return 0;
            }
        }

        public static bool RealizarCheckInPorId(int idReserva)
        {
            try
            {
                SqlConnection con = Conexion.Conexion.conectar();

                // 1️⃣ Obtener habitación asociada a la reserva
                string buscar = @"SELECT id_Habitacion 
                          FROM Reserva 
                          WHERE idReserva = @idReserva";

                SqlCommand cmdBuscar = new SqlCommand(buscar, con);
                cmdBuscar.Parameters.AddWithValue("@idReserva", idReserva);

                object resultado = cmdBuscar.ExecuteScalar();

                if (resultado == null)
                {
                    MessageBox.Show("No se encontró la reserva indicada.");
                    return false;
                }

                int idHabitacion = Convert.ToInt32(resultado);

                // 2️⃣ Cambiar el estado de la reserva a 'En estancia'
                string updateReserva = "UPDATE Reserva SET id_Estado = 2 WHERE idReserva = @idReserva";
                SqlCommand cmdUpdate = new SqlCommand(updateReserva, con);
                cmdUpdate.Parameters.AddWithValue("@idReserva", idReserva);
                cmdUpdate.ExecuteNonQuery();

                // 3️⃣ Cambiar el estado de la habitación a 'Ocupada'
                string updateHabitacion = "UPDATE Habitacion SET estadoHabitacion = 2 WHERE idHabitaciones = @idHabitacion";
                SqlCommand cmdHab = new SqlCommand(updateHabitacion, con);
                cmdHab.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                cmdHab.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar Check-In: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool RealizarCheckOut(int idReserva)
        {
            try
            {
                SqlConnection con = Conexion.Conexion.conectar();

                // Obtener habitación asociada
                string buscar = @"SELECT id_Habitacion FROM Reserva WHERE idReserva = @idReserva";
                SqlCommand cmdBuscar = new SqlCommand(buscar, con);
                cmdBuscar.Parameters.AddWithValue("@idReserva", idReserva);
                int idHabitacion = Convert.ToInt32(cmdBuscar.ExecuteScalar());

                // Cambiar estados
                string updateReserva = "UPDATE Reserva SET id_Estado = 3 WHERE idReserva = @idReserva"; 
                SqlCommand cmdUpdate = new SqlCommand(updateReserva, con);
                cmdUpdate.Parameters.AddWithValue("@idReserva", idReserva);
                cmdUpdate.ExecuteNonQuery();

                string updateHabitacion = "UPDATE Habitacion SET estadoHabitacion = 1 WHERE idHabitaciones = @idHabitacion";
                SqlCommand cmdHab = new SqlCommand(updateHabitacion, con);
                cmdHab.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                cmdHab.ExecuteNonQuery();

                // Registrar ingreso
                Ingreso.RegistrarIngreso(idReserva);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Check-Out: " + ex.Message);
                return false;
            }
        }
    }
}
