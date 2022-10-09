using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignment_1.Models
{
    public class Contact
    {
        public Contact()
        {
            Id = Guid.NewGuid();
            FirstName = null!;
            LastName = null!;
            Email = null!;
        }

        public Contact(Guid id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        // Lägger till properties
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }







    }
}
