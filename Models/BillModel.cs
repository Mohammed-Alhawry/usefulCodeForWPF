namespace ExperimentalThingsUsingWPF.Models;

public class BillModel
{
    public int Id { get; set; }
    public int RequestId { get; set; }
    public DateTime BillDate { get; set; }
    public decimal TotalPrice { get; set; }
    public PaymentState PaymentState { get; set; }
}
