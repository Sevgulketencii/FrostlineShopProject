using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.GenericRepository
{
    public class GenericRepository<Table> : IGenericDal<Table> where Table : class
    {
        Context connect = new Context();

        public void Add(Table p)
        {
            connect.Set<Table>().Add(p);
            connect.SaveChanges();
        }

        public void Delete(Table p)
        {
            connect.Set<Table>().Remove(p);
            connect.SaveChanges();
        }

        public Table GetById(int id)
        {
            return connect.Set<Table>().Find(id);
        }

        public List<Table> GetCategoryList(Expression<Func<Table, bool>> Filter)
        {
            return connect.Set<Table>().Where(Filter).ToList();
        }

        public List<Table> List()
        {
            return connect.Set<Table>().ToList();
        }

        public void Update(Table p)
        {
            connect.Set<Table>().Update(p);
            connect.SaveChanges();
        }
    }
}
