using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        public SqlConnection conectar()
        {
            SqlConnection coneccion = new SqlConnection();
            coneccion.ConnectionString = "Data Source=(nombre del servidor de la base de datos); Initial Catalog=(nombre de la base de datos); Integrated Security = true";
            return coneccion;
        }
    }
}
