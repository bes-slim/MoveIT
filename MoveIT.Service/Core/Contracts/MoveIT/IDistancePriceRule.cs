using MovePricer.Service.Models;

namespace MovePricer.Service.Core.Contracts.MoveIT
{
    public interface IDistancePriceRule
    {
        bool IsApplicable(MoveInfo moveInfo);
        decimal CalculatePrice(MoveInfo moveInfo);
    }
}