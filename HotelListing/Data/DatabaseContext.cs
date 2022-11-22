using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; } 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    id = 1,
                    name = "Morocco",
                    ShortName = "MA"
                },
                new Country
                {
                    id = 2,
                    name = "Egypt",
                    ShortName = "Egy"
                },
                new Country
                {
                    id = 3,
                    name = "Emirates",
                    ShortName = "UAE"
                }               
                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    id = 1,
                    name = "Mamounia",
                    adress ="Marakkesh",
                    Rating=5,
                    CountryId=1
                },
                new Hotel
                {
                    id = 2,
                    name = "Pharon",
                    adress = "Cairo",
                    Rating = 5,
                    CountryId = 2
                },
                new Hotel
                {
                    id = 3,
                    name = "Khalifa",
                    adress = "Dubai",
                    Rating = 5,
                    CountryId = 3
                });
        }
    }
}
