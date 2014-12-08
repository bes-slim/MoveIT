using MovePricer.Service.Core.Contracts.MoveIT;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core.MoveIT
{
    public class ShortDistanceRule : IDistancePriceRule
    {
        public bool IsApplicable(MoveInfo moveInfo)
        {
            return moveInfo.Distance < 50;
        }

        public decimal CalculatePrice(MoveInfo moveInfo)
        {
            return 1000m + moveInfo.Distance * 10m;
        }
    }
}