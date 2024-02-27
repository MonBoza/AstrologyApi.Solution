using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AstrologyApi.Models;

namespace AstrologyApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SignsController : ControllerBase
  {
    private readonly AstrologyApiContext _db;

    public SignsController(AstrologyApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Sign>>> Get()
    {
      return await _db.Signs.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Sign>> Sign(int id)
    {
      Sign sign = await _db.Signs.FindAsync(id);

      if (sign == null)
      {
        return NotFound();
      }

      return sign;
    }

  }
}