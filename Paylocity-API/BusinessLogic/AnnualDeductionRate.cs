using Paylocity_API.BusinessLogic.Interface;
using Paylocity_API.Constant;
using Paylocity_API.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.BusinessLogic
{
    public class AnnualDeductionRate : IAnnualDeductionRate
    {
        public decimal Get(PersonType personType)
        {
            switch (personType)
            {
                case PersonType.Employee:
                    return Constants.EMPLOYEE_DEDUCTION_PER_YEAR;
                case PersonType.Spouse:
                case PersonType.Child:
                    return Constants.DEPENDENT_DEDUCTION_PER_YEAR;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
