using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FrostlineGame.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.Areas.Admin.Controllers
{
    [Area("Admin"),Authorize]
    public class DiscountController : Controller
    {
        DiscountManager discount = new DiscountManager(new EfDiscountDal());
     
        [HttpGet]
        public IActionResult AddDiscount()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddDiscount(AddDiscountModel p)
        {
            if (ModelState.IsValid)
            {
                Discount newDiscount = new Discount()
                {
                    DiscountName = p.Name,
                    DiscountImg = p.Image,
                    DiscountRate = p.Rate,
                    CategoryID = p.CategoryDiscount,
                    StartDiscount=p.Start,
                    EndDiscount=p.End
                    
                };
                if (newDiscount.StartDiscount <= DateTime.Now)
                {
                    newDiscount.DiscountStatus = true;
                }
              
                discount.Add(newDiscount);

                return RedirectToAction("Index", "DashBoard");
            }
            return View(p);
        }



        public IActionResult Active()
        {
            var values = discount.ActiveDiscountList();
            return View(values);
        }

        public IActionResult NotActive()
        {
            var values = discount.NotActiveList();
            return View(values);
        }
    }
}
