using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts
{
    public interface IOffreCostsRule
    {
        decimal CalculatePrice(MoveInfo info);
    }
}