using System;
namespace MidtermApi.Models
{
    public class Plan
    {
        public int ID { get; set; }
        public Cities Cities { get; set; }
        public Hotels Hotels { get; set; }
        public Activities Activities { get; set; }
    }
}
