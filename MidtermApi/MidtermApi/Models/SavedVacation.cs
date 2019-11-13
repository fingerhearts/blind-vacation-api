using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models
{
    public class SavedVacation
    {
        public int ID { get; set; }
        public int CityID { get; set; }
        public string Name { get; set; }
        public int RecommendationCode { get; set; }

        //nav prop. (ck)
        public City City { get; set; }
    }
}
