using API.Data;
using API.Entities;
using API.Entities.ViewModels;
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

    [HttpGet("{custCode}")]
    public async Task<ActionResult<MemberVM>> GetCustomer(string custCode)
    {
      MemberVM vm = new()
      {
        Customer = await _db.Customer.FirstOrDefaultAsync(a => a.CustCode == custCode),
        AccDpst = await _db.AccDpst.FirstOrDefaultAsync(a => a.CustCode == custCode && a.AccStatus == "A"),
        AccLoanList = await _db.AccLoan.Where(a => a.CustCode == custCode).Where(a => a.AccStatus == "A").ToListAsync()
      };
      return vm;
    }
  }
}