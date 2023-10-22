using ContactAssignmentMVC.Models;
using DAL.Entities;
using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ContactInfo = ContactAssignmentMVC.Models.ContactInfo;

namespace ContactAssignmentMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContactRepo _contactRepo;

        public HomeController(IContactRepo contactRepo)
        {
            _contactRepo = contactRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Models.ContactInfo> contactList = _contactRepo
                .GetAll()
                .Select(
                    x =>
                        new Models.ContactInfo(
                            x.Name,
                            x.Address,
                            x.City,
                            x.PhoneNumber,
                            x.Employer,
                            x.Type
                        )
                );
            return View(contactList);
        }

        [HttpPost]
        public IActionResult AddContact(ContactInfo contact)
        {
            DAL.Entities.ContactInfo contactInfo;

            if (contact == null)
            {
                contactInfo = new DAL.Entities.ContactInfo(
                    contact.Name,
                    contact.Address,
                    contact.Type,
                    contact.City,
                    contact.PhoneNumber,
                    contact.Employer
                );

                _contactRepo.AddContact(contactInfo);
            }

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(
                new ErrorViewModel
                {
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                }
            );
        }
    }
}
