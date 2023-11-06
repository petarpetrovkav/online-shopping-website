using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Entities;

public class OrderDetail : BaseInformation
{
    public int PaymentDetailId { get; set; }
    public decimal Total { get; set; }
    public int UserId { get; set; }
    //public int PaymentDetailId { get; set; }
    public PaymentDetail PaymentDetail { get; set; }
    public User User { get; set; }
    public ICollection<OrderItem> Orderitems { get; set; }
}
