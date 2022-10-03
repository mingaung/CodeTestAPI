using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.JWT
{
    public interface ITokenService
    {
        string BuildToken(string audience);
    }
}
