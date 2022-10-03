﻿using Paylocity_API.BusinessLogic.Interface;
using Paylocity_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.BusinessLogic
{
    public class DeductionCalculator : IDeductionCalculator
    {
        private readonly IAnnualDeductionRate _annualDeductionRate;
        private readonly IDiscountCalculator _discountCalculator;

        public DeductionCalculator(IAnnualDeductionRate annualDeductionRate, IDiscountCalculator discountCalculator)
        {
            _annualDeductionRate = annualDeductionRate;
            _discountCalculator = discountCalculator;
        }

        public decimal CalculateDeductionPerPaycheck(List<Person> persons, int numberOfPaychecksPerYear)
        {
            return CalculateDeductionPerAnnum(persons) / numberOfPaychecksPerYear;
        }

        public decimal CalculateDeductionPerAnnum(List<Person> persons)
        {
            return persons.Sum(person => CalculateDeductionWithDiscount(person));
        }

       

        public decimal CalculateDeductionWithDiscount(Person person)
        {
            return _annualDeductionRate.Get(person.Type) * (1 - (decimal)_discountCalculator.GetDiscountRate(person));
        }
    }
}
