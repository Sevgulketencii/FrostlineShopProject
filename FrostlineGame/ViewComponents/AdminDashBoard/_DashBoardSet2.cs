using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.ViewComponents.AdminDashBoard
{
    public class _DashBoardSet2 : ViewComponent
    {
        CategoryManager category = new CategoryManager(new EfCategoryDal());
      
        public IViewComponentResult Invoke()
        {
            ViewBag.count = category.List().Count();
            return View();
        }
    }
}
