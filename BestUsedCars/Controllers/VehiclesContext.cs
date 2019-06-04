using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestUsedCars.Models
{
    public class VehiclesContext : DbContext
    {// Can I just display the Context instead of a a LINQ 
        private const string ConnectionString = @"server = (localdb)\MSSQLLocalDB; database=BestUsedCarsVehicles;trusted_connection=true";
        public DbSet<PurchasedVehicle> Vehicles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
