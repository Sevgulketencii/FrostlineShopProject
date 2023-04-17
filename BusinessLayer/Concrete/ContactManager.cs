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
    public class ContactManager : IContactService
    {
        IContactDal _contact;

        public ContactManager(IContactDal contact)
        {
            _contact = contact;
        }

        public void Add(Contact p)
        {
            _contact.Add(p);
        }

        public List<Contact> CategoryFilter(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Contact p)
        {
            _contact.Delete(p);
        }

        public List<Contact> DescList()
        {
            return _contact.DescList();
        } 

        public Contact GetById(int id)
        {
           return _contact.GetById(id);
        }

        public List<Contact> List()
        {
            return _contact.List();
        }

        public List<Contact> UnShowList()
        {
            return _contact.UnShowList();
        }

        public void Update(Contact p)
        {
            _contact.Update(p);
        }
    }
}
