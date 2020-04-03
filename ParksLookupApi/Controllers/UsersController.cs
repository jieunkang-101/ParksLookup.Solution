using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ParksLookupApi.Models;
using ParksLookupApi.Services;

namespace ParksLookupApi.Controllers
{
  [Authorize]
  [ApiController]
  [Route("api/[controller]")]
  public class UsersController : ControllerBase
  {
    private IUserService _userService;

    public UsersController(IUserService userService)
    {
      _userService = userService;
    }

    //POST /api/users/authenticate
    [AllowAnonymous]
    [HttpPost("authenticate")]
    public IActionResult Authenticate([FromBody]User userParam)
    {
      var user = _userService.Authenticate(userParam.Username, userParam.Password);

      if (user == null)
      {
        return BadRequest(new { message = "Username or password is incorrect" });
      }

      return Ok(user);
    }

    //GET /api/users
    [Authorize(Roles = Role.Admin)]
    [HttpGet]
    public IActionResult GetAll()
    {
      var users =  _userService.GetAll();
      return Ok(users);
    }

    //GET /api/users/2
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
      var user =  _userService.GetById(id);

      if (user == null) 
      {
        return NotFound();
      }

      // only allow admins to access other user records
      var currentUserId = int.Parse(User.Identity.Name);
      if (id != currentUserId && !User.IsInRole(Role.Admin)) 
      {
        return Forbid();
      }

      return Ok(user);
    }
  }
}
