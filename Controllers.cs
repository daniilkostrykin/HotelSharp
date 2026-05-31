using Microsoft.AspNetCore.Mvc;
using HotelApi.Models;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class RoomsController : ControllerBase
{
    private static List<Room> _rooms = new() { new Room { Id = 1, Number = "101" } };
    [HttpGet] public IActionResult Get() => Ok(_rooms);
}

[ApiController]
[Route("api/[controller]")]
public class GuestsController : ControllerBase
{
    private static List<Guest> _guests = new() { new Guest { Id = 1, Name = "Иван Иванов" } };
    [HttpGet] public IActionResult Get() => Ok(_guests);
}

[ApiController]
[Route("api/health")]
public class HealthController : ControllerBase
{
    [HttpGet] public IActionResult Get() => Ok(new { status = "Healthy" });
}