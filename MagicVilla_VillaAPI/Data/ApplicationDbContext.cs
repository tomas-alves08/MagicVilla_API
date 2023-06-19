using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 101,
                    Name = "Tomas Villa",
                    Details = "Best place in the world",
                    Rate = 100,
                    Sqft = 58,
                    Occupancy = 3,
                    ImageUrl = "",
                    Amenity = "",
                    CreatedDate = DateTime.Now
                }
                );

            modelBuilder.Entity<VillaNumber>().HasData(
                new VillaNumber()
                {
                    VillaNo = 101,
                    SpecialDetails = "Huwbc khjadb kahdbckhadb ahkbch ahdbcahdbc ahdiyu jahdvcjhadb",
                    CreateDate = DateTime.Now
                }
                );
        }
    }
}
