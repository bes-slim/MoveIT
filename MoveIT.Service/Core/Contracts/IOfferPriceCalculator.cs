using MoveIT.Service.Models;

namespace MoveIT.Service.Core.Contracts
{
    public interface IOfferPriceCalculator
    {
        decimal CalculatePrice(MoveInfo info);
    }
}