using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
