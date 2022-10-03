using Paylocity_API.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.Model
{
    public class Person
    {
        public string Name { get; set; }
        public PersonType Type { get; set; }
    }
}
