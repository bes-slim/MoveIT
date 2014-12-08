using System.Collections.Generic;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core.Contracts
{
    public interface ICompanyOffers
    {
        List<CompanyOffer> CalculateOfferCost(MoveInfo info);
    }
}