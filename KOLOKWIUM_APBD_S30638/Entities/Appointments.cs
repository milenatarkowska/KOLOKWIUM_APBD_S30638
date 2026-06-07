using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KOLOKWIUM_APBD_S30638.Entities;

[Table("Appointments")]
public class Appointments
{
   [Key]
   public int AppointmentId { get; set; }
   
   [ForeignKey(nameof(Patients))]
   public int PatientId { get; set; }
   
   public Patients Patient { get; set; }
   
   [ForeignKey(nameof(Doctors))]
   public int DoctorId { get; set; }
   
   public Doctors Doctor { get; set; }
   
   public DateTime AppointmentDate { get; set; }
   
   [MaxLength(50)]
   public string Status { get; set; }
}