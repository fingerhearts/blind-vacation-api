using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models
{
    /// <summary>
    /// created an activity class with the properties that are used for the survey questions to narrow
    /// down the vacation to a specific vacation plan.
    /// </summary>
    public class Activity
    {
        public int ID { get; set; }
        public int CityID { get; set; }
        public string Name { get; set; }
        [Display(Name="Family Friendly")]
        public int FamilyFriendly { get; set; }
        public int Outdoors { get; set; }
    }
}