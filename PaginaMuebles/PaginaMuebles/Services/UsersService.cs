using PaginaMuebles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginaMuebles.Services
{
    public class UsersService
    {
        public User GetUser()
        {
            return new User()
            {
                idUser = 1,
                Name = "Juan",
                Lastname = "Chavez",
                Username = "Juancha",
                Password = "123456"
            };
        }

        public List<User> GetUsers()
        {
            var user1 = new User()
            {
                idUser = 2,
                Name = "Karla",
                Lastname = "Fenandez",
                Username = "Karfer",
                Password = "123456"
            };
            var user2 = new User()
            {
                idUser = 3,
                Name = "Maria",
                Lastname = "Lopez",
                Username = "marilopez",
                Password = "mari123"
            };

            return new List<User> { user1, user2 };
        }
    }
}