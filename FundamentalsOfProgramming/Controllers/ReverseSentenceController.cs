using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Services.Services;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReverseSentenceController : ControllerBase
    {
        private readonly IReverseSentenceService _reverseSentenceService;

        public ReverseSentenceController(IReverseSentenceService reverseSentenceService)
        {
            _reverseSentenceService = reverseSentenceService;
        }

        [HttpGet]
        public IActionResult ReverseString(string sentence)
        {
            try
            {
                string reverseResult = _reverseSentenceService.GenerateReverseString(sentence);
                return Ok(reverseResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Service Error");
            }
        }
    }
}