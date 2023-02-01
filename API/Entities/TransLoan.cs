using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
  public class TransLoan
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [StringLength(38)]
    public string TransCode { get; set; }

    [Required]
    [StringLength(38)]
    public string AccCode { get; set; }
    public AccLoan AccLoan { get; set; }

    [Required]
    [StringLength(2)]
    public string Status01 { get; set; }
    [Required]
    [StringLength(2)]
    public string Status02 { get; set; }
    [Required]
    [StringLength(2)]
    public string Status03 { get; set; }
    [Required]
    [StringLength(2)]
    public string Status04 { get; set; }

    [Required]
    [Column(TypeName = "decimal(18, 6)")]
    public decimal PayoutAmt { get; set; }
    [Required]
    [Column(TypeName = "decimal(18, 6)")]
    public decimal PayinPrincipalAmt { get; set; }
    [Required]
    [Column(TypeName = "decimal(18, 6)")]
    public decimal PayinInterestAmt { get; set; }
    [Required]
    [Column(TypeName = "decimal(18, 6)")]
    public decimal PayinPenaltyAmt { get; set; }
    [Required]
    [Column(TypeName = "decimal(18, 6)")]
    public decimal PayinInsureAmt { get; set; }
    [Required]
    [Column(TypeName = "decimal(18, 6)")]
    public decimal PrincipalAmt { get; set; }

    [Required]
    [StringLength(8)]
    public string PayinForDate { get; set; }
    [Required]
    [StringLength(8)]
    public string CreateDate { get; set; }
    [Required]
    [StringLength(9)]
    public string CreateTime { get; set; }
    [Required]
    [StringLength(8)]
    public string ApproveDate { get; set; }
    [Required]
    [StringLength(9)]
    public string ApproveTime { get; set; }
    [Required]
    [StringLength(8)]
    public string TransDate { get; set; }
    [Required]
    [StringLength(8)]
    public string TransferDate { get; set; }
  }
}