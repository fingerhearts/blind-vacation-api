using MidtermApi.Data;
using MidtermApi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models.Service
{
    /// <summary>
    /// this service is implementing the IPopular interface, creating a method called 'GetAllSavedVacations'
    /// where its returning all the saved vacations from the Db table 'SavedVacation'.
    /// </summary>
    public class PopularService : IPopular
    {
        private VacationDbContext _context;

        public PopularService(VacationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Plan> GetAllSavedVacations()
        {
            return _context.SavedVacation;
        }
    }
}
