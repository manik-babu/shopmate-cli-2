using System;
using Shopmate.Services;
using Shopmate.Models;
using Shopmate.Utils;
class Program
{
    static void Main(string[] args)
    {
        ShopMateUtils.PageName("ShopMate CLI");
        Thread.Sleep(500);
        Console.WriteLine("Buy and sell anytime, anythings, anywhere!");
        Thread.Sleep(500);
        Users.Add("Md Manik", "manik", "1234");
        Auth.Authinticate();
    }
}