
namespace OnlineShop.Entities;

public class UserAddres
{
    public int Id { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Telephone { get; set; }
    public string Mobile { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }

}
