using System.ComponentModel.DataAnnotations;

namespace ExperimentalThingsUsingWPF.Models;

public class DoctorContactModel
{
    public int DoctorId { get; set; }
    public DoctorModel Doctor { get; set; }
    [Required]
    public string ContactInfo { get; set; }
    public ContactType ContactType { get; set; }
}
