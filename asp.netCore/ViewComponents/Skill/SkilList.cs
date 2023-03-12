using Busineslayer.Concrate;
using DataAcsesLayer.EnttyFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netCore.ViewComponents.Skill
{
    public class SkilList : ViewComponent 
    {
        SkillMenager skillMenager = new SkillMenager(new EfSkilDal());
        public IViewComponentResult Invoke()
        {
            var values = skillMenager.TGetList();
            return View(values);  
        }
    }
}
