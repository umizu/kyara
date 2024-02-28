using Kyara.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace Kyara.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }

    public DbSet<Character> Characters { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Character>(e =>
        {
            e.HasData(
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Isla",
                    Image = "https://image.civitai.com/xG1nkqKTMzGDvpLrqFT7WA/2948a0a5-4bde-4290-94ed-edf158befd07/width=450/Isla0.jpeg",
                    Rating = 5
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Akame",
                    Image = "https://i1.sndcdn.com/artworks-000133617614-ywuyai-t500x500.jpg",
                    Rating = 4
                }
            );
        });
    }

}
