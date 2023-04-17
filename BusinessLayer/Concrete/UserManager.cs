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
    public class UserManager : IUserService
    {
        IUserDal _user;

        public UserManager(IUserDal userdal)
        {
            _user = userdal;
        }

        public void Add(User p)
        {
            throw new NotImplementedException();
        }

        public List<User> CategoryFilter(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(User p)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> List()
        {
            throw new NotImplementedException();
        }

        public User Login(User p)
        {
            return _user.Login(p);
        }

        public void Update(User p)
        {
            throw new NotImplementedException();
        }
    }
}
