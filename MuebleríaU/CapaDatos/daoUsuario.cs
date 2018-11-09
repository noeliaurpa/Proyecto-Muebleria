using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class daoUsuario
    {
        public  static entUsuario Login(String user, String password)
        {
            entUsuario objectUser = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                Conexion cn = new Conexion();
                SqlConnection cnsql = cn.conectar();
                cmd = new SqlCommand("(nombre del proceso almacenado que se creo en la BD)",cnsql);
                cmd.Parameters.AddWithValue("@Username", user);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.CommandType = CommandType.StoredProcedure;
                cnsql.Open();
                dr = cmd.ExecuteReader();
                objectUser = new entUsuario();
                dr.Read();
                objectUser.idUser = Convert.ToInt32(dr["idUser"].ToString());
                objectUser.Name = dr["Name"].ToString();
                objectUser.LastName = dr["LastName"].ToString();
                objectUser.User = dr["User"].ToString();
                objectUser.Password = dr["Password"].ToString();
            }
            catch (Exception)
            {
                objectUser = null;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return objectUser;
        }
    }
}
