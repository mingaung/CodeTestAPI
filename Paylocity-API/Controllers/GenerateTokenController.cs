using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Paylocity_API.JWT;
using Paylocity_API.Utility;

namespace Paylocity_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerateTokenController : ControllerBase
    {
        IConfiguration _configuration;
        ITokenService _tokenService;
        public GenerateTokenController(IConfiguration configuration, ITokenService tokenService)
        {
            _configuration = configuration;
            _tokenService = tokenService;
        }

        [HttpGet("GenerateJwtToken")]
        public IActionResult GenerateJwtToken()
        {
            string audience = string.Empty;
            var token = "";
            if (Request.Headers["Audience"].Count > 0 && Request.Headers["Audience"][0] != null)
            {
                audience = Request.Headers["Audience"][0];
                token = _tokenService.BuildToken(audience);
            }
            return Ok(GenericActionResult.Success(null,token));
        }
    }
}
