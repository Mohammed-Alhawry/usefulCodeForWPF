using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ExperimentalThingsUsingWPF.Models;

public class ClinicModel
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Address { get; set; }
    [Required]
    public ObservableCollection<ClinicContactModel> Contacts { get; set; }
    public ObservableCollection<RequestModel> Requests { get; set; }
}

