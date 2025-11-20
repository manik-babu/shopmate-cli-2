using System;
namespace Ecommerce
{
    class Order
    {
        public int OrderId { get; set; }
        public string OrderedBy { get; set; }
        public string OrderedTo { get; set; }
        public string Status { get; set; }  // Status would be Pending, Confirmed
        public Product Product { get; set; }

        public Order(int orderId, string orderedBy, string orderedTo, Product product)
        {
            this.OrderId = orderId;
            this.OrderedBy = orderedBy;
            this.OrderedTo = orderedTo;
            this.Status = "Pending";
            this.Product = product;
        }
        public void Show()
        {
            Console.WriteLine("Order id: " + OrderId);
            Console.WriteLine("Status: " + Status);
            Console.WriteLine($"Ordered by {OrderedBy} and ordered to {OrderedTo}");
            Console.WriteLine("Product: " + Product.Title);
        }
    }
    class Orders
    {
        private Order[] orders = new Order[200];
        private int OrderCount;
        public Orders()
        {
            this.OrderCount = 0;
        }
        public void add(string orderedBy, string orderedTo, Product product)
        {
            orders[OrderCount] = new Order(++OrderCount, orderedBy, orderedTo, product);
        }
        public void GetStoreOrder(string userName, string status)
        {
            foreach (Order order in orders)
            {
                if (order.OrderedTo == userName && order.Status == status)
                {
                    order.Show();
                }
            }
        }
        public void GetCustomerOrders(string userName, string status)
        {
            foreach (Order order in orders)
            {
                if (order.OrderedBy == userName && order.Status == status)
                {
                    order.Show();
                }
            }
        }
    }
}