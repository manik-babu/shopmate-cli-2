// Creating a Product management database system.
// Where we can store product data and manage adding, and finding product

using System;
namespace Ecommerce
{
    class Product
    {
        public int ProductId { get; set; }
        public string Owner { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Product(int productId, string owner, string title, string description, int price)
        {
            this.ProductId = productId;
            this.Owner = owner;
            this.Title = title;
            this.Description = description;
            this.Price = price;
        }

        public void Details()
        {
            Console.WriteLine("Product id: " + ProductId);
            Console.WriteLine("Owner Name: " + Owner);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Price: " + Price);
        }

    }
    class Products
    {
        private Product[] products = new Product[1000];
        private int ProductCount;
        public Products()
        {
            this.ProductCount = 0;
        }
        public void Add(string owner, string title, string description, int price)
        {
            this.products[this.ProductCount] = new Product(++this.ProductCount, owner, title, description, price);
        }
        public void ShowAll(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                this.products[i].Details();
            }
        }
        public Product Get(int id)
        {
            return this.products[id - 1];
        }

    }
}