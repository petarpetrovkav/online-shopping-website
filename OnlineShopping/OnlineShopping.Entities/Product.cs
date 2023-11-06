namespace OnlineShop.Entities;

public class Product : ProductBaseInformation
{
    public int Id { get; set; }
    public string Name { get; set; }        // varchar
    public string Desc { get; set; }        // text
    public string Sku { get; set; }         // varchar
    //public string Category { get; set; }
    public decimal Price { get; set; }
    public int DiscountId { get; set; }
    public int ProductCategoryId { get; set; }
    public int InventoryId { get; set; }
    //public int OrderitemsId { get; set; }
    public OrderItem OrderItem { get; set; }
    public CartItem CartItem { get; set; }

    public ProductCategory ProductCategory { get; set; }
    public Discount Discount { get; set; }
    public ProductInventory ProductInventory { get; set; }

}
