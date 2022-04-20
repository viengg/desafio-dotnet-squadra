using DesafioFinal.Domain;
using DesafioFinal.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesafioFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public IActionResult Authenticate([FromBody] User user)
        {
            var availableRoles = new List<string> { "Gerente", "Secretaria" };
            if (!availableRoles.Contains(user.Role))
            {
                return BadRequest("Role invalida para o usuario");
            }
            var token = TokenService.GenerateToken(user);
            return Ok(token);
        }
    }
}
