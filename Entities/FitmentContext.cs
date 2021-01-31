using Microsoft.EntityFrameworkCore;
using TireApi.Services;

namespace TireApi.Entities
{
    public class FitmentContext: DbContext
    {
        public FitmentContext(DbContextOptions<FitmentContext> options)
                : base(options)
                {
                    
                }
        public DbSet<OEMFitment> OEMFitments { get; set;}
        public DbSet<NonOEMFitment> NonOEMFitments { get; set;}

        public DbSet<Vehiclefitment> Vehiclefitments {get; set;}
        public DbSet<Vehicle> Vehicles { get; set; }

    }

}