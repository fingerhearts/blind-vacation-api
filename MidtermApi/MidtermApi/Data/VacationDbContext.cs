using Microsoft.EntityFrameworkCore;
using MidtermApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Data
{
    public class VacationDbContext : DbContext
    {
        public VacationDbContext(DbContextOptions<VacationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City
                {
                    ID = 1,
                    Name = "Seattle",
                    Description = "test",
                    ImageURL = "",
                    Hot = false,
                    InUSA = true,
                    Price = 20
                },
                new City
                {
                    ID = 2,
                    Name = "Los Angeles",
                    Description = "test2",
                    ImageURL = "",
                    Hot = true,
                    InUSA = true,
                    Price = 100
                }
                );

            modelBuilder.Entity<Hotel>().HasData(
               new Hotel
               {
                   ID = 1,
                   CityID = 1,
                   Name = "Test INN",
                   Price = 80
               },
               new Hotel
               {
                   ID = 2,
                   CityID = 2,
                   Name = "Test INN 2",
                   Price = 50
               }
               );

            modelBuilder.Entity<Activity>().HasData(
               new Activity
               {
                   ID = 1,
                   CityID = 1,
                   Name = "Activity 1",
                   FamilyFriendly = true,
                   Outdoors = false
               },
               new Activity
               {
                   ID = 2,
                   CityID = 2,
                   Name = "Activity 2",
                   FamilyFriendly = false,
                   Outdoors = false
               }
               );
        }
        public DbSet<City> City { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Activity> Activity { get; set; }
        public DbSet<Plan> SavedVacation { get; set; }
    }
}
