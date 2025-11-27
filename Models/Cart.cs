namespace Shopmate.Models
{
    interface ICart
    {
        public string ShopOwner { get; set; }
        public string Customer { get; set; }
        public int Quantity { get; set; }
        public Product product { get; set; }
    }
    class Cart : ICart
    {
        public string ShopOwner { get; set; }
        public string Customer { get; set; }
        public int Quantity { get; set; }
        public Product product { get; set; }

        public Cart(string shopOwner, string customer, int quantity, Product product)
        {
            this.ShopOwner = shopOwner;
            this.Customer = customer;
            this.Quantity = quantity;
            this.product = product;
        }

    }
}