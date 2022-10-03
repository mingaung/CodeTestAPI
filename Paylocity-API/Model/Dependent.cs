using Paylocity_API.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.Model
{
    public class Dependent
    {
        public string Name { get; set; }
        public DependentType Type { get; set; }
    }
}
