using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Villa> Villas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Villa>().HasData(
            new Villa()
            {
                Id = 1,
                Name = "Royal Villa",
                Details =
                    "Сложно сказать, почему представители современных социальных резервов превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. Повседневная практика показывает, что высокое качество позиционных исследований представляет собой интересный эксперимент проверки распределения внутренних резервов и ресурсов.",
                ImageUrl = "",
                Occupancy = 5,
                Rate = 200,
                Sqft = 550,
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 2,
                Name = "Luxury Pool Villa",
                Details =
                    "Сложно сказать, почему представители современных социальных резервов превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. Повседневная практика показывает, что высокое качество позиционных исследований представляет собой интересный эксперимент проверки распределения внутренних резервов и ресурсов.",
                ImageUrl = "",
                Occupancy = 4,
                Rate = 400,
                Sqft = 750,
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa()
            {
                Id = 3,
                Name = "Diamond Pool Villa",
                Details =
                    "Сложно сказать, почему представители современных социальных резервов превращены в посмешище, хотя само их существование приносит несомненную пользу обществу. Повседневная практика показывает, что высокое качество позиционных исследований представляет собой интересный эксперимент проверки распределения внутренних резервов и ресурсов.",
                ImageUrl = "",
                Occupancy = 4,
                Rate = 600,
                Sqft = 1100,
                Amenity = "",
                CreatedDate = DateTime.Now
            });
    }
}