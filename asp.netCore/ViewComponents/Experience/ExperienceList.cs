using Busineslayer.Abstract;
using Busineslayer.Concrate;
using DataAcsesLayer.EnttyFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netCore.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        ExperienceMenager experienceMenager = new ExperienceMenager(new EfExperienceDal());

        public IViewComponentResult Invoke()
        {
            var values = experienceMenager.TGetList();
            return View(values);
        }

    }
}
