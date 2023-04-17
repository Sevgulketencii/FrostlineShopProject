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
    public class DiscountManager : IDiscountService
    {
        IDiscountDal _discount;

        public DiscountManager(IDiscountDal discount)
        {
            _discount = discount;
        }

        public List<Discount> ActiveDiscountList()
        {
            return _discount.ActiveDiscountList();
        }

       

        public void Add(Discount p)
        {
            _discount.Add(p);
        }

        public List<Discount> CategoryFilter(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Discount p)
        {
            _discount.Delete(p);
        }

        public Discount GetById(int id)
        {
            return _discount.GetById(id);
        }

        public List<Discount> List()
        {
            return _discount.List();
        }

        public List<Discount> NotActiveList()
        {
            return _discount.NotActiveList();
        }

        public void Update(Discount p)
        {
            _discount.Update(p);
        }
    }
}
