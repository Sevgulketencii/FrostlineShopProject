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
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        Context connect = new Context();
        public List<Contact> DescList()
        {
            return connect.ContactDbSet.OrderByDescending(x => x.ContactID).ToList();
        }

        public List<Contact> UnShowList()
        {
            return connect.ContactDbSet.Where(x=>x.ContactStatus==false).ToList();
        }

       
    }
}
