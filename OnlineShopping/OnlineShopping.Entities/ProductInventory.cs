namespace OnlineShop.Entities;

public class ProductInventory : ProductBaseInformation
{
    public int ProductId { get; set; }
    public string Quantity { get; set; }
    public Product Product { get; set; }
}
