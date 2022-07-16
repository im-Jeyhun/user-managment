using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_managment.DataBase.Models
{
    internal class User
    {
        private static DateTime RegistrationDate = DateTime.Now;
        private static int id = 1;
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public User(string name, string lastName, string email, string password)
        {
            RegistrationDate;
            Id = id++;
            Name = name;
            LastName = lastName;
            Email = email;
            Password = password;
        }
    }
}
