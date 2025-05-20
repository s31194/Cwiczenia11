using Microsoft.AspNetCore.Mvc;
using Tutorial5.DTOs;
using Tutorial5.Interfaces;

namespace Tutorial5.Controllers;

public class PrescriptionsController : ControllerBase
{
    private readonly IPrescriptionService _service;

    public PrescriptionsController(IPrescriptionService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> AddPrescription([FromBody] CreatePrescriptionRequest request)
    {
        try
        {
            await _service.AddPrescriptionAsync(request);
            return Ok("Recepta dodana.");
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("patients/{id}")]
    public async Task<IActionResult> GetPatientDetails(int id)
    {
        var result = await _service.GetPatientDetailsAsync(id);
        if (result == null)
            return NotFound();
        return Ok(result);
    }
}