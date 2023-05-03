using Microsoft.AspNetCore.Mvc;

namespace JankinsWebApp.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    private static readonly string[] Users = new[]
    {
        "Riya", "Rashmin", "Harsh", "Dhaval", "Jainam"
    };
    private readonly ILogger<UsersController> _logger;
    public UsersController(ILogger<UsersController> logger)
    {
      _logger = logger;
    }
    [HttpGet(Name = "GetUserList")]
    public IEnumerable<object> Get()
    {
      return Users.ToArray();
    }
  }
}