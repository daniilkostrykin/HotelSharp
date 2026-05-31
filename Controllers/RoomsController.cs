using Microsoft.AspNetCore.Mvc;
using HotelApi.Models;

namespace HotelApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoomsController : ControllerBase
{
    private static readonly List<Room> _rooms = new()
    {
        new Room { Id = 1, Number = "101" }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Room>> Get()
    {
        return Ok(_rooms);
    }
}