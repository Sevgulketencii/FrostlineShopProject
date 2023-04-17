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
    public class EfUserDal : GenericRepository<User>, IUserDal
    {
        Context connect = new Context();
        public User Login(User p)
        {
            return connect.UserDbSet.FirstOrDefault(x=>x.UserName==p.UserName && x.Password==p.Password);
        }
    }
}
