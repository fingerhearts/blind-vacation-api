using MidtermApi.Data;
using MidtermApi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models.Service
{
    public class SavedVacationsService : ISavedVacations
    {
        private VacationDbContext _context;

        public SavedVacationsService(VacationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<SavedVacation> GetAllSavedVacations()
        {
            return _context.SavedVacation;
        }
    }
}
