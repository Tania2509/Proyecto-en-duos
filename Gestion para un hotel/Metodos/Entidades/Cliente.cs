using Metodos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
