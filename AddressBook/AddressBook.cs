using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook() 
        {
            contacts = new List<Contact>();
        } 
       
        public void AddContact1(Contact contact)
        {
            contacts.Add(contact);
        }
        public List<Contact> GetAllContacts() 
        { 
            return contacts;
        }
        public void RemoveContact(Contact contact) 
        {
            contacts.Remove(contact);
        }
        public void EditContact(string name,Contact updateContact) 
        {
            Contact exitingContact = contacts.Find(c=> c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (exitingContact != null)
            {
                exitingContact.Name = updateContact.Name;
                exitingContact.Address = updateContact.Address;
                exitingContact.City = updateContact.City;

            }
            else
            {
                Console.WriteLine("Contact not fount");
            }
        }
    }
}
