using System;
using System.Collections.Generic;
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
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }
        public List<Contact> GetAllContacts() 
        { 
            return contacts;
        }
    }
}
