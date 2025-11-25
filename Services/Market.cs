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

            }
        }
        public static void MarketProducts()
        {

        }


    }
}