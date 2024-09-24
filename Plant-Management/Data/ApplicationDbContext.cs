using Microsoft.EntityFrameworkCore;

namespace Plant_Management.Models;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }
    
    public DbSet<Plant> Plants { get; set; }
    public DbSet<PlantType> PlantTypes { get; set; }
    public DbSet<SoilType> SoilTypes { get; set; }
    public DbSet<Location> Locations { get; set; }
}