using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ExperimentalThingsUsingWPF.Models;

public class EmployeeModel : PersonModel
{
    [Required]
    public string Qualification { get; set; }
    public EmployeeType EmployeeType { get; set; }
    public ObservableCollection<AttendanceModel> Attendances { get; set; }
}
