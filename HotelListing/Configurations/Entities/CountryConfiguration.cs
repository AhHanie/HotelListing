using HotelListing.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
