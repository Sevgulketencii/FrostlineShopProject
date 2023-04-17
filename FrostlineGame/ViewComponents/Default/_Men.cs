using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.ViewComponents.Default
{
    public class _Men:ViewComponent
    {
        ProductManager product = new ProductManager(new EfProductDal());
        DiscountManager discount = new DiscountManager(new EfDiscountDal());
       
        public IViewComponentResult Invoke()
        {
            
            var values = discount.IdDiscountList(1);
            
            if (values != null && values.EndDiscount >= DateTime.Now && values.EndDiscount >= DateTime.Now)
            {
                ViewBag.id = product.List().Select(x => x.Category.CategoryID);
                values.DiscountStatus = true;
                discount.Update(values);
                ViewBag.rate = values.DiscountRate;
            }
            else
            {
                if (values != null)
                {
                    values.DiscountStatus = false;
                    discount.Update(values);
                }
                
                ViewBag.rate = 0;
            }
            var value = product.CategoryFilter(1);
            return View(value);
        }
    }
}
