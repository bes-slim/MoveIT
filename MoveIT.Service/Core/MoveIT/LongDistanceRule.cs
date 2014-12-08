using MoveIT.Service.Core.Contracts.MoveIT;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core.MoveIT
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