using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.ViewComponents.AdminDashBoard
{
    public class _CateProCount : ViewComponent
    {
        CategoryManager category = new CategoryManager(new EfCategoryDal());
        public IViewComponentResult Invoke()
        {
            var values = category.List();
            ViewBag.count = category.List().Count();
            return View(values);
        }
    }
}
