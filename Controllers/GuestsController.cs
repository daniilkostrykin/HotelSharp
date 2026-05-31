using Microsoft.AspNetCore.Mvc;
using HotelApi.Models;

namespace HotelApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GuestsController : ControllerBase
{
    private static readonly List<Guest> _guests = new()
    {
        new Guest { Id = 1, Name = "Иван Иванов" }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Guest>> Get()
    {
        return Ok(_guests);
    }
}