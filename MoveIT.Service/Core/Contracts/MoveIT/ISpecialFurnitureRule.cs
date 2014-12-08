using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts.MoveIT
{
    public interface ISpecialFurnitureRule
    {
        bool HasFurniture(MoveInfo info);
        decimal CalculatePrice();
    }
}