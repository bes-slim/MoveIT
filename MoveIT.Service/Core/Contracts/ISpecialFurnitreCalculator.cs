using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts
{
    public interface ISpecialFurnitreCalculator
    {
        decimal CalculatePrice (MoveInfo info);
    }
}