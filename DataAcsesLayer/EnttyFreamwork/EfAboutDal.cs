using DataAcsesLayer.Abstract;
using DataAcsesLayer.Repository;
using Enttylayer.concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsesLayer.EnttyFreamwork
{
    public class EfAboutDal : GenericRepository<About>,IAboutDal
    {
    }
}
