using System.ComponentModel.DataAnnotations;

namespace Plant_Management.Models;

public class PlantType
{
    [Key]
    public string Id { get; init; }
    
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    
    public ICollection<Plant> Plants { get; set; } = new List<Plant>();
}