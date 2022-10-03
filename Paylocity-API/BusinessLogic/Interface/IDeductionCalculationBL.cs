using Paylocity_API.DTO;
using Paylocity_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.BusinessLogic.Interface
{
    public interface IDeductionCalculationBL
    {
        /// <summary>
        /// This method takes an employee and returns the deductions calculated for that employee. 
        /// </summary>
        DeductionCalculationDTO CalculateDeductions(Employee employee);
    }
}
