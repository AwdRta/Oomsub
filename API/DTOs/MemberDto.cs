using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
  public class MemberDto
  {
    public string CustCode { get; set; }
    public string Tier { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string CitizenId { get; set; }
    public string GovId { get; set; }
    public string Branch { get; set; }
    public string ImageName { get; set; }
    public string MobileNumber { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string MemStatus { get; set; }
  }
}