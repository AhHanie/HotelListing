using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                    new Country
                    {
                        Id = 1,
                        Name = "Egypt",
                        ShortName = "EG"
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Arabic",
                        ShortName = "AR"
                    },
                    new Country
                    {
                        Id = 3,
                        Name = "Horizon Zero Dawn",
                        ShortName = "HZD"
                    }
            );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hotel1",
                    Address = "Hotel1 Address",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hotel2",
                    Address = "Hotel2 Address",
                    CountryId = 2,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hotel3",
                    Address = "Hotel3 Address",
                    CountryId = 3,
                    Rating = 4
                }
            );
        }

    }
}
