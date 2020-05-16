using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WellData.Core.Models;

namespace WellData.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Well> Wells { get; set; }
        public DbSet<Flow> Flows { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<WaterLevel> WaterLevels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../WellData.Infrastructure/Wells.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Well>().HasData(
                  new Well { Id = 1, DistrictNumber = 1, Elevation = 3421 },
                  new Well { Id = 2, DistrictNumber = 2, Elevation = 3221 },
                  new Well { Id = 3, DistrictNumber = 3, Elevation = 3321 }
            );

            modelBuilder.Entity<UnitType>().HasData(
                new UnitType { Id = 1, DisplayName = "Gallons Per Minute", Abbreviation = "GPM" },
                new UnitType { Id = 2, DisplayName = "Feet", Abbreviation = "ft" }
            );

            modelBuilder.Entity<Flow>().HasData(
                new Flow { Id = 1, WellId = 1, Date = new DateTime(2019, 1, 20), Rate = 234.23, UnitTypeId = 1 },
                new Flow { Id = 2, WellId = 1, Date = new DateTime(2019, 2, 20), Rate = 214.23, UnitTypeId = 1 },
                new Flow { Id = 3, WellId = 2, Date = new DateTime(2019, 1, 20), Rate = 274.23, UnitTypeId = 1 },
                new Flow { Id = 4, WellId = 2, Date = new DateTime(2019, 2, 20), Rate = 224.23, UnitTypeId = 1 },
                new Flow { Id = 5, WellId = 3, Date = new DateTime(2019, 1, 20), Rate = 214.23, UnitTypeId = 1 },
                new Flow { Id = 6, WellId = 3, Date = new DateTime(2019, 2, 20), Rate = 199.23, UnitTypeId = 1 }
            );

            modelBuilder.Entity<WaterLevel>().HasData(
                new WaterLevel { Id = 1, WellId = 1, Date = new DateTime(2019, 1, 20), DepthToWater = 234.23, UnitTypeId = 2 },
                new WaterLevel { Id = 2, WellId = 1, Date = new DateTime(2019, 2, 20), DepthToWater = 214.23, UnitTypeId = 2 },
                new WaterLevel { Id = 3, WellId = 2, Date = new DateTime(2019, 1, 20), DepthToWater = 274.23, UnitTypeId = 2 },
                new WaterLevel { Id = 4, WellId = 2, Date = new DateTime(2019, 2, 20), DepthToWater = 224.23, UnitTypeId = 2 },
                new WaterLevel { Id = 5, WellId = 3, Date = new DateTime(2019, 1, 20), DepthToWater = 214.23, UnitTypeId = 2 },
                new WaterLevel { Id = 6, WellId = 3, Date = new DateTime(2019, 2, 20), DepthToWater = 199.23, UnitTypeId = 2 }
            );
        }
    }
}
