using KOLOKWIUM_APBD_S30638.Entities;

namespace KOLOKWIUM_APBD_S30638.DTOs;

public class PatientsGetDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Phone { get; set; }
    public List<AppointmentsGetDto> Appointments { get; set; }
}

public class AppointmentsGetDto
{
    public int AppointmentId { get; set; }
    public List<DoctorsGetDto> Doctors { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Status { get; set; }
    public List<Appointment_ServicesGetDto> AppointmentServices { get; set; }
    
}

public class DoctorsGetDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Specialization { get; set; }
    public String Phone { get; set; }
}

public class Appointment_ServicesGetDto
{
    public int Quantity {get; set;}
    public DateTime PerformedAt {get; set;}
    public List<Medical_ServicesGetDto> MedicalServices { get; set; }
    
}

public class Medical_ServicesGetDto
{
    public int ServiceId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int DurationMinutes { get; set; }
}