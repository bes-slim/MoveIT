using MovePricer.Service.Models;

namespace MovePricer.Service.Core.Contracts.MoveIT
{
    public interface ISpecialFurnitureRule
    {
        bool HasFurniture(MoveInfo info);
        decimal CalculatePrice();
    }
}