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

        public async Task <IEnumerable<Activities>> GetActivitiesInCity(int CityID)
        {
            var acivity = await _context.Activities.Where(x => x.CitiesID == CityID).ToListAsync();
            return acivity;
        }

        public IEnumerable<Cities> GetCities()
        {
            return _context.Cities;
        }

        public async Task<Cities> GetCity(int CityID)
        {
            Cities city = await _context.Cities.FindAsync(CityID);
            return city;
        }

        public async Task <IEnumerable<Hotels>> GetHotelsInCity(int CityID)
        {
            var hotel = await _context.Hotels.Where(x=> x.CitiesID == CityID).ToListAsync();
            return hotel;
        }
    }
}
