using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ContactInfo
    {
        public ContactInfo() { }

        public ContactInfo(
            string name,
            string address,
            string type,
            string city,
            int phoneNumber,
            string employer
        )
        {
            Name = name;
            Address = address;
            Type = type;
            City = city;
            PhoneNumber = phoneNumber;
            Employer = employer;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string City { get; set; }
        public int PhoneNumber { get; set; }
        public string Employer { get; set; }
    }
}
