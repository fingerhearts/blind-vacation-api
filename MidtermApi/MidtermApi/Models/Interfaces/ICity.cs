using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models.Interfaces
{
    interface ICity
    {
        //Create city 
        Task GetCity(int CityID);

        //Get individual city
        IEnumerable<Cities> GetCities();

        //Get all cities
        IEnumerable<Activities> GetActivitiesInCity(int CityID);

        //Update city
        IEnumerable<Hotels> GetHotelsInCity(int CityID);

    }
}
