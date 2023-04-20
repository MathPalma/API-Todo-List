using Application.Interfaces;
using Application.ViewModels;
using Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_Todo_List.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationController(IAuthenticationService authenticationService) 
        {
            _authenticationService = authenticationService;
        }
        // GET: api/<AuthenticationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AuthenticationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AuthenticationController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ReturnMessage<bool>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ReturnMessage<bool>))]
        public async Task<IActionResult> RegisterUser([FromBody] RegisterRequestViewModel request)
        {
            ReturnMessage<bool> returnMessage = await _authenticationService.RegisterUser(request);
            return StatusCode(returnMessage.StatusCode, returnMessage);
        }

        // PUT api/<AuthenticationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthenticationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
