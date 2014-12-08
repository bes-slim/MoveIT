using MoveIT.Service.Core.Contracts.MoveIT;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core.MoveIT
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