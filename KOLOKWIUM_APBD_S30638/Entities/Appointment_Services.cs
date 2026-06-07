using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace KOLOKWIUM_APBD_S30638.Entities;

[Table("Appointment_Services")]
[PrimaryKey(nameof(Appointments), nameof(Medical_Services))]
public class Appointment_Services
{
    [ForeignKey(nameof(Appointments))]
    public int AppointmentId { get; set; }
    public Appointments Appointment { get; set; }
    
    [ForeignKey(nameof(Medical_Services))]
    public int ServiceId { get; set; }
    public Medical_Services Medical_Service { get; set; }
    
    public int Quantity {get; set;}
    
    public DateTime PerformedAt { get; set; }
}