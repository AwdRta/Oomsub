using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities.ViewModels
{
  public class MemberVM
  {
    public Customer Customer { get; set; }
    public AccDpst AccDpst { get; set; }
    public IEnumerable<AccLoan> AccLoanList { get; set; }
  }
}