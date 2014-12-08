using MovePricer.Service.Models;

namespace MovePricer.Service.Core.Contracts
{
    public interface IOfferPriceCalculator
    {
        decimal CalculatePrice(MoveInfo info);
    }
}