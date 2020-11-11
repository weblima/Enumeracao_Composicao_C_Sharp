
using System;

namespace Orders.Entities {
    class Clients {
        public string Name { get; set; }
        public string Email { get; set; }
        public  DateTime BirthDate { get; set; }

        public Clients(string name, string email, DateTime birthDate) {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
