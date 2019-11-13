using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models.Interfaces
{
    public interface IPopular
    {
        //getting all saved vacations 
        IEnumerable <Plan> GetAllSavedVacations();
    }
}
