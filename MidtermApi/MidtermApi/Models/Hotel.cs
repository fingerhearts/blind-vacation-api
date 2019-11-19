using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models
{
    /// <summary>
    /// hotel class uses the cityid to get a hotel in that city. It will then display name and price. Thought about
    /// being able to edit the type of hotel based on price. Which would allow the user to be able to change from
    /// having a cheap hotel to having an expensive hotel in that city.
    /// </summary>
    public class Hotel
    {
        public int ID { get; set; }
        [Display(Name = "Cities ID")]
        public int CityID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}