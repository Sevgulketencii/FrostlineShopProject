using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.ViewComponents.AdminDashBoard
{
    public class _DashBoardDiscount:ViewComponent
    {
        DiscountManager discount = new DiscountManager(new EfDiscountDal());
        public IViewComponentResult Invoke()
        {
            var values = discount.ActiveList().Take(5).ToList();
            
            return View(values);
        }
    }
}
