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

        // If usa answer code is True, CityID  

        public async Task<City> GetCity(int CityID)
        {
            City city = await _context.Cities.FindAsync(CityID);
            return city;
        }

        public async Task <IEnumerable<Hotel>> GetHotelsInCity(int CityID)
        {
            var hotel = await _context.Hotels.Where(x=> x.CityID == CityID).ToListAsync();
            return hotel;
        }

        public async Task <IEnumerable<Activity>> GetActivitiesInCity(int CityID)
        {
            var acivity = await _context.Activities.Where(x => x.CityID == CityID).ToListAsync();
            return acivity;
        }
    }
}
