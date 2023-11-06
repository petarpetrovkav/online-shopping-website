namespace OnlineShop.Entities;

public class OrderItem : BaseInformation
{
    public int Id { get; set; }
    public int OrderDetailsId { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public OrderDetail OrderDetail { get; set; }
}
