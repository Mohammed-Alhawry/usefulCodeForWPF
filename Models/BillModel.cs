using System.Collections.ObjectModel;

namespace ExperimentalThingsUsingWPF.Models;

public class BillModel
{
    public int Id { get; set; }
    public int RequestId { get; set; }
    public RequestModel Request { get; set; }
    public DateTime BillDate { get; set; }
    public decimal TotalPrice { get; set; }
    public PaymentState PaymentState { get; set; }
    public ObservableCollection<PaymentModel> Payments { get; set; }
}
