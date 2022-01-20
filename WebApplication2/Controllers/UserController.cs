using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers;

[ApiController]
[Route("/user")]
public class UserController : ControllerBase
{
    [HttpPost]
    [Route("token")]
    public string Token([FromBody] UserForm user)
    {
        // TODO: Find user with this login
        User founded = new User(login: "evg", password: "1234", 1);
        if (founded.CheckPassword(user))
        {
            //TODO: Manage tokens
            return "abcdef";
        }
        return string.Empty;
    }
}