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

        /// <summary>
        /// This method is reading all the activites, passing in the cityId as a parameter, then 
        /// creating a new variable called 'activity', then going into the Activity table located in our Db and
        /// finding the activites that match the cityID that we passed in as the parameter. And since we have 
        /// multiple activites per city, we are making the 'activity' variable a list of all the activites in that city
        /// then returning it.
        /// </summary>
        /// <param name="CityID"></param>
        /// <returns></returns>
        public async Task <IEnumerable<Activity>> GetActivitiesInCity(int CityID)
        {
            var activity = await _context.Activity.Where(x => x.CityID == CityID).ToListAsync();
            return activity;
        }

     
        /// <summary>
        /// 'GetCity' method is taking in a cityID which is what we will use to find the specific city.
        /// We then create a new instance of city, go into the Db and use the FindAsync built in method to locate
        /// the specific city using the cityID that we passed in as a parameter in this method.
        /// </summary>
        /// <param name="CityID"></param>
        /// <returns></returns>
        public async Task<City> GetCity(int CityID)
        {
            City city = await _context.City.FindAsync(CityID);
            return city;
        }

        /// <summary>
        /// This method is reading all the hotels, passes the cityId that in as a parameter, then 
        /// creating a new variable called 'hotel', then going into the hotel table located in our Db and
        /// finding the hotels that match the cityID that we passed in as the parameter. And since we have 
        /// three hotels per city, we are making the 'hotel' variable a list of the three hotels in that city
        /// then returning it.
        /// </summary>
        /// <param name="CityID"></param>
        /// <returns></returns>
        public async Task <IEnumerable<Hotel>> GetHotelsInCity(int CityID)
        {
            var hotel = await _context.Hotel.Where(x=> x.CityID == CityID).ToListAsync();
            return hotel;
        }
    }
}
