using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.GenericRepository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        Context connect = new Context();
        public List<Discount> ActiveDiscountList()
        {
            return connect.DiscountDbSet.Where(x => x.DiscountStatus == true).ToList();
        }

        public List<Discount> NotActiveList()
        {
            return connect.DiscountDbSet.Where(x => x.DiscountStatus == false).ToList();
        }
    }
}
