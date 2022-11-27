// See https://aka.ms/new-console-template for more information
using ShopApp.Models;

Console.WriteLine("Hello, World!");
var products = new List<Product>();
var shoppingCard = new ShhopingCard();
shoppingCard.Products.Add(new Product { Tag = 1, ProductName = "Mleko", Price = 50.00M });
shoppingCard.Products.Add(new Product { Tag = 2, ProductName = "Coca Cola", Price = 40.00M });
shoppingCard.Products.Add(new Product { Tag = 3, ProductName = "Gum", Price = 1.00M });
shoppingCard.Products.Add(new Product { Tag = 4, ProductName = "Vodka", Price = 100.00M });

Console.WriteLine();
Console.WriteLine("Dzisiejsze produkty:");
Console.WriteLine();
shoppingCard.ShowProducts(shoppingCard.Products);
Console.WriteLine();
Console.Write("Wartość zakupów:");
Console.WriteLine($"{shoppingCard.GetPrice()}"); ;
Console.ReadLine();



