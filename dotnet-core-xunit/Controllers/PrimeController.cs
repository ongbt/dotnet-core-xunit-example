using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_core_xunit.Dtos;
using dotnet_core_xunit.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Options;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Prime.Services;

namespace dotnet_core_xunit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimeController : ControllerBase
    {
        private PrimeService _primeService;

        public PrimeController(PrimeService primeService)
        {
            _primeService = primeService;
        }

         


        [HttpGet("{number}")]
        public IActionResult IsPrime(int number)
        {
           var result = _primeService.IsPrime(number);

         

            return Ok(result);
        }

  
    }
}
