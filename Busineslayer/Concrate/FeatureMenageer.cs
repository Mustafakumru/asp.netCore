using Busineslayer.Abstract;
using DataAcsesLayer.Abstract;
using Enttylayer.concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busineslayer.Concrate
{
    public class FeatureMenageer : IGenericService<Feature>
    {
        IFeatureDal _featureDal;

        public FeatureMenageer(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
         _featureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
           _featureDal.Delete(t);
        }

        public Feature TGetbyID(int id)
        {
            return _featureDal.GetByID(id); 
        }

        public List<Feature> TGetList()
        {
           return _featureDal.GetList();
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }
    }
}
