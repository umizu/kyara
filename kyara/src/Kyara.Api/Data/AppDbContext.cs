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
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b88753-RO3lBZgzwdJF.jpg",
                    Rating = 5
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Akame",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b63351-0WmsDENpiscp.png",
                    Rating = 5
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Alpha",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b162246-IbbxkhNJFDN5.png",
                    Rating = 5
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Beta",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b162247-R6OrAuT1FwL4.png",
                    Rating = 5
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Gamma",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b162245-x86QMM6nOj75.png",
                    Rating = 4
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Delta",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b162248-57Xgk6EmwKRQ.png",
                    Rating = 5
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Epsilon",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b162249-eJRpBIC5lAZX.png",
                    Rating = 4
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Claire",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b168798-IrHBKh5xbRsr.png",
                    Rating = 3
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Alexia",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b168799-uAsWFrrfqxTN.png",
                    Rating = 3
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Rose",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b168800-eb3FqWq0IdyV.png",
                    Rating = 3
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Cid",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b136837-3WR22FYet8Hv.jpg",
                    Rating = 5
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Goku",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/246-wsRRr6z1kii8.png",
                    Rating = 5
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Vegeta",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b913-NIFkKazWM8VO.png",
                    Rating = 5
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Piccolo",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b914-KuS8AWjqBrqa.jpg",
                    Rating = 3
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Gohan",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b2093-kdFZhqcNSsqW.png",
                    Rating = 5
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Krillen",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b2159-qtEuMYyOUkwY.jpg",
                    Rating = 4
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Bulma",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b678-2YCe13F0tFos.jpg",
                    Rating = 5
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Boo",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/1012.jpg",
                    Rating = 3
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Videl",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b2111-9XqkV0tpjRPB.png",
                    Rating = 4
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Trunks",
                    Image = "https://s4.anilist.co/file/anilistcdn/character/large/b2707-YKWmn4q87oF8.png",
                    Rating = 5
                }
            );
        });
    }

}
