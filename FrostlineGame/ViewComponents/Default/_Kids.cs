using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.ViewComponents.Default
{
    public class _Kids : ViewComponent
    {
        ProductManager product = new ProductManager(new EfProductDal());
        DiscountManager discount = new DiscountManager(new EfDiscountDal());

        public IViewComponentResult Invoke()
        {
            var value = discount.IdDiscountList(3);
            if (value != null && value.EndDiscount >= DateTime.Now && value.EndDiscount >= DateTime.Now)
            {
                value.DiscountStatus = true;
                discount.Update(value);
                ViewBag.rate = value.DiscountRate;
            }
            else
            {
                if (value != null)
                {
                    value.DiscountStatus = false;
                    discount.Update(value);
                }
                
                ViewBag.rate = 0;
            }
            var values = product.CategoryFilter(3);
            return View(values);
        }
    }
}
