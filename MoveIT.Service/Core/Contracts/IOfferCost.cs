using System.Collections.Generic;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts
{
    public interface ICompanyOffers
    {
        List<CompanyOffer> CalculateOfferCost(MoveInfo info);
    }
}