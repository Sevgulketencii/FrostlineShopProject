using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FrostlineGame.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrostlineGame.Areas.Admin.Controllers
{
    [Area("Admin"),Authorize]
    public class ProductController : Controller
    {
        ProductManager product = new ProductManager(new EfProductDal());
        CategoryManager category = new CategoryManager(new EfCategoryDal());
        
        public IActionResult Index()
        {
            var values = product.AdminList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> value = (from x in category.List()
                                          select new SelectListItem
                                          {
                                              Text = x.CategoryName,
                                              Value = x.CategoryID.ToString()
                                          }).ToList();
            ViewBag.dropdown = value;
            return View();
        }
   
        [HttpPost]
        public IActionResult AddProduct(AddProductModel p)
        {
            if (ModelState.IsValid)
            {
                Product newProduct = new Product()
                {
                    ProductName = p.ProductName,
                    ProductDescription = p.ProductDescription,
                    ProductImageCover = p.ProductImageCover,
                    ProductImage = p.ProductImage,
                    ProductImage2 = p.ProductImage2,
                    ProductPrice = p.ProductPrice,
                    ProductStock = p.ProductStock,
                    CategoryID = p.CategoryID,
                    
                    ProductStatus = true,

                };
                product.Add(newProduct);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var remove = product.GetById(id);
            product.Delete(remove);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var updateProduct = product.GetById(id);
            return View(updateProduct);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {
            if (ModelState.IsValid)
            {
                p.ProductStatus = true;
                product.Update(p);
                return RedirectToAction("Index");
            }

            return View(p);
        }

        public IActionResult ShowProduct(int id)
        {
            var show = product.GetById(id);
            show.ProductStatus = true;
            product.Update(show);
            return RedirectToAction("Index");
        }

        public IActionResult UnShowProduct(int id)
        {
            var unShow = product.GetById(id);
            unShow.ProductStatus = false;
            product.Update(unShow);
            return RedirectToAction("Index");
        }

    }
}
