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
    public class ServiceMenager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceMenager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TAdd(Service t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Service t)
        {
            throw new NotImplementedException();
        }

        public Service TGetbyID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Service> TGetList()
        {
           return   _serviceDal.GetList();
        }

        public void TUpdate(Service t)
        {
            throw new NotImplementedException();
        }
    }
}
