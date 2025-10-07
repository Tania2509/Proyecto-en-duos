using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos.Entidades
{
    public class CheckInOut
    {

        public bool RealizarCheckIn(string duiCliente)
        {
            try
            {
                SqlConnection con = Conexion.Conexion.conectar();

                // 1. Buscar reserva activa del cliente
                string buscar = @"SELECT TOP 1 R.idReserva, R.id_Habitacion 
                          FROM Reserva R
                          INNER JOIN Cliente C ON R.id_Cliente = C.idCliente
                          WHERE C.dui = @dui AND R.id_Estado = 1"; // 1 = En espera

                SqlCommand cmdBuscar = new SqlCommand(buscar, con);
                cmdBuscar.Parameters.AddWithValue("@dui", duiCliente);

                SqlDataReader dr = cmdBuscar.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("No hay reservas pendientes para este cliente.");
                    return false;
                }

                int idReserva = Convert.ToInt32(dr["idReserva"]);
                int idHabitacion = Convert.ToInt32(dr["id_Habitacion"]);
                dr.Close();

                // 2. Actualizar reserva y habitación
                string actualizarReserva = "UPDATE Reserva SET id_Estado = 2 WHERE idReserva = @idReserva"; // 2 = En estancia
                string actualizarHabitacion = "UPDATE Habitacion SET estado = 'Ocupada' WHERE idHabitacion = @idHabitacion";
                SqlCommand cmdHab = new SqlCommand(actualizarHabitacion, con);
                SqlCommand cmdReserva = new SqlCommand(actualizarReserva, con);
                cmdReserva.Parameters.AddWithValue("@idReserva", idReserva);
                cmdHab.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                cmdReserva.ExecuteNonQuery();

                MessageBox.Show("Check-In realizado correctamente.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar Check-In: " + ex.Message);
                return false;
            }
        }
        
        public bool RealizarCheckOut(string duiCliente)
        {
            try
            {
                SqlConnection con = Conexion.Conexion.conectar();

                // 1. Buscar reserva en estancia
                string buscar = @"SELECT TOP 1 R.idReserva, R.id_Habitacion, H.precio 
                          FROM Reserva R
                          INNER JOIN Habitacion H ON R.id_Habitacion = H.idHabitacion
                          INNER JOIN Cliente C ON R.id_Cliente = C.idCliente
                          WHERE C.dui = @dui AND R.id_Estado = 2"; // 2 = En estancia

                SqlCommand cmdBuscar = new SqlCommand(buscar, con);
                cmdBuscar.Parameters.AddWithValue("@dui", duiCliente);

                SqlDataReader leer = cmdBuscar.ExecuteReader();
                if (!leer.Read())
                {
                    MessageBox.Show("No hay check-in activo para este cliente.");
                    return false;
                }

                int idReserva = Convert.ToInt32(leer["idReserva"]);
                int idHabitacion = Convert.ToInt32(leer["id_Habitacion"]);
                decimal precioHab = Convert.ToDecimal(leer["precio"]);
                leer.Close();

                // 2. Calcular total habitación 
                decimal totalHabitacion = precioHab;
                decimal totalServicios = CalcularTotalServicios(idReserva);
                decimal totalGeneral = totalHabitacion + totalServicios;

                // 3. Registrar ingreso
                string ingreso = @"INSERT INTO Ingresos (idReserva, totalHabitacion, totalServicios, totalGeneral, fecha)
                           VALUES (@idReserva, @totalHab, @totalServ, @totalGen, GETDATE())";
                SqlCommand cmdIngreso = new SqlCommand(ingreso, con);
                cmdIngreso.Parameters.AddWithValue("@idReserva", idReserva);
                cmdIngreso.Parameters.AddWithValue("@totalHab", totalHabitacion);
                cmdIngreso.Parameters.AddWithValue("@totalServ", totalServicios);
                cmdIngreso.Parameters.AddWithValue("@totalGen", totalGeneral);
                cmdIngreso.ExecuteNonQuery();

                // 4. Actualizar estados
                string actualizarReserva = "UPDATE Reserva SET id_Estado = 3 WHERE idReserva = @idReserva"; // 3 = Completada
                SqlCommand cmdReserva = new SqlCommand(actualizarReserva, con);
                cmdReserva.Parameters.AddWithValue("@idReserva", idReserva);
                cmdReserva.ExecuteNonQuery();

                string actualizarHabitacion = "UPDATE Habitacion SET estado = 'Disponible' WHERE idHabitacion = @idHabitacion";
                SqlCommand cmdHab = new SqlCommand(actualizarHabitacion, con);
                cmdHab.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                cmdHab.ExecuteNonQuery();

                MessageBox.Show($"Check-Out realizado. Total: ${totalGeneral}");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar Check-Out: " + ex.Message);
                return false;
            }
        }

        // Método auxiliar (puedes ajustarlo)
        private decimal CalcularTotalServicios(int idReserva)
        {
            SqlConnection con = Conexion.Conexion.conectar();
            string sql = @"SELECT ISNULL(SUM(S.precio), 0) 
                   FROM ServiciosConsumidos SC 
                   INNER JOIN Servicio S ON SC.id_Servicio = S.idServicio 
                   WHERE SC.id_Reserva = @idReserva";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@idReserva", idReserva);
            return Convert.ToDecimal(cmd.ExecuteScalar());
        }
    }
}
