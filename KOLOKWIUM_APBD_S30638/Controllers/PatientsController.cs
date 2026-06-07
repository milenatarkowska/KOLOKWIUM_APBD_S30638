using KOLOKWIUM_APBD_S30638.Services;
using Microsoft.AspNetCore.Mvc;

namespace KOLOKWIUM_APBD_S30638.Controllers;

[ApiController]
[Route("api/patients")]
public class PatientsController
{
    private readonly IPatientsService _patientsService;

    public PatientsController(IPatientsService patientsService)
    {
        _patientsService = patientsService;
    }

    [HttpGet]
    public async Task<IActionResult> GetPatients([FromQuery] string? lastName)
    {
        var result = await _patientsService.GetPatients(lastName);

        if (!result.Any())
        {
            return NotFound();
        }
        return Ok(result);
    }
}