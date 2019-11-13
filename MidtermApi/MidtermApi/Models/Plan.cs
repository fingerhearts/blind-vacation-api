using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models
{
    public class Plan
    {
        public int ID { get; set; }

        public int CityID { get; set; }

        public int HotelID { get; set; }

        public int ActivityID { get; set; }

        public int RecommendationCode { get; set; }

        //nav prop. (ck)
    }
}
