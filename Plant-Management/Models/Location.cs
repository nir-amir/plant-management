using System.ComponentModel.DataAnnotations;

namespace Plant_Management.Models;

public class Location
{
    [Key]
    public string Id { get; init; }
    
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    public string? Description { get; set; } = string.Empty;
    
    public ICollection<Plant> Plants { get; set; }
}