using System.Collections.Generic;
using System.Linq;
using MovePricer.Service.Core.Contracts.MoveIT;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core.MoveIT
{
    public class DistancePriceCalculator : IDistancePriceCalculator
    {
        private readonly IList<IDistancePriceRule> _distancePriceRules;

        public DistancePriceCalculator(IList<IDistancePriceRule> distancePriceRules)
        {
            _distancePriceRules = distancePriceRules;
        }

        public decimal CalculateDistancePrice(MoveInfo moveInfo)
        {
            return _distancePriceRules.First(p => p.IsApplicable(moveInfo)).CalculatePrice(moveInfo);
        }
    }
}