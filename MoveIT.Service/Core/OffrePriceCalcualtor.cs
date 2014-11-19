using System.Collections.Generic;
using System.Linq;
using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core
{
    public class OffrePriceCalcualtor : IOfferPriceCalculator
    {
        private readonly IList<IOffreCostsRule> _offrePriceRules;

        public OffrePriceCalcualtor(IList<IOffreCostsRule> offrePriceRules)
        {
            _offrePriceRules = offrePriceRules;
        }

        public decimal CalculatePrice(MoveInfo info)
        {
            return _offrePriceRules.Sum(x => x.CalculatePrice(info));
        }
    }
}