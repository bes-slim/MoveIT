using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts.MoveIT
{
    public interface ISpecialFurnitreCalculator
    {
        decimal CalculatePrice (MoveInfo info);
    }
}