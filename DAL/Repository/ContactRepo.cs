using DAL.Entities;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    public class ContactRepo : IContactRepo
    {
        private readonly ApplicationDbContext _context;

        public ContactRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ContactInfo> GetAll()
        {
            return _context.ContactInfo.ToList();
        }

        ContactInfo IContactRepo.GetById(int id)
        {
            return _context.ContactInfo.Find(id);
        }

        void IContactRepo.AddContact(ContactInfo contact)
        {
            _context.ContactInfo.Add(contact);
        }

        public void UpdateContact(ContactInfo contact)
        {
            _context.ContactInfo.Entry(contact).State = EntityState.Modified;
        }

        public void RemoveContact(int id)
        {
            ContactInfo contactInfo = _context.ContactInfo.Find(id);
            _context.ContactInfo.Remove(contactInfo);
        }
    }
}
