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
    public class Habitacion
    {
        public static DataTable CargarHabitaciones()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "SELECT idHabitaciones, numeroHabitacion FROM Habitacion";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaCarga = new DataTable();
            add.Fill(tablaCarga);
            return tablaCarga;
        }
    }
}
