using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
  public class LoanDto
  {
    public string AccCode { get; set; }
    public string TypeCode { get; set; }
    public string AccId { get; set; }
    public string CustCode { get; set; }
    public decimal MaxloanAmt { get; set; }
    public decimal WithdrawAmt { get; set; }
    public decimal InstallAmt { get; set; }
    public decimal PrincipalAmt { get; set; }
    public string TransferDate { get; set; }
    public string AccStatus { get; set; }
  }
}