using System.Collections.Generic;
using System.Linq;
using MovePricer.Service.Core.Contracts.MoveIT;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core.MoveIT
{
    public class SpecialFurnitreCalculator : ISpecialFurnitreCalculator
    {
        private readonly IList<ISpecialFurnitureRule> _specialFurnitureRulesRules;

        public SpecialFurnitreCalculator(IList<ISpecialFurnitureRule> specialFurnitureRulesRules)
        {
            _specialFurnitureRulesRules = specialFurnitureRulesRules;
        }

        public decimal CalculatePrice(MoveInfo info)
        {
            return _specialFurnitureRulesRules.Where(x => x.HasFurniture(info)).Sum(x => x.CalculatePrice());
        }
    }
}