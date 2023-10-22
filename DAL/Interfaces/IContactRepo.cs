using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IContactRepo
    {
        IEnumerable<ContactInfo> GetAll();
        ContactInfo GetById(int id);
        void AddContact(ContactInfo contact);
        void UpdateContact(ContactInfo contact);
        void RemoveContact(int id);
    }
}
