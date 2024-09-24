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

    public async Task<Plant> GetPlantByIdAsync(int id)
    {
        return await _context.Plants.FindAsync(id);
    }

    public async Task<Plant> CreatePlantAsync(Plant plant)
    {
        _context.Plants.Add(plant);
        await _context.SaveChangesAsync();
    }

    public async Task<Plant> UpdatePlantAsync(Plant plant)
    {
        _context.Plants.Update(plant);
        await _context.SaveChangesAsync();
    }

    public async Task DeletePlantAsync(Plant plant)
    {
        _context.Plants.Remove(plant);
        await _context.SaveChangesAsync();
    }
        
}