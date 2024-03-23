namespace ExperimentalThingsUsingWPF.Models;

public class ClinicContactModel
{
    public int ClinicId { get; set; }
    public ClinicModel Clinic { get; set; }

    public string ContactInfo { get; set; }
    public ContactType ContactType { get; set; }
}


