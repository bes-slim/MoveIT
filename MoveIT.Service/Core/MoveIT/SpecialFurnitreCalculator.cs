using System.Collections.Generic;
using System.Linq;
using MoveIT.Service.Core.Contracts.MoveIT;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core.MoveIT
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