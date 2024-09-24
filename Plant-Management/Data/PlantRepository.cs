using Microsoft.EntityFrameworkCore;
using Plant_Management.Utilities;

namespace Plant_Management.Models;

public class PlantRepository
{
    private readonly ApplicationDbContext _context;

    public PlantRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<PagedResult<Plant>> GetAllPlantsPaginatedAsync(int pageNumber, int pageSize)
    {
        var totalCount = await _context.Plants.CountAsync();
        
        var items = await _context.Plants
            .Skip(pageSize * (pageNumber - 1))
            .Take(pageSize)
            .ToListAsync();

        return new PagedResult<Plant>
        {
            TotalCount = totalCount,
            Items = items,
        };
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