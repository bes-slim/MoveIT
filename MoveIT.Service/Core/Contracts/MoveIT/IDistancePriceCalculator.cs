using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts.MoveIT
{
    public interface IDistancePriceCalculator
    {
        decimal CalculateDistancePrice(MoveInfo moveInfo);
    }
}