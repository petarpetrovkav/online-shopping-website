
namespace OnlineShop.Entities;

public class PaymentDetail : BaseInformation
{
    public int PaymentDetailId { get; set; }
    public string Provider { get; set; }
    public int Amount { get; set; }
    public string Status { get; set; }
    public OrderDetail OrderDetail { get; set; }
}
