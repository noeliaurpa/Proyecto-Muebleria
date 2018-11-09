using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class negUsuario
    {
        public static entUsuario Login(String user, String password)
        {
            return daoUsuario.Login(user, password);
        }
    }
}
