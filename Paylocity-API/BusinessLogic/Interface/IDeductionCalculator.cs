using Paylocity_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.BusinessLogic.Interface
{
    public interface IDeductionCalculator
    {
        /// <summary>
        /// Returns the benefits deduction amount per paycheck for a given family.
        /// </summary>
        /// <param name="persons">Persons within an employee's dependent.</param>
        /// <returns>Benefits deduction amount per paycheck for the employee</returns>
        decimal CalculateDeductionPerPaycheck(List<Person> persons, int numberOfPaychecksPerYear);

        /// <summary>
        /// Returns the benefits deduction amount per year for a given family.
        /// </summary>
        /// <param name="persons">Persons within an employee's family</param>
        /// <returns>Benefits deduction amount per year for the employee</returns>
        decimal CalculateDeductionPerAnnum(List<Person> persons);

        /// <summary>
        /// Returns the benefits deduction amount for the person. This method takes into account any discounts
        /// that the person might be eligible for.
        /// </summary>
        /// <param name="person">Person deduction amount should be calculated</param>
        /// <returns>Benefits deduction amount with any discount that the person is eligible for</returns>
        decimal CalculateDeductionWithDiscount(Person person);
    }
}
