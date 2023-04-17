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
            _category.Add(p);
        }

        public List<Category> CategoryFilter(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category p)
        {
            _category.Delete(p);
        }

        public Category GetById(int id)
        {
            return _category.GetById(id);
        }

        public List<Category> List()
        {
            return _category.List();
        }

        public void Update(Category p)
        {
            _category.Update(p);

        }
    }
}
