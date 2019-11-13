using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MidtermApi.Models
{
    public class Hotels
    {
        public int ID { get; set; }
        [Display(Name = "Cities ID")]
        public int CityID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        //Nav prop. (CK)
        public City City { get; set; }

    }
}
