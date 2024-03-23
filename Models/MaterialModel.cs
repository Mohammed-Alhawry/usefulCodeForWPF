using System.ComponentModel.DataAnnotations;

namespace ExperimentalThingsUsingWPF.Models;

public class MaterialModel
{
    public int Id { get; set; }
    [Required]
    public string ShortName { get; set; }
    [Required]
    public string FullName { get; set; }
    
}
