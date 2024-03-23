using System.ComponentModel.DataAnnotations;

namespace ExperimentalThingsUsingWPF.Models;

public class WorkTypeModel
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Info { get; set; }
    public decimal Price { get; set; }
    public RequestModel Request { get; set; }
}