using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
  public class Customer
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [StringLength(38)]
    public string CustCode { get; set; }
    [Required]
    public string Tier { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    [StringLength(13)]
    public string CitizenId { get; set; }
    [Required]
    [StringLength(10)]
    public string GovId { get; set; }
    [Required]
    public string Branch { get; set; }

    public string ImageName { get; set; }
    public string MobileNumber { get; set; }
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    [StringLength(20)]
    public string Username { get; set; }
    [StringLength(20)]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [StringLength(1)]
    public string MemStatus { get; set; } = "A";
  }
}