using System.ComponentModel.DataAnnotations;

namespace ExperimentalThingsUsingWPF.Models;

public class EmployeeContactModel
{
    public int EmployeeId { get; set; }
    public EmployeeModel Employee { get; set; }
    [Required]
    public string ContactInfo { get; set; }
    public ContactType ContactType { get; set; }
}
