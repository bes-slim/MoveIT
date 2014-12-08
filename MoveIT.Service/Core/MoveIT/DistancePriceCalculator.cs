using System.Collections.Generic;
using System.Linq;
using MoveIT.Service.Core.Contracts.MoveIT;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core.MoveIT
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