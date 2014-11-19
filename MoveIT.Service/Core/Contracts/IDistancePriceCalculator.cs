using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts
{
    public interface IDistancePriceCalculator
    {
        decimal CalculateDistancePrice(MoveInfo moveInfo);
    }
}