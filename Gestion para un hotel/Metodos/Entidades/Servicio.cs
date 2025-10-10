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
    public class Servicio
    {
        private double precio;
        private string descripcion;
        private string nombreServicio;
        private int id;

        public double Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string NombreServicio { get => nombreServicio; set => nombreServicio = value; }
        public int Id { get => id; set => id = value; }

        public static DataTable MostrarServicios()
        {
            try
            {
                SqlConnection conexión = Conexion.Conexion.conectar();
                String cadena = "select *from Servicios;";
                SqlDataAdapter data = new SqlDataAdapter(cadena, conexión);
                DataTable tablavirtual = new DataTable();
                data.Fill(tablavirtual);
                return tablavirtual;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar datos" +ex);
                return null;
            }
        }


        public bool InsertarServicio()
        {
            try
            {
                // Siempre traer la conexión
                SqlConnection conexión = Conexion.Conexion.conectar();
                String consultaQuery = @"insert into Servicio(nombreServicio, precio, descripcion)
                            VALUES(@nombreServicio, @precio, @descripcion)";
                SqlCommand insertar = new SqlCommand(consultaQuery, conexión);

                // Insertar o sustituir los parámetros con los datos
                insertar.Parameters.AddWithValue("@nombreServicio", nombreServicio);
                insertar.Parameters.AddWithValue("@precio", precio);
                insertar.Parameters.AddWithValue("@descripcion", descripcion);


                insertar.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Verifica si la consulta de insertar está correcta:" +ex.Message, "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool EliminarServicio(int id)
        {

            try
            {
                SqlConnection conexión = Conexion.Conexion.conectar();
                String consultaDelete = "delete from Servicio where idServicio = @Id";
                SqlCommand delete = new SqlCommand(consultaDelete, conexión);
                delete.Parameters.AddWithValue("@Id", id);
                delete.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool ActualizarServicio()
        {
            try
            {
                SqlConnection con = Conexion.Conexion.conectar();
                String comando = @"UPDATE Servicio SET
                          nombreServicio = @nombreServicio,
                          precio = @precio,
                          descripcion = @descripcion
                          WHERE idServicio = @idServicio";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@idServicio", id);
                cmd.Parameters.AddWithValue("@nombreServicio", nombreServicio);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                int filasAfectadas = cmd.ExecuteNonQuery();

                if(filasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al actualizar la reserva: " +ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
