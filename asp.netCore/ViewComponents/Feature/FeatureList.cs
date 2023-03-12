using Busineslayer.Concrate;
using DataAcsesLayer.EnttyFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netCore.ViewComponents.Feature
{
    public class FeatureList:ViewComponent
    {
        FeatureMenageer FeatureMenager = new FeatureMenageer(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = FeatureMenager.TGetList();

            return View(values);  
        }
    }
}
