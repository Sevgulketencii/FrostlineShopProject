using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FrostlineGame.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.Areas.Admin.Controllers
{
    [Area("Admin"),Authorize]
    public class CategoryController : Controller
    {
        CategoryManager category = new CategoryManager(new EfCategoryDal());

        public IActionResult Index()
        {
            var values = category.List();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(AddCategoryModel p)
        {
            if (ModelState.IsValid)
            {
                Category cate = new Category()
                {
                    CategoryName = p.CategoryName,
                    CategoryStatus = true,
                };
                category.Add(cate);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult DeleteCategory(int id)
        {
            var remove = category.GetById(id);
            category.Delete(remove);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = category.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category p)
        {
            if (ModelState.IsValid)
            {
                p.CategoryStatus = true;
                category.Update(p);
                return RedirectToAction("Index");
            }
            return View(p);
        }

    }
}
