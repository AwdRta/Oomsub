using System.Runtime.CompilerServices;
using System.Text;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  public class AccountController : BaseApiController
  {
    private readonly DataContext _db;
    private readonly ITokenService _tokenService;
    public AccountController(DataContext db, ITokenService tokenService)
    {
      _tokenService = tokenService;
      _db = db;
    }

    [HttpPost("register")]
    public async Task<ActionResult<UserDto>> Register(RegisterDto regis)
    {
      if (!await CustomerExists(regis.CitizenId)) return BadRequest("ไม่พบหมายเลขบัตรประชาชนนี้ในระบบ");

      Customer obj = new();
      obj = await _db.Customer.FirstOrDefaultAsync(a => a.CitizenId == regis.CitizenId);
      if (obj == null)
      {
        return BadRequest();
      }
      obj.Username = regis.Username;
      obj.Password = regis.Password;
      obj.Email = regis.Email;

      _db.Customer.Update(obj);
      await _db.SaveChangesAsync();
      return new UserDto
      {
        Username = obj.Username,
        Token = _tokenService.CreateToken(obj)
      };
    }

    [HttpPost("login")]
    public async Task<ActionResult<UserDto>> Login(LoginDto login)
    {
      var user = await _db.Customer.SingleOrDefaultAsync(a => a.Username == login.Username &&
                                                         a.Password == login.Password);
      if (user == null) return Unauthorized();
      return new UserDto
      {
        Username = user.Username,
        Token = _tokenService.CreateToken(user),
        CustCode = user.CustCode
      };
    }

    private async Task<bool> CustomerExists(string citizenId)
    {
      return await _db.Customer.AnyAsync(a => a.CitizenId == citizenId);
    }
    private async Task<bool> UsernameExists(string username)
    {
      return await _db.Customer.AnyAsync(a => a.Username == username);
    }
  }
}