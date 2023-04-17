using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FrostlineGame.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactManager contact = new ContactManager(new EfContactDal());
        
        [HttpPost]
        public IActionResult Index(ContactModel p)
        {
            if (ModelState.IsValid)
            {
                Contact x = new Contact()
                {
                    ContactName = p.ContactName,
                    ContactMail = p.ContactMail,
                    ContactDescription = p.ContactDescription
                };
                contact.Add(x);
                
            }

            return RedirectToAction("Index", "Home");
        }


    }
}
