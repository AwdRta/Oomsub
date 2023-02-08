using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
  public class DepositDto
  {
    public string TypeCode { get; set; }
    public string AccCode { get; set; }
    public string AccId { get; set; }
    public string CustCode { get; set; }
    public decimal UsableAmt { get; set; }
    public decimal AvaliableAmt { get; set; }
    public string TransferDate { get; set; }
    public string AccStatus { get; set; }
  }
}