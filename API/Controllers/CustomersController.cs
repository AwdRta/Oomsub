using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [Authorize]
  public class CustomersController : BaseApiController
  {
    private readonly DataContext _db;
    public CustomersController(DataContext db)
    {
      _db = db;
    }

    [AllowAnonymous]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
    {
      var model = await _db.Customer.Take(20).ToListAsync();
      return model;
    }

    [HttpGet("{custCode}")]
    public async Task<ActionResult<Customer>> GetCustomer(string custCode)
    {
      return await _db.Customer.FirstOrDefaultAsync(a => a.CustCode == custCode);
    }
  }
}