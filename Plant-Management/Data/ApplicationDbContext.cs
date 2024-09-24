using Microsoft.EntityFrameworkCore;

namespace Plant_Management.Models;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<PlantType>().HasData(
            new PlantType { Id = "1", Name = "Succulent" },
            new PlantType { Id = "2", Name = "Fern" }
        );

        modelBuilder.Entity<SoilType>().HasData(
            new SoilType { Id = "1", Name = "Sandy" },
            new SoilType { Id = "2", Name = "Loamy" }
        );

        modelBuilder.Entity<Plant>().HasData(
            new Plant
            {
                Id = "1",
                CustomName = "Fiddle Leaf Fig",
                Genus = "Ficus",
                Species = "Lyrata",
                Cultivar = "Standard",
                CommonName = "Fiddle Leaf Fig",
                Height = 1.5,
                Width = 1.0,
                LightLevel = 75,
                MoistureLevel = 3,
                MinTemperature = 18,
                MaxTemperature = 25,
                HumidityPreference = "Medium",
                IsToxic = true,
                PlantTypeId = "1", 
                SoilTypeId = "1",  
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow
            }
        );
    }
    
    public DbSet<Plant> Plants { get; set; }
    public DbSet<PlantType> PlantTypes { get; set; }
    public DbSet<SoilType> SoilTypes { get; set; }
    public DbSet<Location> Locations { get; set; }
}