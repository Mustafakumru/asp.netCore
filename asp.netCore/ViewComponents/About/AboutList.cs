using Busineslayer.Concrate;
using DataAcsesLayer.EnttyFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netCore.ViewComponents.About
{
    public class AboutList: ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = aboutManager.TGetList();


            return View(values);
        }
    }
}
    

