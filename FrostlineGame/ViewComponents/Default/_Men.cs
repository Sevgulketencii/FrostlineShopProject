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
        
        public IViewComponentResult Invoke(int id)
        {
            var value = product.CategoryFilter(id);
            return View(value);
        }
    }
}
