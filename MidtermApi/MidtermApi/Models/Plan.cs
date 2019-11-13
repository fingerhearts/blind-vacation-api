using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models
{
    public class Plan
    {
        public int ID { get; set; }

        public City City { get; set; }

        public Hotel Hotel { get; set; }

        public Activity Activity { get; set; }

        public int RecommendationCode { get; set; }

        //nav prop. (ck)
        
    }
}