using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.Areas.Admin.Controllers
{
    [Area("Admin"),Authorize]
    public class ContactController : Controller
    {
        ContactManager contact = new ContactManager(new EfContactDal());
        
        public IActionResult Index()
        {
            var value = contact.DescList();
            return View(value);
        }
        
        public IActionResult ReadContact(int id)
        {
            var reading = contact.GetById(id);
            reading.ContactStatus = true;
            contact.Update(reading);
            return RedirectToAction("Index");
        }
    }
}
