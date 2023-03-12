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
    public class PortfolioMenager:IPortfolioService
    {
        IPortfolioDal _portfolioDal;

        public PortfolioMenager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void TAdd(Portfolio t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Portfolio t)
        {
            throw new NotImplementedException();
        }

        public Portfolio TGetbyID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Portfolio> TGetList()
        {
          return _portfolioDal.GetList();
        }

        public void TUpdate(Portfolio t)
        {
            throw new NotImplementedException();
        }
    }
}
