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
        public static DataTable CargarClientes()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "SELECT idCliente, nombreCli, apellidoCli, duiCli FROM Cliente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaCarga = new DataTable();
            add.Fill(tablaCarga);
            return tablaCarga;
        }

        public static DataTable MostrarClientes()
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

    }
}
