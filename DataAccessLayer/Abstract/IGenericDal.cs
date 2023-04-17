using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<Table> where Table:class
    {
        List<Table> List();
        void Add(Table p);
        void Delete(Table p);
        void Update(Table p);
        Table GetById(int id);
        List<Table> GetCategoryList(Expression<Func<Table, bool>> Filter);
    }
}
