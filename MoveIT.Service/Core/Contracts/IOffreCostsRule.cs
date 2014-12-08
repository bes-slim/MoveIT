using MovePricer.Service.Models;

namespace MovePricer.Service.Core.Contracts
{
    public interface IOffreCostsRule
    {
        decimal CalculatePrice(MoveInfo info);
    }
}