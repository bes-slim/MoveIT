using MovePricer.Service.Core.Contracts.MoveIT;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core.MoveIT
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