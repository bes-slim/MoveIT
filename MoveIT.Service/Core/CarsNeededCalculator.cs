using System.Collections.Generic;
using System.Linq;
using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core
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