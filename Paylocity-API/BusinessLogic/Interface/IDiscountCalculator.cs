using Paylocity_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.BusinessLogic.Interface
{
    public interface IDiscountCalculator
    {
        /// <summary>
        /// This method calculates the applicable discount rate for a given person.
        /// </summary>
        /// <param name="person">The person whose discount should be calcuated.</param>
        /// <returns>Discount rate (percentage in decimal form)</returns>
        decimal GetDiscountRate(Person person);
    }
}
