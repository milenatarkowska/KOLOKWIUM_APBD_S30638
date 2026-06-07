using KOLOKWIUM_APBD_S30638.Data;
using KOLOKWIUM_APBD_S30638.DTOs;
using Microsoft.EntityFrameworkCore;

namespace KOLOKWIUM_APBD_S30638.Services;

public class PatientsService : IPatientsService
{
    private readonly AppointmentsContext _context;

    public PatientsService(AppointmentsContext context)
    {
        _context = context;
    }

    public async Task<List<PatientsGetDto>> GetPatients(string? lastName)
{
    var query = _context.Patients.AsQueryable();

    if (!string.IsNullOrWhiteSpace(lastName))
    {
        query = query.Where(p => p.LastName == lastName);
    }

    var patients = await query
        .Select(p => new PatientsGetDto
        {
            FirstName = p.FirstName,
            LastName = p.LastName,
            DateOfBirth = p.DateOfBirth,
            Phone = p.Phone,
            Appointments = p.Appointments.Select(a => new AppointmentsGetDto
            {
                AppointmentId = a.AppointmentId,
                AppointmentDate = a.AppointmentDate,
                Status = a.Status,
                Doctors = new List<DoctorsGetDto> 
                {
                    new DoctorsGetDto
                    {
                        FirstName = a.Doctors.FirstName,
                        LastName = a.Doctors.LastName,
                        Specialization = a.Doctors.Specialization,
                        Phone = a.Doctors.Phone,
                    }
                },
                AppointmentServices = a.AppointmentServices.Select(aserv => new Appointment_ServicesGetDto
                {
                    Quantity = aserv.Quantity,
                    PerformedAt = aserv.PerformedAt,
                    MedicalServices = new List<Medical_ServicesGetDto>
                    {
                        new Medical_ServicesGetDto
                        {
                            ServiceId = aserv.MedicalServices.ServiceId,
                            Name = aserv.MedicalServices.Name,
                            Description = aserv.MedicalServices.Description,
                            Price = (double)aserv.MedicalServices.Price,
                            DurationMinutes = aserv.MedicalServices.DurationMinutes 
                        }
                    }
                }).ToList()
            }).ToList()
        })
        .ToListAsync();

    return patients;
}
}