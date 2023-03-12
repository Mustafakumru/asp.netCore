using Busineslayer.Abstract;
using DataAcsesLayer.EnttyFreamwork;
using Enttylayer.concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busineslayer.Concrate
{
    
   public class ExperienceMenager:IExperianceService
    {
        IExperianceService _experienceDal;
        private EfExperienceDal efExperienceDal;

        public ExperienceMenager(IExperianceService experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public ExperienceMenager(EfExperienceDal efExperienceDal)
        {
            this.efExperienceDal = efExperienceDal;
        }

        public void TAdd(Experience t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Experience t)
        {
            throw new NotImplementedException();
        }

        public Experience TGetbyID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Experience> TGetList()
        {
            return _experienceDal.TGetList();  
        }

        public void TUpdate(Experience t)
        {
            throw new NotImplementedException();
        }
    }
}
