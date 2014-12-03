using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts
{
    public interface ICompanyOffrePriceCalculator
    {
        decimal CalculateCompanyOffrePrice(MoveInfo info);
    }
}