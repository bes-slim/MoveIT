using MovePricer.Service.Core.Contracts;
using MovePricer.Service.Models;

namespace MovePricer.Service.Core
{
    public class MoveItOffrePriceCalculator : ICompanyOffrePriceCalculator
    {
        private readonly IOfferPriceCalculator _offrePriceCalculator;

        public MoveItOffrePriceCalculator(IOfferPriceCalculator offrePriceCalculator)
        {
            _offrePriceCalculator = offrePriceCalculator;
        }

        public decimal CalculateCompanyOffrePrice(MoveInfo info)
        {
            return _offrePriceCalculator.CalculatePrice(info);
        }
    }
}