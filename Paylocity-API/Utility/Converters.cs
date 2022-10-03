using Paylocity_API.Enum;
using Paylocity_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.Utility
{
    public class Converters
    {
        public static List<Person> ConvertPersonList(Employee employee)
        {
            var returnList = new List<Person>();

            returnList.Add(new Person() { Name = employee.Name, Type = PersonType.Employee });

            foreach (var dependent in employee.Dependents)
            {
                returnList.Add(new Person() { Name = dependent.Name, Type = ConvertDependentTypeToPersonType(dependent.Type) });
            }

            return returnList;
        }

        public static PersonType ConvertDependentTypeToPersonType(DependentType type)
        {
            switch (type)
            {
                case DependentType.Child:
                    return PersonType.Child;
                case DependentType.Spouse:
                    return PersonType.Spouse;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
