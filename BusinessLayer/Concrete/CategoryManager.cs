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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _category;

        public CategoryManager(ICategoryDal category)
        {
            _category = category;
        }

        public void Add(Category p)
        {
            throw new NotImplementedException();
        }

        public List<Category> CategoryFilter(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category p)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> List()
        {
            return _category.List();
        }

        public void Update(Category p)
        {
            throw new NotImplementedException();
        }
    }
}
