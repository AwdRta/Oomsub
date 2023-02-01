using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CustomersController
  {
    private readonly DataContext _db;
    public CustomersController(DataContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
    {
      var model = await _db.Customer.Take(20).ToListAsync();
      return model;
    }

    [HttpGet("{citizenId}")]
    public async Task<ActionResult<Customer>> GetCustomer(string citizenId)
    {
      return await _db.Customer.FirstOrDefaultAsync(a => a.CitizenId == citizenId);
    }
  }
}