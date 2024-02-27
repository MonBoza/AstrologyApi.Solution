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
    public async Task<ActionResult<Sign>> GetSign(int id)
    {
      Sign sign = await _db.Signs.FindAsync(id);

      if (sign == null)
      {
        return NotFound();
      }

      return sign;
    }

    [HttpPost]
    public async Task<ActionResult<Sign>> Post(Sign sign)
    {
      _db.Signs.Add(sign);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetSign), new { id = sign.SignId }, sign);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Sign sign)
    {
      if (id != sign.SignId)
      {
        return BadRequest();
      }

      _db.Signs.Update(sign);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!SignExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool SignExists(int id)
    {
      return _db.Signs.Any(e => e.SignId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSign(int id)
    {
      Sign sign = await _db.Signs.FindAsync(id);
      if (sign == null)
      {
        return NotFound();
      }

      _db.Signs.Remove(sign);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}