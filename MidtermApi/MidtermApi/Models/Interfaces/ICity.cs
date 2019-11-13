using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models.Interfaces
{
    public interface ICity
    {
        //Gets a city 
        Task<Cities> GetCity(int CityID);

        //Gets cities
        Task <IEnumerable<Cities>> GetCities(string answer);

        //Gets activites listed in the city
        Task <IEnumerable<Activities>> GetActivitiesInCity(int CityID);

        Task <IEnumerable<Hotels>> GetHotelsInCity(int CityID);

    }
}
