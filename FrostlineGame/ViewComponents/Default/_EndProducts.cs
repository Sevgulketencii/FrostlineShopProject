using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.ViewComponents.Default
{
    public class _EndProducts :ViewComponent
    {
        ProductManager product = new ProductManager(new EfProductDal());
        public IViewComponentResult Invoke()
        {
            var values = product.List().OrderByDescending(x => x.ProductID).Take(6).ToList();
            return View(values);
        }
    }
}
