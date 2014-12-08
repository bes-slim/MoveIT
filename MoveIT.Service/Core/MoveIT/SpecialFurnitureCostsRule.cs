using MovePricer.Service.Core.Contracts;
using MovePricer.Service.Core.Contracts.MoveIT;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core.MoveIT
{
    public class SpecialFurnitureCostsRule : IOffreCostsRule
    {
        private readonly ISpecialFurnitreCalculator _specialFurnitreCalculator;

        public SpecialFurnitureCostsRule(ISpecialFurnitreCalculator specialFurnitreCalculator)
        {
            _specialFurnitreCalculator = specialFurnitreCalculator;
        }

        public decimal CalculatePrice(MoveInfo info)
        {
            return _specialFurnitreCalculator.CalculatePrice(info);
        }
    }
}