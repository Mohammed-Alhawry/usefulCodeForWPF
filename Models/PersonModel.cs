using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.Models;

public class PersonModel
{
    public int Id { get; set; }
    [Required]
    public string FullName { get; set; }
    public GenderType Gender { get; set; }
    [Required]
    public string Address { get; set; }
    [Required]
    public ObservableCollection<PersonContactModel> Contacts { get; set; }
}
