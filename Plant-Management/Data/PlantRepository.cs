using Microsoft.EntityFrameworkCore;

namespace Plant_Management.Models;

public class PlantRepository
{
    private readonly ApplicationDbContext _context;

    public PlantRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Plant>> GetAllPlantsAsync()
    {
        return await _context.Plants.ToListAsync();
    }

    public async Task<Plant> GetPlantByIdAsync(string id)
    {
        return await _context.Plants.FindAsync(id);
    }

    public async Task<Plant> CreatePlantAsync(Plant plant)
    {
        _context.Plants.Add(plant);
        await _context.SaveChangesAsync();
        return plant;
    }

    public async Task<Plant> UpdatePlantAsync(Plant plant)
    {
        var existingPlant = await _context.Plants.FindAsync(plant.Id);

        if (existingPlant == null)
        {
            return null;
        }
        
        _context.Plants.Update(plant);
        await _context.SaveChangesAsync();
        return existingPlant;
    }

    public async Task DeletePlantAsync(Plant plant)
    {
        _context.Plants.Remove(plant);
        await _context.SaveChangesAsync();
    }
        
}