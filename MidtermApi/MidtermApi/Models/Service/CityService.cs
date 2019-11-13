using Microsoft.EntityFrameworkCore;
using MidtermApi.Data;
using MidtermApi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models.Service
{
    public class CityService : ICity
    {
        private VacationDbContext _context;

        public CityService(VacationDbContext context)
        {
            _context = context;
        }

        public async Task <IEnumerable<Activity>> GetActivitiesInCity(int CityID)
        {
            var acivity = await _context.Activity.Where(x => x.CityID == CityID).ToListAsync();
            return acivity;
        }

     

        public async Task<City> GetCity(int CityID)
        {
            City city = await _context.City.FindAsync(CityID);
            return city;
        }

        public async Task <IEnumerable<Hotel>> GetHotelsInCity(int CityID)
        {
            var hotel = await _context.Hotel.Where(x=> x.CityID == CityID).ToListAsync();
            return hotel;
        }
    }
}
