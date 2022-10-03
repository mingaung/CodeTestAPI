using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Paylocity_API.BusinessLogic;
using Paylocity_API.BusinessLogic.Interface;
using Paylocity_API.DTO;
using Paylocity_API.Model;

namespace Paylocity_API.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDeductionController : ControllerBase
    {
        IDeductionCalculationBL _deductionCalculationBL;
        public EmployeeDeductionController(IDeductionCalculationBL deductionCalculationBL)
        {
            _deductionCalculationBL = deductionCalculationBL;
        }

        [HttpGet("getTest")]
        public string getTest()
        {
            return "getTestWorks";
        }
        [HttpPost("CalculateDeductions")]
        [Authorize]
        public DeductionCalculationDTO CalculateDeductions([FromBody] Employee employee) {
            return _deductionCalculationBL.CalculateDeductions(employee);
        }
    }
}
