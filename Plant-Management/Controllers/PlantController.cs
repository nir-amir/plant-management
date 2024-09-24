using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Plant_Management.Models;

namespace Plant_Management.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlantController : ControllerBase
{
    private readonly PlantRepository _repository;

    public PlantController(PlantRepository repository)
    {
        _repository = repository;
    }
    
    // GET: api/plant
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Plant>>> GetPlants()
    {
        var plants = await _repository.GetAllPlantsAsync();
        return Ok(plants);
    }
    
    // GET: api/plant/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Plant>> GetPlant([FromBody] string id)
    {
        var plant = await _repository.GetPlantByIdAsync(id);
        if (plant == null)
        {
            return NotFound();
        }
        return Ok(plant);
    }
    
    // POST: api/plant
    [HttpPost]
    public async Task<ActionResult<Plant>> PostPlant([FromBody] Plant plant)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        
        await _repository.CreatePlantAsync(plant);
        return CreatedAtAction(nameof(GetPlant), new { id = plant.Id }, plant);
    }
    
    // PUT: api/plant/{id}
    [HttpPut("{id}")]
    public async Task<ActionResult<Plant>> PutPlant([FromBody] string id, Plant plant)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        
        if (id != plant.Id)
        {
            return BadRequest();
        }
        
        await _repository.UpdatePlantAsync(plant);
        return Ok(plant);
    }
    
    // DELETE: api/plant/{id}
    [HttpDelete("{id}")]
    public async Task<ActionResult<Plant>> DeletePlant([FromBody] string id)
    {
        var plant = await _repository.GetPlantByIdAsync(id);
        if (plant == null)
        {
            return NotFound();
        }
        
        await _repository.DeletePlantAsync(plant);
        return NoContent();
    }
}