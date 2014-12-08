using System.Collections.Generic;
using System.Linq;
using MovePricer.Service.Core.Contracts;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core
{
    public class CompanyOffers : ICompanyOffers
    {
        private readonly List<ICompanyOffrePriceCalculator> _companyOffrePriceCalculators;

        public CompanyOffers(List<ICompanyOffrePriceCalculator> companyOffrePriceCalculators)
        {
            _companyOffrePriceCalculators = companyOffrePriceCalculators;
        }

        public List<CompanyOffer> CalculateOfferCost(MoveInfo info)
        {
            return _companyOffrePriceCalculators
                .Select(x => new CompanyOffer()
                {
                    Name = "ABC",
                    Price = x.CalculateCompanyOffrePrice(info)
                }).ToList();
        }
    }
}