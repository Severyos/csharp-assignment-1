using csharp_assignment_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp_assignment_1.Helpers
{
    internal class MenuHelper
    {
        public List<Contact> contacts = new List<Contact>();

        // Skapar kontakt
        public void Create()
        {
            Console.Clear();
            var contact = new Contact();
            Console.WriteLine("##### CREATE NEW CONTACT #####");
            Console.Write("First Name:  ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Last Name:  ");
            contact.LastName = Console.ReadLine();
            Console.Write("Email:  ");
            contact.Email = Console.ReadLine();
            Console.Write("Adress:  ");
            contact.Adress = Console.ReadLine();
            contacts.Add(contact);
        }

        // Lista på kontakter
        public void Listcontact()
        {   
            Console.Clear();
            foreach (var contact in contacts)
                Console.WriteLine($"{contact.Id} - {contact.FirstName} {contact.LastName}");
            Console.ReadKey();
        }

        // Lista i menyn med olika alternativ
        public void MenuOptions()
        {
            Console.Clear();
            Console.WriteLine("##### ADDRESSBOOK #####");
            Console.WriteLine("1. Create new contact");
            Console.WriteLine("2. View contact list");
            Console.WriteLine("3. View detailed contact");
            Console.WriteLine("4. Update contact");
            Console.WriteLine("5. Remove contact");
            Console.WriteLine("Q. Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    Create();
                    break;

                case "2":
                    Listcontact();
                    break;

                case "3":
                    ViewDetails();
                    break;

                case "4":
                    UpdateContact();
                    break;

                case "5":
                    RemoveContact();
                    break;

                case "Q":
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
        }

        // Detaljerad information av en kontakt
        public void ViewDetails()
        {
            Console.Clear();
            Console.Write("Enter Id:  ");
            var id = Guid.Parse(Console.ReadLine());
            var contact = contacts.FirstOrDefault(x => x.Id == id);

            Console.WriteLine($"First name: {contact.FirstName}");
            Console.WriteLine($"Last name: {contact.LastName}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Adress: {contact.Adress}");
        }

        // Metod för att uppdatera en kontakt
        public void UpdateContact()
        {
            Console.Clear();
            Console.Write("Enter Id:  ");
            var id = Guid.Parse(Console.ReadLine());
            var contact = contacts.FirstOrDefault(x => x.Id == id);

            Console.Write("First name:  ");
            var firstName = Console.ReadLine();
            if (!string.IsNullOrEmpty(firstName))
                contact.FirstName = firstName;

            Console.Write("Last Name:  ");
            var lastName = Console.ReadLine();
            if (!string.IsNullOrEmpty(lastName))
                contact.LastName = lastName;

            Console.Write("Email:  ");
            var email = Console.ReadLine();
            if (!string.IsNullOrEmpty(email))
                contact.Email = email;

            Console.Write("Adress:  ");
            var adress = Console.ReadLine();
            if (!string.IsNullOrEmpty(adress))
                contact.Adress = adress;

        }

        // Metod för att ta bort en kontakt
        public void RemoveContact()
        {
            Console.Clear();
            Console.Write("Enter Id:  ");
            var id = Guid.Parse(Console.ReadLine());
            var contact = contacts.FirstOrDefault(x => x.Id == id);
            contacts.Remove(contact);


        }

      


    }
}
    
       
            
            
            
           


            
                            
                   
              
           
        

       
       
 
