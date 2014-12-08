using MovePricer.Service.Models;

namespace MovePricer.Service.Core.Contracts.MoveIT
{
    public interface ISpecialFurnitreCalculator
    {
        decimal CalculatePrice (MoveInfo info);
    }
}