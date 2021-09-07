using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBazarWebApp.BusinessLayer
{
    public class Car
    {
        // Represent Car ID 
        public int Id { get; set; }

        // Represent Car No
        public string CarNo { get; set; }

        // Represent Model ID
        public int ModelID { get; set; }

        public Model Model { get; set; }

        // Represent Car Model Year
        public int ModelYear { get; set; }

        // Represent Owner Name
        public string OwnerName { get; set; }

        // Represent Contact No
        public string ContactNo { get; set; }
    }
}
