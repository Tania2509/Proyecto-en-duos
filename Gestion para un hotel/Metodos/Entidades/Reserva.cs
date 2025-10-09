using Metodos.Conexion;
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
    public class Reserva
    {
        private int idReserva;
        private DateTime fechaEntrada;
        private DateTime fechaSalida;
        private int idEstado;
        private int idPago;
        private int idCliente;
        private int idHabitacion;
        private int cantidad;

        public int IdReserva { get => idReserva; set => idReserva = value; }
        public DateTime FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public int IdEstado { get => idEstado; set => idEstado = value; }
        public int IdPago { get => idPago; set => idPago = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }


        public static DataTable CargarReservas()
        {
            try
            {
                SqlConnection conexion = Conexion.Conexion.conectar();
                string cadena = "select *from Reservaciones;";
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

        public bool InsertarReserva()
        {
            try
            {
                // Siempre traer la conexión
                SqlConnection conexion = Conexion.Conexion.conectar();
                string consultaQuery = @"INSERT INTO Reserva (cantidadReserva, fechaEntrada, fechaSalida, id_Estado, id_Pago, id_Habitacion, id_Cliente) 
                            VALUES (@Cantidad, @FechaEntrada, @FechaSalida, 1, @IdPago, @IdHabitacion, @IdCliente)";
                //En la insercion de estado, se pone 1 porque es el estado "En espera" y es el que siempre se asigna al crear una nueva reserva

                SqlCommand insertar = new SqlCommand(consultaQuery, conexion);

                // Insertar o sustituir los parámetros con los datos
                insertar.Parameters.AddWithValue("@Cantidad", cantidad);
                insertar.Parameters.AddWithValue("@FechaEntrada", fechaEntrada);
                insertar.Parameters.AddWithValue("@FechaSalida", fechaSalida);
                insertar.Parameters.AddWithValue("@IdPago", idPago);
                insertar.Parameters.AddWithValue("@IdHabitacion", idHabitacion);
                insertar.Parameters.AddWithValue("@IdCliente", idCliente);

                insertar.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifica si la consulta de insertar está correcta: " + ex.Message, "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool eliminarReserva(int id)
        {

            try
            {
                SqlConnection conexion = Conexion.Conexion.conectar();
                string consultaDelete = "delete from Reserva where idReserva = @Id";
                SqlCommand delete = new SqlCommand(consultaDelete, conexion);
                delete.Parameters.AddWithValue("@Id", id);
                delete.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ActualizarReserva()
        {
            try
            {
                SqlConnection con = Conexion.Conexion.conectar();
                string comando = @"UPDATE Reserva SET 
                          cantidad = @cantidad, 
                          fechaEntrada = @fechaEntrada, 
                          fechaSalida = @fechaSalida, 
                          id_Pago = @id_Pago, 
                          id_Habitacion = @id_Habitacion, 
                          id_Cliente = @id_Cliente 
                          WHERE idReserva = @idReserva";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@idReserva", IdReserva);
                cmd.Parameters.AddWithValue("@cantidad", Cantidad);
                cmd.Parameters.AddWithValue("@fechaEntrada", FechaEntrada);
                cmd.Parameters.AddWithValue("@fechaSalida", FechaSalida);
                cmd.Parameters.AddWithValue("@id_Pago", IdPago);
                cmd.Parameters.AddWithValue("@id_Habitacion", IdHabitacion);
                cmd.Parameters.AddWithValue("@id_Cliente", IdCliente);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la reserva: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        

        
         public static int CapacidadHabitacion(int idHabitacion)
         {
            try
            {
                SqlConnection con = Conexion.Conexion.conectar();
                string query = "SELECT cantidad FROM Habitacion WHERE idHabitaciones = @idHabitacion";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idHabitacion", idHabitacion);

                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener capacidad de habitación: " + ex.Message);
                return 0;
            }
         }
    }
}
