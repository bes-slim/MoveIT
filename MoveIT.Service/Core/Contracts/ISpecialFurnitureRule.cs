using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts
{
    public interface ISpecialFurnitureRule
    {
        bool HasFurniture(MoveInfo info);
        decimal CalculatePrice();
    }
}