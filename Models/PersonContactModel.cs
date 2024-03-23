using System.ComponentModel.DataAnnotations;

namespace ExperimentalThingsUsingWPF.Models;

public class PersonContactModel

{
    public int PersonId { get; set; }
    public PersonModel Person { get; set; }
    [Required]
    public string ContactInfo { get; set; }
    public ContactType ContactType { get; set; }
}
