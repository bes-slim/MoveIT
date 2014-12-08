using MoveIT.Service.Core.Contracts.MoveIT;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core.MoveIT
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