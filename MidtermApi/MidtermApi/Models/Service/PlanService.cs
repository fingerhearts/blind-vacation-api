using Microsoft.EntityFrameworkCore;
using MidtermApi.Data;
using MidtermApi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models.Service
{
    public class PlanService : IPlan
    {
        private VacationDbContext _context;

        public PlanService(VacationDbContext context)
        {
            _context = context;
        }

        public async Task<Plan> GetPlan(int cityID)
        {
            City city = await _context.City.FindAsync(cityID);
            Hotel hotel = await _context.Hotel.FindAsync(1);
            Activity activity = await _context.Activity.FindAsync(1);

            Plan plan = new Plan();
            plan.City = city;
            plan.Hotel = hotel;
            plan.Activity = activity;

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
