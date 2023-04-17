using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.ViewComponents.Default
{
    public class _Banner: ViewComponent
    {
        FeatureManager feature = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = feature.List().ToList();
            return View(values);
        }
    }
}
