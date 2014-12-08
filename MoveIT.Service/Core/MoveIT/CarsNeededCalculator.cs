using System.Collections.Generic;
using System.Linq;
using MovePricer.Service.Core.Contracts.MoveIT;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core.MoveIT
{
    public class CarsNeededCalculator : ICarsNeededCalculator
    {
        private readonly IList<ICarsNeededForAreaRule> _carsNeededForAreaRules;

        public CarsNeededCalculator( IList<ICarsNeededForAreaRule> carsNeededForAreaRules)
        {
            _carsNeededForAreaRules = carsNeededForAreaRules;
        }

        public int CalculateNeededCars(MoveInfo info)
        {
            return _carsNeededForAreaRules.Sum(x => x.CarsNeededForArea(info));
        }
    }
}