using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts
{
    public interface IDistancePriceRule
    {
        bool IsApplicable(MoveInfo moveInfo);
        decimal CalculatePrice(MoveInfo moveInfo);
    }
}