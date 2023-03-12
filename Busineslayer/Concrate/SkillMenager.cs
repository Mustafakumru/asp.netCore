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
    public class SkillMenager:ISkillService
    {
        ISkillDal _skillDal;

        public SkillMenager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Skill t)
        {
            throw new NotImplementedException();
        }

        public Skill TGetbyID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Skill> TGetList()
        {
           return _skillDal.GetList();  
        }

        public void TUpdate(Skill t)
        {
            throw new NotImplementedException();
        }
    }
}
