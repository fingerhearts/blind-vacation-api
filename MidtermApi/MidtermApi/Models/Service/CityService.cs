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

        public async Task <IEnumerable<Cities>> GetCities(string answers)
        {
            string[] parsedAnswers = Regex.Split(answers, @"(usa|hot|price|children|outdoor)\W/g");
            List<int> converetedAnswers = new List<int>();
            for (int i = 0; i < parsedAnswers.Length; i++)
            {
                if(parsedAnswers[i] == "True")
                {
                    converetedAnswers[i] = 1;
                }
                else if (parsedAnswers[i] == "False")
                {
                    converetedAnswers[i] = 0;
                }
                else
                {
                    converetedAnswers[i] = Convert.ToInt32(parsedAnswers[i]);
                }
            }

            var city = await _context.Cities.Where(x => x.InUSA == converetedAnswers[0]).ToListAsync();


            return city;
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
