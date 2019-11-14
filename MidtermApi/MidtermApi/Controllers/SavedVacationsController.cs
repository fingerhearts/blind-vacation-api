using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MidtermApi.Models;
using MidtermApi.Models.Interfaces;

namespace MidtermApi.Controllers
{
    /// <summary>
    /// in the savedvacationsController we are injecting the iPopular interface which will allow us
    /// to be able to use the GetAllSavedVacations method. Which, we us in the 'SendSavedVacation' method
    /// to be able to get all the saved vacations and return it as a list.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SavedVacationsController : ControllerBase
    {
        private readonly IPopular _saved;

        public SavedVacationsController(IPopular saved)
        {
            _saved = saved;
        }

        [HttpGet]
        public IEnumerable<Plan> SendSavedVacation()
        {
            return _saved.GetAllSavedVacations().ToList();
        }

    }
}
