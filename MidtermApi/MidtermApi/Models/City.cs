using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models
{
    /// <summary>
    /// created city class that will give the user a description and an image of the city. The survey will have questions
    /// regarding the hot, inUSA, and price properties.
    /// </summary>
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Display(Name = "Image Url")]
        public string ImageURL { get; set; }
        public int Hot { get; set; }
        public int InUSA { get; set; }
        public int Price { get; set; }
    }
}