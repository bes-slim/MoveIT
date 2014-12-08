using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Core.Contracts.MoveIT;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core.MoveIT
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