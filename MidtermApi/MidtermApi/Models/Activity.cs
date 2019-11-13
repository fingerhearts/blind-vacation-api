using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models
{
    public class Activity
    {
        public int ID { get; set; }
        public int CityID { get; set; }
        public string Name { get; set; }
        [Display(Name="Family Friendly")]
        public bool FamilyFriendly { get; set; }
        public bool Outdoors { get; set; }

        //nav prop. (ck)
        public City City { get; set; }
    }
}
