using System.ComponentModel.DataAnnotations;

namespace ExperimentalThingsUsingWPF.Models;

public class PaymentModel
{
    public int Id { get; set; }
    public int BillId { get; set; }
    public BillModel Bill { get; set; }
    public DateTime PaymentDate { get; set; }
    [Required]
    public string TransformReference { get; set; }
    public decimal PaidMoney { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
}
