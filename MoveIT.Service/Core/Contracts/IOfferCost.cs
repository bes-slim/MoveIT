using System.Collections.Generic;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts
{
    public interface IOfferCost
    {
        List<CompanyOffer> CalculateOfferCost(MoveInfo info);
    }
}