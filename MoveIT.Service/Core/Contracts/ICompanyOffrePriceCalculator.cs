using MovePricer.Service.Models;

namespace MovePricer.Service.Core.Contracts
{
    public interface ICompanyOffrePriceCalculator
    {
        decimal CalculateCompanyOffrePrice(MoveInfo info);
    }
}