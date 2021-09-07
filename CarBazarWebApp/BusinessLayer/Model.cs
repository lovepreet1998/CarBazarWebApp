using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBazarWebApp.BusinessLayer
{
    public class Model
    {
        // Represent Model ID 
        public int Id { get; set; }

        // Represent Model Name
        public string ModelName { get; set; }

        // Represent Company ID
        public int CompanyID { get; set; }

        public Company Company { get; set; }
    }
}
