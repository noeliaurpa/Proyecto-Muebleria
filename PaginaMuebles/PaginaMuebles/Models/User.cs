using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginaMuebles.Models
{
    public class User
    {
        public int idUser { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}