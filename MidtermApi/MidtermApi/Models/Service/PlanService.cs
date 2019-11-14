using Microsoft.EntityFrameworkCore;
using MidtermApi.Data;
using MidtermApi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MidtermApi.Models.Service
{
    public class PlanService : IPlan
    {
        private VacationDbContext _context;

        public PlanService(VacationDbContext context)
        {
            _context = context;
        }

        public async Task<Plan> GetPlan(string answers)
        {

            string test = "0,1,3,0,0";
            int[] numbers = test.Split(',').Select(Int32.Parse).ToArray();

            City city = await _context.City
               .Where(x => x.InUSA == numbers[0])
               .Where(x => x.Hot == numbers[1])
               .Where(x => x.Price == numbers[2])
               .FirstOrDefaultAsync();
            Hotel hotel = await _context.Hotel
               .Where(x => x.CityID == city.ID)
               .Where(x => x.Price == numbers[2])
               .FirstOrDefaultAsync();
            Activity activity = await _context.Activity
               .Where(x => x.CityID == city.ID)
               .Where(x => x.FamilyFriendly == numbers[3])
               .Where(x => x.Outdoors == numbers[4])
               .FirstOrDefaultAsync();

            Plan plan = new Plan();
            plan.City = city;
            plan.Hotel = hotel;

            return plan;
        }

        public async Task<Hotel> GetHotelInCity(int cityID)
        {
            Hotel hotel = await _context.Hotel.FirstOrDefaultAsync(x => x.CityID == cityID);
            return hotel;
        }

        public async Task<Activity> GetActivityInCity(int cityID)
        {
            var acivity = await _context.Activity.FirstOrDefaultAsync(x => x.CityID == cityID);
            return acivity;
        }
    }
}
