using Busineslayer.Concrate;
using DataAcsesLayer.EnttyFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace asp.netCore.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        PortfolioMenager portfolioMenager = new PortfolioMenager(new EfPortfolioDal());
        public IViewComponentResult Invoke()
        {
            var values=portfolioMenager.TGetList();
            return View(values);    
        }
    }
}
