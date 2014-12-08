using System.Collections.Generic;
using System.Linq;
using MovePricer.Service.Core.Contracts;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core
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