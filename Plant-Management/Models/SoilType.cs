using System.ComponentModel.DataAnnotations;

namespace Plant_Management.Models;

public class SoilType
{
    public string Id { get; set; }
    
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public ICollection<Plant> Plants { get; set; }
}