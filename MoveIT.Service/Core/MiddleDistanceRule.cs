using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core
{
    public class MiddleDistanceRule : IDistancePriceRule
    {
        public bool IsApplicable(MoveInfo moveInfo)
        {
            return moveInfo.Distance >= 50 && moveInfo.Distance < 100;
        }

        public decimal CalculatePrice(MoveInfo moveInfo)
        {
            return 5000m + moveInfo.Distance * 8m;
        }
    }
}