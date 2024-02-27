using Microsoft.EntityFrameworkCore;

namespace AstrologyApi.Models
{
  public class AstrologyApiContext : DbContext
  {
    public DbSet<Sign> Signs { get; set; }

    public AstrologyApiContext(DbContextOptions<AstrologyApiContext> options) : base(options)
    {
    }

  }
}