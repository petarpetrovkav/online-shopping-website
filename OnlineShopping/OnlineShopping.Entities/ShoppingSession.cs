namespace OnlineShop.Entities;

public class ShoppingSession : BaseInformation
{
    public int UserId { get; set; }
    public decimal Total { get; set; }
    //public string UserId { get; set; }
    public User User { get; set; }
    public ICollection<CartItem> CartItems { get; set; }
}
