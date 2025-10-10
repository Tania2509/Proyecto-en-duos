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
    public class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private string dui;
        private DateTime fecha;
        private string telefono;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dui { get => dui; set => dui = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }

        public static DataTable CargarClientes()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "SELECT idCliente, nombreCli, apellidoCli, duiCli FROM Cliente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaCarga = new DataTable();
            add.Fill(tablaCarga);
            return tablaCarga;
        }

        public static DataTable MostrarClientesEstancia()
        {
            try
            {
                SqlConnection conexion = Conexion.Conexion.conectar();
                string cadena = "select *from ClientesReservas where Estado = 'En estancia';";
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

        public static DataTable MostrarCliente()
        {
            try
             {
                SqlConnection conexión = Conexion.Conexion.conectar();
                String cadena = "select* from Clientes;";
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

        public bool InsertarCliente()
        {
            try
            {
                // Siempre traer la conexión
                SqlConnection conexión = Conexion.Conexion.conectar();
                String consultaQuery = @"INSERT INTO Cliente(nombreCli, apellidoCli, duiCli, fechaNacimientoCli, telefono, Email)
                            VALUES(@nombreCli, @apellidoCli, @duiCli, @fechaNacimientoCli, @telefono, @Email)";

                SqlCommand insertar = new SqlCommand(consultaQuery, conexión);

                // Insertar o sustituir los parámetros con los datos
                insertar.Parameters.AddWithValue("@nombreCli", nombre);
                insertar.Parameters.AddWithValue("@apellidoCli", apellido);
                insertar.Parameters.AddWithValue("@duiCli", dui);
                insertar.Parameters.AddWithValue("@fechaNacimientoCli", fecha);
                insertar.Parameters.AddWithValue("@telefono", telefono);
                insertar.Parameters.AddWithValue("@Email", email);

                insertar.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Verifica si la consulta de insertar está correcta:" +ex.Message, "Error al insertar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool EliminarCliente(int id)
        {

            try
            {
                SqlConnection conexión = Conexion.Conexion.conectar();
                String consultaDelete = "delete from Cliente where idCliente = @Id";
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

        public bool ActualizarReserva()
        {
            try
            {
                SqlConnection con = Conexion.Conexion.conectar();
                String comando = @"UPDATE Cliente SET
                          nombreCli = @nombreCli, apellidoCli = @apellido,
              duiCli = @dui, fechaNacimientoCli = @fecha,
              telefono = @telefono, Email = @email
                          WHERE idCliente = @idCliente";

                SqlCommand cmd = new SqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@idCliente", id);
                cmd.Parameters.AddWithValue("@nombreCli", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@dui", dui);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@email", email);

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
                MessageBox.Show("Error al actualizar el cliente: " +ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }




    }
}
