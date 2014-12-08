using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Core.Contracts.MoveIT;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core.MoveIT
{
    public class CarsCostsRule : IOffreCostsRule
    {
        private readonly IDistancePriceCalculator _distancePriceCalculator;
        private readonly ICarsNeededCalculator _carsNeededCalculator;

        public CarsCostsRule(
            IDistancePriceCalculator distancePriceCalculator,
            ICarsNeededCalculator carsNeededCalculator
            )
        {
            _distancePriceCalculator = distancePriceCalculator;
            _carsNeededCalculator = carsNeededCalculator;
        }

        public decimal CalculatePrice(MoveInfo info)
        {
            return _distancePriceCalculator.CalculateDistancePrice(info) * _carsNeededCalculator.CalculateNeededCars(info);
        }
    }
}