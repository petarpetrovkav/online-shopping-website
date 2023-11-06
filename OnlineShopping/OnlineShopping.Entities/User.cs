namespace OnlineShop.Entities
{
    public class User : BaseInformation
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public ShoppingSession ShoppingSession { get; set; }    
        public OrderDetail OrderDetail { get; set; }
        public ICollection<UserAddres> userAddresses { get; set; }
        public ICollection<UserPayment> userPayments { get; set; }

        

    }
}
