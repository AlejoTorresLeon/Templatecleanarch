using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.API.DTOs;
using MyProject.Application.Features.Login;

namespace MyProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }


        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _loginService.LoginAsync(request.Username, request.Password);

            if (result == null)
                return Unauthorized("Credenciales inválidas");

            return Ok(result); // Retorna UsuarioLoginDto
        }

    }
}
