using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<Table> where Table : class
    {
        List<Table> List();
        void Add(Table p);
        void Delete(Table p);
        void Update(Table p);
        Table GetById(int id);
        List<Table> CategoryFilter(int id);
    }
}
