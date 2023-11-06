namespace OnlineShop.Entities;

public class CartItem : BaseInformation
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public int ShoppingSessionId { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public ShoppingSession ShoppingSession { get; set; }    
}
