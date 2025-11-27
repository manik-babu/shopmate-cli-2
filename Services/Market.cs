using Shopmate.Utils;
using Shopmate.Models;
namespace Shopmate.Services
{
    static class Market
    {
        public static void Interface()
        {
            ShopMateUtils.PageName("Market");
            Console.WriteLine("1. Products");
            Console.WriteLine("2. My carts");
            Console.WriteLine("3. My orders");
            Console.WriteLine("0. Back to home page");
            int choice = ShopMateUtils.ReadChoice(new int[] { 0, 1, 2, 3 });

            switch (choice)
            {
                case 0:
                    App.Home();
                    break;
                case 1:
                    ShopMateUtils.PageName("Products");
                    MarketProducts(0, 5);
                    break;

            }
        }
        public static void MarketProducts(int start, int end)
        {
            Console.WriteLine("---------------------------------------------");
            Shopmate.Models.Products.ShowProducts(start, end);
            Console.WriteLine("1. See more");
            Console.WriteLine("2. Add to cart");
            Console.WriteLine("0. Back to market");
            int choice = ShopMateUtils.ReadChoice(new int[] { 0, 1, 2 });

            switch (choice)
            {
                case 0:
                    Interface();
                    break;
                case 1:
                    MarketProducts(end + 1, end + 5);
                    break;
            }

        }
        public static void AddToCart(int productId)
        {

        }

    }
}