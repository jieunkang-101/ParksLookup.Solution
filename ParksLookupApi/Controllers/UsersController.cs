using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using ParksLookupApi.Models;
using ParksLookupApi.Helpers;
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

    // POST /api/users/register
    [AllowAnonymous]
    [HttpPost("register")]
    public IActionResult Register([FromBody]User userParam)
    {
      try 
      {
        // save 
        _userService.Create(userParam, userParam.Password);
        return Ok();
      } 
      catch(AppException ex)
      {
        // return error message if there was an exception
        return BadRequest(new { message = ex.Message });
      }
    }

    // PUT api/users/2
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody]User userParam)
    {
      // only allow admins to access other user records
      var currentUserId = int.Parse(User.Identity.Name);
      if (id != currentUserId && !User.IsInRole(Role.Admin)) 
      {
        return Forbid();
      }

      userParam.Id = id;

      try 
      {
        // save 
        _userService.Update(userParam, userParam.Password);
        return Ok();
      } 
      catch(AppException ex)
      {
        // return error message if there was an exception
        return BadRequest(new { message = ex.Message });
      }
    }

    // DELETE api/users/2
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      var currentUserId = int.Parse(User.Identity.Name);
      if (id != currentUserId && !User.IsInRole(Role.Admin)) 
      {
        return Forbid();
      }

      _userService.Delete(id);
      return Ok();
    }
  }
}
