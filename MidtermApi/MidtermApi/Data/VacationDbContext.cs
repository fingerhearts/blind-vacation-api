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
            modelBuilder.Entity<Hotels>().HasKey(Hotels =>
              new { Hotels.CitiesID });

            modelBuilder.Entity<Hotels>().HasKey(Activities =>
              new { Activities.CitiesID });

        
            modelBuilder.Entity<Cities>().HasData(
                new Cities
                {
                    ID = 1,
                    Name = "Seattle",
                    Description = "test",
                    ImageURL = "",
                    Hot = false,
                    InUSA = true,
                    Price = 20
                },
                new Cities
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
            modelBuilder.Entity<Hotels>().HasData(
               new Hotels
               {
                   ID = 1,
                   Name = "Test INN",
                   Price = 80
               },
               new Hotels
               {
                   ID = 2,
                   Name = "Test INN 2",
                   Price = 50
               }
               );

            modelBuilder.Entity<Activities>().HasData(
               new Activities
               {
                   ID = 1,
                   Name = "Activity 1",
                   FamilyFriendly = true,
                   Outdoors = false
               },
               new Activities
               {
                   ID = 2,
                   Name = "Activity 2",
                   FamilyFriendly = false,
                   Outdoors = false
               }
               );

            modelBuilder.Entity<SavedVacation>().HasData(
               new SavedVacation
               {
                   ID = 1,
                   Name = "saved vacation 1",
                   RecommendationCode = 1234
               },
               new SavedVacation
               {
                   ID = 2,
                   Name = "saved vacation 2",
                   RecommendationCode = 4321
               }
               );
        }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Hotels> Hotels { get; set; }
        public DbSet<Activities> Activities { get; set; }
        public DbSet<SavedVacation> SavedVacation { get; set; }
    }
}
