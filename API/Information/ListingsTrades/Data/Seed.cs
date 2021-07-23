using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingsTrades.Models;

namespace ListingsTrades.Data
{
    public class Seed
    {
        public static async Task SeedData(ApplicationDBContext context)
        {
            if (context.Conditions.Any()) return;

            var conditions = new List<Conditions>
            {

            new Conditions
                {
                    Id = new Guid(),
                    Condition = "Home Inspection"
                },
                new Conditions
                {
                    Id = new Guid(),
                    Condition = "Financing "
                },
                new Conditions
                {
                    Id =  new Guid(),
                    Condition = "Income"
                },
                new Conditions
                {
                     Id = new Guid(),
                    Condition = "Lawyer Approval "
                }

            };

            await context.Conditions.AddRangeAsync(conditions);
            await context.SaveChangesAsync();

             if (context.PropertyTypes.Any()) return;

            var propertyTypes = new List<PropertyTypes>
            {

                new PropertyTypes
                {
                    Id = new Guid(),
                    Code = "CO",
                    Name = "COMMERCIAL",
                    Type = 'C',
                    ShortName = "CO",
                    Report2HO =  true,
                    RentalType = false
                },
                new PropertyTypes
                {
                    Id = new Guid(),
                    Code = "RS",
                    Name = "RESIDENTIAL",
                    Type = 'R',
                    ShortName = "RS",
                    Report2HO =  true,
                    RentalType = false
                }
            };

            await context.PropertyTypes.AddRangeAsync(propertyTypes);
            await context.SaveChangesAsync();

        }
    }
}