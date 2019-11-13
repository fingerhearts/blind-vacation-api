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
    [Route("api/[controller]")]
    [ApiController]
    public class SavedVacationsController : ControllerBase
    {
        private readonly ISavedVacations _saved;

        public SavedVacationsController(ISavedVacations saved)
        {
            _saved = saved;
        }

        [HttpGet]
        public IEnumerable<SavedVacation> SendSavedVacation()
        {
            return _saved.GetAllSavedVacations().ToList();
        }

    }
}
