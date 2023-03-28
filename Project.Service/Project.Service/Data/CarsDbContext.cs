using Microsoft.EntityFrameworkCore;
using Project.Service.model;

namespace Project.Service.Data
{
    public class CarsDbContext : DbContext
    {
       public CarsDbContext(DbContextOptions options) : base(options)
       { 
       }

        public virtual DbSet<VehicleMake> VehicleMakes { get; set; } 
        public virtual DbSet<VehicleModel> VehicleModels { get; set; } 
    }
}
