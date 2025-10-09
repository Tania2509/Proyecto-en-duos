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

    public class Habitacion
    {
        private int id;
        private string numeroHabitacion;
        private double precio;
        private int cantidad;

        public string NumeroHabitacion { get => numeroHabitacion; set => numeroHabitacion = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id { get => id; set => id = value; }

        public static DataTable CargarHabitaciones()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "SELECT idHabitaciones, numeroHabitacion FROM Habitacion";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaCarga = new DataTable();
            add.Fill(tablaCarga);
            return tablaCarga;
        }

        public static DataTable MostrarHabitaciones()
        {
            try
            {
                SqlConnection conexion = Conexion.Conexion.conectar();
                string cadena = "select *from Habitacion;";
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

        public bool InsertarHabitación()
        {
            try
            {
                // Siempre traer la conexión
                SqlConnection conexion = Conexion.Conexion.conectar();
                string consultaQuery = @"INSERT INTO Habitacion (cantidad, precio, numeroHabitacio, estadoHabitacion) 
                            VALUES (@Cantidad, @precio,@numeroHabitacio, 1)";
                //En la insercion de estado, se pone 1 porque es el estado "En espera" y es el que siempre se asigna al crear una nueva reserva

                SqlCommand insertar = new SqlCommand(consultaQuery, conexion);

                // Insertar o sustituir los parámetros con los datos
                insertar.Parameters.AddWithValue("@Cantidad", cantidad);
                insertar.Parameters.AddWithValue("@precio", precio );
                insertar.Parameters.AddWithValue("@numeroHabitacio", numeroHabitacion);


                insertar.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifica si la consulta de insertar está correcta: " + ex.Message, "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool EliminarHabitacion(int id)
        {

            try
            {
                SqlConnection conexion = Conexion.Conexion.conectar();
                string consultaDelete = "delete from Habitacion where idHabitaciones = @Id";
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
                string comando = @"UPDATE Habitacion SET 
                          numeroHabitacion = @numeroHabitacion, 
                          precio = @precio, 
                          cantidad = @cantidad
                          WHERE idHabitaciones = @idReserva";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@numeroHabitacion", numeroHabitacion);
                cmd.Parameters.AddWithValue("@cantidad", Cantidad);
                cmd.Parameters.AddWithValue("@precio", Precio);

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
    }
}
