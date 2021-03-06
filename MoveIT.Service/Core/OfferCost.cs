﻿using System.Collections.Generic;
using System.Linq;
using MoveIT.Service.Core.Contracts;
using MoveIT.Service.Models;

namespace MoveIT.Service.Core
{
    public class OfferCost : IOfferCost
    {
        private readonly List<ICompanyOffrePriceCalculator> _companyOffrePriceCalculators;

        public OfferCost(List<ICompanyOffrePriceCalculator> companyOffrePriceCalculators)
        {
            _companyOffrePriceCalculators = companyOffrePriceCalculators;
        }

        public List<CompanyOffer> CalculateOfferCost(MoveInfo info)
        {
            return _companyOffrePriceCalculators
                .Select(x => new CompanyOffer()
                {
                    Name = "ABC",
                    Price = x.CalculateCompanyOffrePrice(info)
                }).ToList();
        }
    }
}