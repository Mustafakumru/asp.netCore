using Busineslayer.Abstract;
using DataAcsesLayer.Abstract;
using DataAcsesLayer.EnttyFreamwork;
using Enttylayer.concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busineslayer.Concrate
{
    public class AboutManager : IAboutService
    {
        IAboutDal  _aboutDal;
        private EfServiceDal efServiceDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public AboutManager(EfServiceDal efServiceDal)
        {
            this.efServiceDal = efServiceDal;
        }

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetbyID(int id)
        {
            return _aboutDal.GetByID(id);   
        }

        public List<About> TGetList()
        {
            return  _aboutDal.GetList();
        }

        public void TUpdate(About t)
        {
             _aboutDal.Update(t);
        }
    }
}
