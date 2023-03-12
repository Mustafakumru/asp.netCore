using Busineslayer.Concrate;
using DataAcsesLayer.EnttyFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netCore.ViewComponents.Service
{
    public class ServiceList : ViewComponent
    {
        ServiceMenager serviceMenager = new ServiceMenager(new EfServiceDal() );
        public IViewComponentResult Invoke()
        {
            var values = serviceMenager.TGetList();
            return View( values );
        }
    }
}
