using System.ComponentModel.DataAnnotations;
using Plant_Management.Validation;

namespace Plant_Management.Models;

public class Plant
{
    [Key]
    public string Id { get; init; } = Guid.NewGuid().ToString();
    
    [Required(ErrorMessage = "Custom name is required")]
    [StringLength(100, ErrorMessage = "Custom name cannot exceed 100 characters")]
    public string CustomName { get; set; }
    
    [StringLength(100)]
    public string Genus { get; set; } = string.Empty;
    
    [StringLength(100)]
    public string Species { get; set; } = string.Empty;
    
    public string Cultivar { get; set; } = string.Empty;
    
    public string CommonName { get; set; } = string.Empty;
    
    [Range(0, double.MaxValue)]
    public double Height { get; set; }
    
    [Range(0, double.MaxValue)]
    public double Width { get; set; }
    
    [Range(0, 100)]
    public int? LightLevel { get; set; }
    
    [Range(0, 10)]
    public int? MoistureLevel { get; set; }
    
    [TemperatureRange]
    public int? MinTemperature { get; set; }
    
    public int? MaxTemperature { get; set; }
    
    public string? HumidityPreference { get; set; }
    
    public bool? IsToxic { get; set; }
    
    public string? PlantTypeId { get; set; }
    
    public string? SoilTypeId { get; set; }
    
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime DateCreated { get; init; } = DateTime.UtcNow;
    
    public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    
    public DateTime DateExpired { get; set; }
}
