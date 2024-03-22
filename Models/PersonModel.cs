using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentalThingsUsingWPF.Models;

public class PersonModel
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public GenderType Gender { get; set; }
    public string Address { get; set; }
    public PersonContactModel Contact { get; set; }
}
