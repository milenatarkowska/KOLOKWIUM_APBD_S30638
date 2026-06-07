using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KOLOKWIUM_APBD_S30638.Entities;

[Table("Doctors")]
public class Doctors
{
    [Key]
    public int DoctorId { get; set; }
    
    [MaxLength(50)]
    public string FirstName { get; set; }
    
    [MaxLength(100)]
    public string LastName { get; set; }
    
    [MaxLength(100)]
    public string Specialization { get; set; }
    
    [MaxLength(9)]
    public string Phone { get; set; }
}