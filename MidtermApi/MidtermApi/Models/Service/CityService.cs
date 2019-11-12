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

        public IEnumerable<Activities> GetActivitiesInCity(int CityID)
        {
            return null;
        }

        public IEnumerable<Cities> GetCities()
        {
            throw new NotImplementedException();
        }

        public Task GetCity(int CityID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Hotels> GetHotelsInCity(int CityID)
        {
            throw new NotImplementedException();
        }
    }
}
