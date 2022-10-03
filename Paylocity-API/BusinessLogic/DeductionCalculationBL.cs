using Paylocity_API.BusinessLogic.Interface;
using Paylocity_API.DTO;
using Paylocity_API.Enum;
using Paylocity_API.Model;
using Paylocity_API.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.BusinessLogic
{
    public class DeductionCalculationBL : IDeductionCalculationBL
    {
        private readonly IDeductionCalculator _deductionCalculator;
        public DeductionCalculationBL(IDeductionCalculator deductionCalculator)
        {
            _deductionCalculator = deductionCalculator;
        }
        public DeductionCalculationDTO CalculateDeductions(Employee employee)
        {
            List<Person> persons = Converters.ConvertPersonList(employee);
            decimal employeeDedudctionPerPayCheck = _deductionCalculator.CalculateDeductionPerPaycheck(persons.Where(p => p.Type == PersonType.Employee).ToList(), employee.NumberOfPaychecksPerYear);
            decimal dependentsDeductionPerPayCheck = _deductionCalculator.CalculateDeductionPerPaycheck(persons.Where(p => p.Type != PersonType.Employee).ToList(), employee.NumberOfPaychecksPerYear);
            decimal totalDeductionPerPayCheck = _deductionCalculator.CalculateDeductionPerPaycheck(persons, employee.NumberOfPaychecksPerYear);
            decimal employeeDeductionPerYear = _deductionCalculator.CalculateDeductionPerAnnum(persons.Where(p => p.Type == PersonType.Employee).ToList());
            decimal dependentDeductionPerYear = _deductionCalculator.CalculateDeductionPerAnnum(persons.Where(p => p.Type != PersonType.Employee).ToList());
            decimal totalDeductionPerYear = _deductionCalculator.CalculateDeductionPerAnnum(persons);
            decimal employeePaycheckAfterDeductions = (employee.YearlySalary / (decimal)employee.NumberOfPaychecksPerYear) - totalDeductionPerPayCheck;
            decimal employeeYearlyPayAfterDeductions = employee.YearlySalary - totalDeductionPerYear;

            return new DeductionCalculationDTO()
            {
                EmployeeDeductionPerPayCheck = employeeDedudctionPerPayCheck,
                DependentsDeductionPerPayCheck = dependentsDeductionPerPayCheck,
                TotalDeductionPerPayCheck = totalDeductionPerPayCheck,
                EmployeeDeductionPerYear = employeeDeductionPerYear,
                DependentsDeductionPerYear = dependentDeductionPerYear,
                TotalDeductionPerYear = totalDeductionPerYear,
                EmployeePaycheckAfterDeductions = employeePaycheckAfterDeductions,
                EmployeeYearlyPayAfterDeductions = employeeYearlyPayAfterDeductions
            };
        }
    }
}
