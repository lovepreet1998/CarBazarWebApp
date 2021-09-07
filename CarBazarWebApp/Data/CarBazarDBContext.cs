using CarBazarWebApp.BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBazarWebApp.Data
{
    public class CarBazarDBContext : DbContext
    {
        public CarBazarDBContext(DbContextOptions<CarBazarDBContext> options)
            : base(options)
        {
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
