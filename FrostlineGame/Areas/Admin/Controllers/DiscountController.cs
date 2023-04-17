using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FrostlineGame.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        CategoryManager category = new CategoryManager(new EfCategoryDal());

        [HttpGet]
        public IActionResult AddDiscount()
        {
            List<SelectListItem> value = (from x in category.List()
                                          select new SelectListItem
                                          {
                                              Text = x.CategoryName,
                                              Value = x.CategoryID.ToString()
                                          }).ToList();
            ViewBag.dropdown = value;
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
                if (newDiscount.StartDiscount <= DateTime.Now && newDiscount.EndDiscount>=DateTime.Now)
                {
                    newDiscount.DiscountStatus = true;
                }
              
                discount.Add(newDiscount);

                return RedirectToAction("Index", "DashBoard");
            }
            return RedirectToAction("Index", "DashBoard");
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
