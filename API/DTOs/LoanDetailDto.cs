using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
  public class LoanDetailDto
  {
    public string TransCode { get; set; }
    public string AccCode { get; set; }
    public string Status01 { get; set; }
    public string Status02 { get; set; }
    public string Status03 { get; set; }
    public string Status04 { get; set; }
    public decimal PayoutAmt { get; set; }
    public decimal PayinPrincipalAmt { get; set; }
    public decimal PayinInterestAmt { get; set; }
    public decimal PayinPenaltyAmt { get; set; }
    public decimal PayinInsureAmt { get; set; }
    public decimal PrincipalAmt { get; set; }
    public string PayinForDate { get; set; }
    public string CreateDate { get; set; }
    public string CreateTime { get; set; }
    public string ApproveDate { get; set; }
    public string ApproveTime { get; set; }
    public string TransDate { get; set; }
    public string TransferDate { get; set; }
  }
}