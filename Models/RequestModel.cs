namespace ExperimentalThingsUsingWPF.Models;

public class RequestModel
{
    public int Id { get; set; }
    public int ClinicId { get; set; }
    public ClinicModel Clinic { get; set; }
    public DateTime RequestData { get; set; }
    public DateTime DeliveryDate { get; set; }
    public int WorkTypeId { get; set; }
    public WorkTypeModel WorkType { get; set; }
    public BillModel Bill { get; set; }
}