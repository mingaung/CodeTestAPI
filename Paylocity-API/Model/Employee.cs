using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.Model
{
    public class Employee : Person
    {
        public int YearlySalary { get; set; }
        public int NumberOfPaychecksPerYear { get; set; }
        public List<Dependent> Dependents { get; set; } = new List<Dependent>();
    }
}
