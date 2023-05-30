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
            Console.WriteLine("Welcome to the AddressBook UC1");
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("Address Book Menu:");
                Console.WriteLine("1.Add Contact \n2.Exit");
                
                Console.Write("Enter your Choice : ");
                string Choice= Console.ReadLine();

                switch(Choice)
                {
                    case "1":
                        Console.WriteLine("Enter Name:  ");
                        string name= Console.ReadLine();
                        Console.WriteLine("Enter Address:  ");
                        string address = Console.ReadLine();
                        Console.WriteLine("Enter City:  ");
                        string city = Console.ReadLine();
                        Console.WriteLine("Enter State:  ");
                        string state = Console.ReadLine();
                        Console.WriteLine("Enter Zipcode:  ");
                        int zipcode = Convert.ToInt32 ( Console.ReadLine());
                        Console.WriteLine("Enter Phonenumber:  ");
                        long phonenumber = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine("Enter Email:  ");
                        string email = Console.ReadLine();

                        Contact newContact= new Contact();
                        {
                            newContact.Address = address;
                        }
                        addressBook.AddContact(newContact);
                        Console.WriteLine("Contact added successfully!");
                        break;
                    case "2":

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
