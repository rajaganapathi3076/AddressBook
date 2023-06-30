using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    [Serializable]
    public class Contact
    {
        public string Name { get; set; }
       
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Name:{Name} Address:{Address} City:{City} State:{State} Zip code:{Zipcode} PhoneNo:{PhoneNumber} EmailID:{Email}";
        }
    }
}
