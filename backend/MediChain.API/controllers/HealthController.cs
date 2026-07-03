using Microsoft.AspNetCore.Mvc;

namespace MediChain.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            Status = "Healthy",
            Project = "MediChain",
            Version = "1.0.0"
        });
    }
}