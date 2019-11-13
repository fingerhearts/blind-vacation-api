using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name = "Image Url")]
        public string ImageURL { get; set; }
        public bool Hot { get; set; }
        public bool InUSA { get; set; }
        public int Price { get; set; }
    }
}
