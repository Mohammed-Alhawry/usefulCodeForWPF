using System.Collections.ObjectModel;

namespace ExperimentalThingsUsingWPF.Models;

public class DoctorModel : PersonModel
{
    public ObservableCollection<DoctorContactModel> Contacts { get; set; }
    public int ClinicId { get; set; }
}


