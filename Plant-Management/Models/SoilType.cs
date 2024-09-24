using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Plant_Management.Models;

public class SoilType
{
    public string Id { get; init; }

    [Required] [StringLength(100)] public string Name { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    
    public ICollection<Plant> Plants { get; set; } = new List<Plant>();
}