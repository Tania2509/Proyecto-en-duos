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
    public class Pago
    {
        public static DataTable CargarMetodosPago()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "SELECT idPago, nombreMetodo FROM MetodoPago";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaCarga = new DataTable();
            add.Fill(tablaCarga);
            return tablaCarga;
        }
    }
}
