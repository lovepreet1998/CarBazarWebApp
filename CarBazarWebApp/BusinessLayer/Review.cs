using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBazarWebApp.BusinessLayer
{
    public class Review
    {
        // Represent Review ID 
        public int Id { get; set; }

        // Represent Review Text
        public string ReviewText { get; set; }

        // Represent Rating
        public int Rating { get; set; }

        // Represent Model ID
        public int ModelID { get; set; }

        public Model Model { get; set; }
    }
}
