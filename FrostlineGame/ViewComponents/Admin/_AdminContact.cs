using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.ViewComponents.Admin
{
    public class _AdminContact : ViewComponent
    {
        ContactManager contact = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            ViewBag.values = contact.UnShowList().Count();
            return View();
        }
    }
}
