using Paylocity_API.BusinessLogic.Interface;
using Paylocity_API.Constant;
using Paylocity_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.BusinessLogic
{
    public class DiscountByNameCalculator : IDiscountCalculator
    {
        public decimal GetDiscountRate(Person person)
        {
            if (person?.Name?.ToLower().StartsWith("a") ?? false)
                return Constants.TEN_PERCENT_DISCOUNT_RATE; // 10 percent discount rate
            else
                return Constants.ZERO_PERCENT_DISCOUNT_RATE; // no discount
        }
    }
}
