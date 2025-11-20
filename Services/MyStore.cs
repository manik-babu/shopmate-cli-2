using Shopmate.Utils;
namespace Shopmate.Services
{
    static class Store
    {
        public static void Interface()
        {
            if (Auth.loggedInUser.ShopName == "-")
            {
                Console.WriteLine("Looks like you don’t have a shop yet.");
                Console.WriteLine("Do you want to set up your shop now?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                int choice = ShopMateUtils.ReadChoice(new int[] { 1, 2 });
                if (choice == 1)
                {
                    Console.WriteLine("Let’s get you started!");
                    Console.Write("Enter the desired name for your shop: ");
                    string shopName = Console.ReadLine();
                    Auth.loggedInUser.ShopName = shopName;
                    ShopMateUtils.Loading("Creating", 1500);
                    Console.WriteLine("Great! Your shop is now created and ready to use.");

                }
                else
                {
                    App.Home();
                }
            }
            else
            {
                Console.WriteLine("Welcome to your store");
            }
        }

    }
}