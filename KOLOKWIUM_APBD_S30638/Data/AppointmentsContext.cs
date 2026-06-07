using KOLOKWIUM_APBD_S30638.Entities;
using Microsoft.EntityFrameworkCore;

namespace KOLOKWIUM_APBD_S30638.Data;

public class AppointmentsContext : DbContext
{
    public AppointmentsContext(DbContextOptions<AppointmentsContext> options) : base(options)
    {
        
    }
    
    public DbSet<Appointments> Appointments { get; set; }
    public DbSet<Appointment_Services> Appointment_Services { get; set; }
    public DbSet<Doctors> Doctors { get; set; }
    public DbSet<Medical_Services> Medical_Services { get; set; }
    public DbSet<Patients> Patients { get; set; }
}