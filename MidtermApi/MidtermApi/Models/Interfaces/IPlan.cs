using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models.Interfaces
{
    public interface IPlan
    {
        //Gets a city 
        Task<Plan> GetPlan(int CityID);

        //Gets activites listed in the city
        Task<Activity> GetActivityInCity(int CityID);

        Task<Hotel> GetHotelInCity(int CityID);
    }
}
