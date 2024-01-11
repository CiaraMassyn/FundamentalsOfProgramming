using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FactorialNumberController : ControllerBase
    {
        private readonly IFactorialService _factorialService;

        public FactorialNumberController(IFactorialService factorialService)
        {
            _factorialService = factorialService;
        }

        [HttpGet]
        public IActionResult CalculateFactorial(int number)
        {
            try
            {
               int factorialResult = _factorialService.GenerateFactorial(number);
                return Ok(factorialResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Service Error");
            }
        }
    }
}