using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models.Interfaces
{
    /// <summary>
    /// The IPlan interface is able to get a plan (vacation package), get an activity in that specific city
    /// (which will display 3 activities in one long string), and it will also get a specific hotel in the city
    /// using the cityID
    /// </summary>
    public interface IPlan
    {
        //Gets a city 
        Task<Plan> GetPlan(string answers);

        //Gets activites listed in the city
        Task<Activity> GetActivityInCity(int CityID);

        Task<Hotel> GetHotelInCity(int CityID);
    }
}
