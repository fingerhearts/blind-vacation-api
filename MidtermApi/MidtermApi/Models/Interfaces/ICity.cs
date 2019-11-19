using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models.Interfaces
{
    /// <summary>
    /// ICity interface will be able to get a specific city using the cityID. This interface will also read all the 
    /// activities in that city by using the cityID. Lastly, it will read all the hotels available in a specific
    /// city, and its doing that by including the cityID in the parameter.
    /// </summary>
    public interface ICity
    {
        //Gets a city 
        Task<City> GetCity(int CityID);

        //Gets cities
        //IEnumerable<City> GetCities();

        //Gets activites listed in the city
        Task <IEnumerable<Activity>> GetActivitiesInCity(int CityID);

        Task <IEnumerable<Hotel>> GetHotelsInCity(int CityID);

    }
}
