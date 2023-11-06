namespace OnlineShop.Entities;

public class Discount : ProductBaseInformation
{
    public int Id { get; set; }
    public string Name { get; set; }        // varchar
    public string Desc { get; set; }        // text
    public float DiscountPercent { get; set; }      // float
    public bool Active { get; set; }
    public ICollection<Product> Products { get; set; } = null!;
}
