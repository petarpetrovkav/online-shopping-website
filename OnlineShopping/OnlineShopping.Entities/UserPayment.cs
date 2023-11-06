using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Entities;

public class UserPayment
{
    public int Id { get; set; }
    public string PaymentType { get; set; }
    public string Provider { get; set; }
    public int AccountNo { get; set; }
    public DateTime Expiry { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
