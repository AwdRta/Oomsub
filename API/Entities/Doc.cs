using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
  public class Doc
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public int TypeId { get; set; }
    [ForeignKey("TypeId")]
    public DocType DocType { get; set; }

    [Required]
    public int No { get; set; }

    [Required]
    public string Header { get; set; }
    [Required]
    public string Description { get; set; }

    [Required]
    public string ImageName { get; set; }
    [Required]
    public string FileName { get; set; }
    [Required]
    public string FileEBook { get; set; }
  }
}