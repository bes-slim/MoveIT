using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using MovePricer.Service.Core.Contracts;
using MovePricer.Service.Models;

namespace MovePricer.Service.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalculateController : ApiController
    {
        private readonly IOfferPriceCalculator _offerPriceCalculator;

        public CalculateController(IOfferPriceCalculator offerPriceCalculator)
        {
            _offerPriceCalculator = offerPriceCalculator;
        }

        // POST: api/calculate
        public decimal Post([FromBody]MoveInfo info)
        {
            return _offerPriceCalculator.CalculatePrice(info);
        }
        [HttpGet]
        public decimal fake()
        {
            return 123m;
        }
    }
}
