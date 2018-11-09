using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class entUsuario
    {
        //Los nombres son exactamente igual a los de la BD para no tener problemas.
        public int idUser { get; set; }
        public String Name { get; set; }
        public String LastName { get; set; }
        public String User { get; set; }
        public String Password { get; set; }
    }
}
