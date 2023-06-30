using Microsoft.SqlServer.Server;
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
            //Console.WriteLine("Welcome to the AddressBook UC2");
            //Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();
            //AddressBook addressBook = new AddressBook();

            //while (true)
            //{
            //    Console.WriteLine("Address Book Menu:");
            //    Console.WriteLine("1.Add Contact");
            //    Console.WriteLine("2.View All Contact");  
            //    Console.WriteLine("3.Edit Contact");
            //    Console.WriteLine("4.RemoveContact");
            //    Console.WriteLine("5.Exit");
            //    Console.Write("Enter your Choice : ");
            //    string Choice= Console.ReadLine();

            //    switch(Choice)
            //    {
            //        case "1":
            //            Console.WriteLine("Enter Name:  ");
            //            string Name= Console.ReadLine();
            //            Console.WriteLine("Enter Address:  ");
            //            string Address = Console.ReadLine();
            //            Console.WriteLine("Enter City:  ");
            //            string City = Console.ReadLine();
            //            Console.WriteLine("Enter State:  ");
            //            string State = Console.ReadLine();
            //            Console.WriteLine("Enter Zipcode:  ");
            //            int Zipcode = Convert.ToInt32 ( Console.ReadLine());
            //            Console.WriteLine("Enter Phonenumber:  ");
            //            long Phonenumber = Convert.ToInt64(Console.ReadLine());
            //            Console.WriteLine("Enter Email:  ");
            //            string Email = Console.ReadLine();

            //            Contact newContact= new Contact();
            //            {
            //                newContact.Name = Name;
            //                newContact.Address = Address;
            //                newContact.City = City;
            //                newContact.State = State;
            //                newContact.Zipcode = Zipcode;
            //                newContact.PhoneNumber = Convert.ToInt64( Phonenumber);
            //                newContact.Email = Email;

            //            }
            //            addressBook.AddContact(newContact);
            //            Console.WriteLine("Contact added successfully!");

            //            break;
            //        case "2":
            //            List<Contact> contacts = addressBook.GetAllContacts();
            //            if (contacts.Count > 0)
            //            {
            //                Console.WriteLine("All Contacts :");

            //                foreach(Contact contact in contacts)
            //                {
            //                    Console.WriteLine($"Name:  {contact.Name}");
            //                    Console.WriteLine($"Address :  {contact.Address}");
            //                    Console.WriteLine($"City  :  {contact.City}");
            //                    Console.WriteLine($"State :  {contact.State}");
            //                    Console.WriteLine($"Zipcode : {contact.Zipcode}");
            //                    Console.WriteLine($"Phonenumber : {contact.PhoneNumber}");
            //                    Console.WriteLine($"Email :  {contact.Email}");

            //                    Console.WriteLine();
            //                }
            //            }
            //            break;
            //        case "3":

            //            Console.WriteLine("Enter the update contact details");
            //            string contactNameToEdit=Console.ReadLine();
            //            List<Contact> allContactsToEdit = addressBook.GetAllContacts();
            //            Contact contactToEdit = allContactsToEdit.Find(c => c.Name.Equals(contactNameToEdit, StringComparison.OrdinalIgnoreCase));

            //            if (contactToEdit != null)
            //            {
            //                Console.WriteLine("Enter the updated contact details:  ");
            //                Console.Write("Enter contact name: ");
            //                string upadatedName=Console.ReadLine();
            //                Console.Write("Enter the Phone number:  ");
            //                long updatedPhoneNumber = Convert .ToInt64(Console.ReadLine());
            //                Console.WriteLine("Enter the City:  ");
            //                string updatedCity=Console.ReadLine();

            //                Contact updatedContact = new Contact();
            //                {
            //                    Name = upadatedName;
            //                    Phonenumber = updatedPhoneNumber;
            //                    City = updatedCity;
            //                }
            //                addressBook.EditContact(contactToEdit.Name, updatedContact);
            //                Console.WriteLine("Contact updated is Successfuly");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Contact is not found!!");
            //            }

            //            break;
            //        case "4":
            //            Console.Write("Enter the name of the contact to remove: ");
            //            string contactName = Console.ReadLine();

            //            List<Contact> allContacts = addressBook.GetAllContacts();
            //            Contact contactToRemove = allContacts.Find(c => c.Name.Equals(contactName, StringComparison.OrdinalIgnoreCase));

            //            if (contactToRemove != null)
            //            {
            //                addressBook.RemoveContact(contactToRemove);
            //                Console.WriteLine("Contact removed successfully!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Contact not found!");
            //            }
            //            break;

            //        case "5":

            //            Console.WriteLine("Exiting...");
            //            Environment.Exit(0);

            //            break;
            //        default: 
            //            Console.WriteLine("Invalid Choice!");
            //            break;
            //    }
            //    Console.WriteLine();




            // }
            Console.WriteLine("Welcome To File I/O operation UC15");
            string JsonFilePath = @"C:\Users\Raja\source\repos\AddressBook\AddressBook\Contact Data\Contactdata1.json";
            string CsvFilePath = @"C:\Users\Raja\source\repos\AddressBook\AddressBook\Contact Data\Contactdata1.csv";
            string path = @"C:\Users\Raja\source\repos\AddressBook\AddressBook\Contact Data\Contactdata1.txt";
            List<Contact> list = new List<Contact>()
            {
                new Contact() {Name="Raja",Address="Chennai",City="Tambaram",State="Tamilnadu",PhoneNumber=8248956325,Email="Raja235@gmail.com",Zipcode=602141},
                 new Contact() {Name="Suresh",Address="Madurai",City="LakshmiPuram",State="Tamilnadu",PhoneNumber=6325251452,Email="Suresh562@gmail.com",Zipcode=652301},
                  new Contact() {Name="Senthil",Address="Tirchy",City="Avalur",State="Tamilnadu",PhoneNumber=9632587466,Email="Senthil895@gmail.com",Zipcode=623014},


            };


            //BinaryOperation.BinarySerialization(list,path);
            // CsvDataOperation.CsvDataSerialize(list, CsvFilePath);
            // CsvDataOperation.CsvDataDeSerialize(CsvFilePath);

            JsonDataOperation.JsonDataSerializer(JsonFilePath,list);
            Console.ReadLine();
        }


    }
}
