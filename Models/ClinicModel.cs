namespace ExperimentalThingsUsingWPF.Models;

public class ClinicModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public ClinicContactModel Contact { get; set; }
}

