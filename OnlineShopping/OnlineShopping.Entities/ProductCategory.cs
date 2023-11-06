namespace OnlineShop.Entities;

public class ProductCategory : ProductBaseInformation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Desc { get; set; }
    public ICollection<Product> Products { get; set; } = null!;
}
