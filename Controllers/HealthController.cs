using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers;

[ApiController]
[Route("api/health")] 
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult CheckHealth()
    {
        return Ok(new { status = "Healthy", timestamp = DateTime.UtcNow });
    }
}