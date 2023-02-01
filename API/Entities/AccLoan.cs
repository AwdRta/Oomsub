using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
  public class AccLoan
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [StringLength(38)]
    public string AccCode { get; set; }

    [Required]
    [StringLength(38)]
    public string TypeCode { get; set; }
    public AccType AccType { get; set; }

    [Required]
    [StringLength(17)]
    public string AccId { get; set; }

    [Required]
    [StringLength(38)]
    public string CustCode { get; set; }
    public Customer Customer { get; set; }

    [Required]
    [Column(TypeName = "decimal(18, 6)")]
    public decimal MaxloanAmt { get; set; }
    [Required]
    [Column(TypeName = "decimal(18, 6)")]
    public decimal WithdrawAmt { get; set; }
    [Required]
    [Column(TypeName = "decimal(18, 6)")]
    public decimal InstallAmt { get; set; }
    [Required]
    [Column(TypeName = "decimal(18, 6)")]
    public decimal PrincipalAmt { get; set; }

    [Required]
    [StringLength(8)]
    public string TransferDate { get; set; }

    [StringLength(1)]
    public string AccStatus { get; set; }
  }
}