using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_assignment_1.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }

        public Contact(string firstName, string lastName, string adress, string postalCode, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
            PostalCode = postalCode;
            City = city;
        }
    }
}
