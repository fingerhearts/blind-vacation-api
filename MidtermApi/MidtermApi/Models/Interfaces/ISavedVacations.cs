using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models.Interfaces
{
    interface ISavedVacations
    {
        //getting all saved vacations 
        IEnumerable <SavedVacation> GetAllSavedVacations();

    }
}
