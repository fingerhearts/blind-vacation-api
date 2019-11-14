using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MidtermApi.Data;
using MidtermApi.Models;
using MidtermApi.Models.Service;
using Xunit;

namespace APIUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetCityInfomation()
        {
            City testCity = new City();
            testCity.Name = "Seattle";
            testCity.Description = "Test";
            testCity.ImageURL = "test.url";
            testCity.Hot = 0;
            testCity.InUSA = 1;
            testCity.Price = 3;

            Assert.Equal("Seattle", testCity.Name);
            Assert.Equal("Test", testCity.Description);
            Assert.Equal("test.url", testCity.ImageURL);
            Assert.Equal(0, testCity.Hot);
            Assert.Equal(1, testCity.InUSA);
            Assert.Equal(3, testCity.Price);
        }

        [Fact]
        public void CanGetHotelInfomation()
        {
            Hotel testHotel = new Hotel();
            testHotel.CityID = 1;
            testHotel.Name = "Seattle Hotel";
            testHotel.Price = 3;

            Assert.Equal(1, testHotel.CityID);
            Assert.Equal("Seattle Hotel", testHotel.Name);
            Assert.Equal(3, testHotel.Price);
        }

        [Fact]
        public void CanGetActivityInfomation()
        {
            Activity testActivity = new Activity();
            testActivity.CityID = 1;
            testActivity.Name = "Seattle Strolling";
            testActivity.Outdoors = 1;
            testActivity.FamilyFriendly = 0;

            Assert.Equal(1, testActivity.CityID);
            Assert.Equal("Seattle Strolling", testActivity.Name);
            Assert.Equal(1, testActivity.Outdoors);
            Assert.Equal(0, testActivity.FamilyFriendly);
        }

        [Fact]
        public async Task CanGetPlan()
        {
            DbContextOptions<VacationDbContext> options = new DbContextOptionsBuilder<VacationDbContext>()
                .UseInMemoryDatabase("CanGetActivityInCity")
                .Options;
            using (VacationDbContext context = new VacationDbContext(options))
            {
                PlanService service = new PlanService(context);

                City testCity = new City();
                testCity.ID = 1;
                testCity.Name = "Seattle";
                testCity.Description = "Test";
                testCity.ImageURL = "test.url";
                testCity.Hot = 0;
                testCity.InUSA = 1;
                testCity.Price = 3;
                context.City.Add(testCity);
                await context.SaveChangesAsync();

                Hotel testHotel = new Hotel();
                testHotel.CityID = 1;
                testHotel.Name = "Seattle Hotel";
                testHotel.Price = 3;

                context.Hotel.Add(testHotel);
                await context.SaveChangesAsync();

                Activity testActivity = new Activity();
                testActivity.CityID = 1;
                testActivity.Name = "Seattle Strolling";
                testActivity.Outdoors = 1;
                testActivity.FamilyFriendly = 0;

                context.Activity.Add(testActivity);
                await context.SaveChangesAsync();

                Plan result = await service.GetPlan("1,0,3,0,1");

                Assert.Equal("Seattle", result.City.Name);
                Assert.Equal("Seattle Hotel", result.Hotel.Name);
                Assert.Equal("Seattle Strolling", result.Activity.Name);
            }
        }

        [Fact]
        public async Task CanGetActivityInCity()
        {
            DbContextOptions<VacationDbContext> options = new DbContextOptionsBuilder<VacationDbContext>()
                .UseInMemoryDatabase("CanGetActivityInCity")
                .Options;
            using (VacationDbContext context = new VacationDbContext(options))
            {
                PlanService service = new PlanService(context);
                Activity testActivity = new Activity();
                testActivity.CityID = 3;
                testActivity.Name = "Seattle Strolling";
                testActivity.Outdoors = 1;
                testActivity.FamilyFriendly = 0;

                context.Activity.Add(testActivity);
                await context.SaveChangesAsync();

                Activity result = await service.GetActivityInCity(3);

                Assert.Equal("Seattle Strolling", result.Name);
            }
        }

        [Fact]
        public async Task CanGetHotelsInCity()
        {
            DbContextOptions<VacationDbContext> options = new DbContextOptionsBuilder<VacationDbContext>()
                .UseInMemoryDatabase("CanGetHotelsInCity")
                .Options;
            using (VacationDbContext context = new VacationDbContext(options))
            {
                PlanService service = new PlanService(context);
                Hotel testHotel = new Hotel();
                testHotel.CityID = 1;
                testHotel.Name = "Seattle Hotel";
                testHotel.Price = 3;

                context.Hotel.Add(testHotel);
                await context.SaveChangesAsync();

                Hotel result = await service.GetHotelInCity(1);

                Assert.Equal("Seattle Hotel", result.Name);
            }
        }

        [Fact]
        public async Task SaveVacationPlanInDb()
        {
            DbContextOptions<VacationDbContext> options = new DbContextOptionsBuilder<VacationDbContext>()
                .UseInMemoryDatabase("SavingPlanInDb")
                .Options;

            City testCity = new City();
            testCity.ID = 1;
            testCity.Name = "Seattle";
            testCity.Description = "Test";
            testCity.ImageURL = "test.url";
            testCity.Hot = 0;
            testCity.InUSA = 1;
            testCity.Price = 3;

            Hotel testHotel = new Hotel();
            testHotel.ID = 1;
            testHotel.CityID = 1;
            testHotel.Name = "Seattle Hotel";
            testHotel.Price = 3;

            Activity testActivity = new Activity();
            testActivity.ID = 1;
            testActivity.Name = "Seattle Strolling";
            testActivity.Outdoors = 1;
            testActivity.FamilyFriendly = 0;

            using (VacationDbContext context = new VacationDbContext(options))
            {
                Plan testPlan = new Plan();
                testPlan.City= testCity;
                testPlan.Hotel = testHotel;
                testPlan.Activity = testActivity;
                // Convert RecommendationCode to a string type
                testPlan.RecommendationCode = testCity.ID + testHotel.ID + testActivity.ID;

                context.SavedVacation.Add(testPlan);
                await context.SaveChangesAsync();

                Plan result = await context.SavedVacation.FirstOrDefaultAsync(x => x.City == testPlan.City);

                Assert.Equal("Seattle", result.City.Name);
                Assert.Equal("Seattle Hotel", result.Hotel.Name);
                Assert.Equal("Seattle Strolling", result.Activity.Name);
                Assert.Equal(3, result.RecommendationCode);
            }
        }
    }
}
