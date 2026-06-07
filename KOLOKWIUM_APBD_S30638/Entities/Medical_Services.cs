using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;

namespace KOLOKWIUM_APBD_S30638.Entities;

[Table("Medical_Services")]
public class Medical_Services
{
    [Key]
    public int ServiceId { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; }
    
    [MaxLength(100)]
    public string Description { get; set; }
    
    [Column(TypeName = "numeric")]
    [Precision(10, 2)]
    public double Price { get; set; }
    
    public int DurationMinutes { get; set; }
    
    
}