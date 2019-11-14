﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models.Interfaces
{
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