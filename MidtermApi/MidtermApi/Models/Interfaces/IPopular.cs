using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models.Interfaces
{
    /// <summary>
    /// The IPopular interface will be able to read through the entire 'plan' (vacation package) and be 
    /// able to get all the plans (vacation packages) that were saved. 
    /// </summary>
    public interface IPopular
    {
        //getting all saved vacations 
        IEnumerable <Plan> GetAllSavedVacations();
    }
}
