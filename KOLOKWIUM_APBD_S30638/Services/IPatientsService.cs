using KOLOKWIUM_APBD_S30638.DTOs;
using KOLOKWIUM_APBD_S30638.Entities;

namespace KOLOKWIUM_APBD_S30638.Services;

public class IPatientsService
{
    public Task<List<PatientsGetDto>> GetPatients(string? lastName);
}
