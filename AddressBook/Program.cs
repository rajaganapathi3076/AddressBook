using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the AddressBook UC2");
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("Address Book Menu:");
                Console.WriteLine("1.Add Contact\n2.View All Contact \n3.Exit");
                
                Console.Write("Enter your Choice : ");
                string Choice= Console.ReadLine();

                switch(Choice)
                {
                    case "1":
                        Console.WriteLine("Enter Name:  ");
                        string Name= Console.ReadLine();
                        Console.WriteLine("Enter Address:  ");
                        string Address = Console.ReadLine();
                        Console.WriteLine("Enter City:  ");
                        string City = Console.ReadLine();
                        Console.WriteLine("Enter State:  ");
                        string State = Console.ReadLine();
                        Console.WriteLine("Enter Zipcode:  ");
                        int Zipcode = Convert.ToInt32 ( Console.ReadLine());
                        Console.WriteLine("Enter Phonenumber:  ");
                        long Phonenumber = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter Email:  ");
                        string Email = Console.ReadLine();

                        Contact newContact= new Contact();
                        {
                            newContact.Name = Name;
                            newContact.Address = Address;
                            newContact.City = City;
                            newContact.State = State;
                            newContact.Zipcode = Zipcode;
                            newContact.PhoneNumber = Convert.ToInt64( Phonenumber);
                            newContact.Email = Email;

                        }
                        addressBook.AddContact(newContact);
                        Console.WriteLine("Contact added successfully!");
                        break;
                    case "2":
                        List<Contact> contacts = addressBook.GetAllContacts();
                        if (contacts.Count > 0)
                        {
                            Console.WriteLine("All Contacts :");

                            foreach(Contact contact in contacts)
                            {
                                Console.WriteLine($"Name:  {contact.Name}");
                                Console.WriteLine($"Address :  {contact.Address}");
                                Console.WriteLine($"City  :  {contact.City}");
                                Console.WriteLine($"State :  {contact.State}");
                                Console.WriteLine($"Zipcode : {contact.Zipcode}");
                                Console.WriteLine($"Phonenumber : {contact.PhoneNumber}");
                                Console.WriteLine($"Email :  {contact.Email}");

                                Console.WriteLine();
                            }
                        }
                        break;
                    case "3":

                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);

                        break;
                    default: 
                        Console.WriteLine("Invalid Choice!");
                        break;
                }
                Console.WriteLine();
                
                
                   
                
            }
        }
    }
}
