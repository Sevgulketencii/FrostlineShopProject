using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _product;

        public ProductManager(IProductDal product)
        {
            _product = product;
        }

        public void Add(Product p)
        {
            _product.Add(p);
        }

        public List<Product> AdminList()
        {
            return _product.AdminList();
        }

        public List<Product> CategoryFilter(int id)
        {
            return _product.GetCategoryList(x => x.CategoryID == id);
        }

        public void Delete(Product p)
        {
            _product.Delete(p);
        }

        public Product GetById(int id)
        {
            return _product.GetById(id);
        }

        public List<Product> List()
        {
            return _product.List();
            
        }

        public void Update(Product p)
        {
            _product.Update(p);
        }
    }
}
