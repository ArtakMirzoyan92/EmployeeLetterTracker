using BusinessLayer.Interfaces;
using BusinessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeLetter.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LetterController : Controller
    {
        private readonly ILetterService _letterService;

        public LetterController(ILetterService letterService)
        {
            _letterService = letterService ?? throw new ArgumentNullException(nameof(letterService));
        }

        [HttpPost]
        [Route("AddLetter")]
        public IActionResult Add(LetterForCreate letter)
        {            
            var letterOut = _letterService.Add(letter);

            if (letterOut)
                return Ok();
            return BadRequest();
        }
    }
}
