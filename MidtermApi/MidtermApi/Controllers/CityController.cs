﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MidtermApi.Models;
using MidtermApi.Models.Interfaces;

namespace MidtermApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICity _city;
        
        public CityController (ICity city)
        {
            _city = city;
        }

        
        //[HttpGet]
        //public ActionResult<IEnumerable<City>> Get()
        //{
        //    return _city.GetCities().ToList();

        //}

        //+ ProcessSurvey(int surveyAnswers) : int recommendationCode

        [HttpGet("{id}")]
        public async Task<ActionResult<City>> GetCityAsync(int id)
        {
            City city = await _city.GetCity(id);

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);

        }
    }
}