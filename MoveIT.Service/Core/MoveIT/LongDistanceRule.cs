using MovePricer.Service.Core.Contracts.MoveIT;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core.MoveIT
{
    public class LongDistanceRule : IDistancePriceRule
    {
        public bool IsApplicable(MoveInfo moveInfo)
        {
            return moveInfo.Distance >= 100;
        }

        public decimal CalculatePrice(MoveInfo moveInfo)
        {
            return 10000m + moveInfo.Distance * 7m;
        }
    }
}