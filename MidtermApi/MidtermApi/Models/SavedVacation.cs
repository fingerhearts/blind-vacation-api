using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models
{
    public class SavedVacation
    {
        public int ID { get; set; }
        public Cities CitiesID { get; set; }
        public string Name { get; set; }
        public int RecommendationCode { get; set; }

        //nav prop. (ck)
        public Cities Cities { get; set; }
    }
}
