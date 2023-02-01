using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
  public class AccType
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [StringLength(38)]
    public string TypeCode { get; set; }
    [Required]
    public string TypeName { get; set; }
  }
}