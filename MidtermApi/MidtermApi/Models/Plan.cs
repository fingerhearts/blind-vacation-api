using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models
{
    /// <summary>
    /// plan class is the entire vacation, it will include everything that the user will needs; the city
    /// description, image, hotel, and activity. The recommendation code is what we are sending over to the mvc 
    /// team to be able to parse and display the vacation package.
    /// </summary>
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