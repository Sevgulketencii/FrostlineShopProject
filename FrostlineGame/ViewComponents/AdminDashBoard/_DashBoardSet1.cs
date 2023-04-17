using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.ViewComponents.AdminDashBoard
{
    public class _DashBoardSet1 : ViewComponent
    {
        ProductManager product = new ProductManager(new EfProductDal());
      
        public IViewComponentResult Invoke()
        {
            ViewBag.count = product.List().Count();
            return View();
        }
    }
}
