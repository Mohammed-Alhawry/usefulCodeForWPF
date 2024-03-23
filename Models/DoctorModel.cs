using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ExperimentalThingsUsingWPF.Models;


public class DoctorModel : PersonModel
{
    public int ClinicId { get; set; }
}


