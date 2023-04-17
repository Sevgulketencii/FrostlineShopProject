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
        
        public IViewComponentResult Invoke(int id)
        {
            var values = product.CategoryFilter(id);
            return View(values);
        }
    }
}
