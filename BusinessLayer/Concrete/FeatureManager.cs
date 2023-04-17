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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _feature;

        public FeatureManager(IFeatureDal feature)
        {
            _feature = feature;
        }

        public void Add(Feature p)
        {
            _feature.Add(p);
        }

        public List<Feature> CategoryFilter(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Feature p)
        {
            _feature.Delete(p);
        }

        public Feature GetById(int id)
        {
            return _feature.GetById(id);
        }

        public List<Feature> List()
        {
            return _feature.List();
        }

        public void Update(Feature p)
        {
            _feature.Update(p);
        }
    }
}
