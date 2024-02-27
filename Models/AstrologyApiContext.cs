using Microsoft.EntityFrameworkCore;

namespace AstrologyApi.Models
{
  public class AstrologyApiContext : DbContext
  {
    public DbSet<Sign> Signs { get; set; }

    public AstrologyApiContext(DbContextOptions<AstrologyApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Sign>()
        .HasData(
          new Sign { SignId = 1, SignName = "Aries", Expression = "dominant",   Description = "idealist", Concentration = "action" }
        );
    }
  }
}