namespace ExperimentalThingsUsingWPF.Models;

public class RequestModel
{
    public int Id { get; set; }
    public int ClinicId { get; set; }
    public DateTime RequestData { get; set; }
    public DateTime DeliveryDate { get; set; }
    public int WorkTypeId { get; set; }
}