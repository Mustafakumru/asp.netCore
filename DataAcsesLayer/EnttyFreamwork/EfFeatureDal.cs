using DataAcsesLayer.Abstract;
using DataAcsesLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesLayer.EnttyFreamwork
{
    public class EfFeatureDal : GenericRepository<Enttylayer.concrate.Feature>,IFeatureDal
    {
    }
}
