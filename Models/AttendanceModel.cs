using Microsoft.EntityFrameworkCore;

namespace ExperimentalThingsUsingWPF.Models;
[PrimaryKey(nameof(AttendanceTime), nameof(DepartureTime), nameof(EmployeeId))]
public class AttendanceModel
{
    public int EmployeeId { get; set; }
    public EmployeeModel Employee { get; set; }
    public DateTime AttendanceTime { get; set; }
    public DateTime DepartureTime { get; set; }
}