using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleProductInventoryManagement.Application.Contracts.Identity;
using SimpleProductInventoryManagement.Application.Models.Identity;

namespace SimpleProductInventoryManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authenticationService;

        public AuthController(IAuthService authenticationService)
        {
            this._authenticationService = authenticationService;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(AuthRequest request)
        {
            return Ok(await _authenticationService.Login(request));
        }

    }
}
