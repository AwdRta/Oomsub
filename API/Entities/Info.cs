using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
  public class Info
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Header { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string ImageName { get; set; }
  }
}