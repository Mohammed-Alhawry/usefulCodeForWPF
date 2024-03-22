namespace ExperimentalThingsUsingWPF.Models;

public class PaymentModel
{
    public int Id { get; set; }
    public int BillId { get; set; }
    public DateTime PaymentDate { get; set; }
    public decimal PaidMoney { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
}
