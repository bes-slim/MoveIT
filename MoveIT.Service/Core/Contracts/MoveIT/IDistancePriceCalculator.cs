using MovePricer.Service.Models;

namespace MovePricer.Service.Core.Contracts.MoveIT
{
    public interface IDistancePriceCalculator
    {
        decimal CalculateDistancePrice(MoveInfo moveInfo);
    }
}