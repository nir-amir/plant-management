using System.ComponentModel.DataAnnotations;

namespace Plant_Management.Models;

public class Plant
{
    [Key]
    public string Id { get; set; }
    
    [Required]
    [StringLength(100)]
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
    public double? LightLevel { get; set; }
    
    [Range(0, 10)]
    public double? MoistureLevel { get; set; }
    
    public double? MinTemperature { get; set; }
    
    public double? MaxTemperature { get; set; }
    
    public string? HumidityPreference { get; set; }
    
    public bool? IsToxic { get; set; }
    
    public string PlantTypeId { get; set; }
    
    public string SoilTypeId { get; set; }
    
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    
    public DateTime DateUpdated { get; set; } = DateTime.UtcNow;
    
    public DateTime DateExpired { get; set; }
}
