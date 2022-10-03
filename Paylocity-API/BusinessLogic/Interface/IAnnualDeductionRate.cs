using Paylocity_API.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.BusinessLogic.Interface
{
    public interface IAnnualDeductionRate
    {
        /// <summary>
        /// Returns the annual benefits deduction amount for a given person type.
        /// </summary>
        /// <param name="personType">Type of person whose annual deduction is requested.</param>
        /// <returns>Annual benefits deduction amount</returns>
        decimal Get(PersonType personType);
    }
}
