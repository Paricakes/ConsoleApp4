using System;
using System.Collections.Generic;

namespace OrderingSystem
{
    class Program
    {
        static List<(string, double)> orders = new List<(string, double)>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add new item");
                Console.WriteLine("2. View order summary");
                Console.WriteLine("3. Place Order");
                Console.WriteLine("4. Total Price of Order");
                Console.WriteLine("5. Exit");

                Console.Write("Please enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewItem();
                        break;
                    case "2":
                        ViewOrderSummary();
                        break;
                    case "3":
                        PlaceOrder();
                        break;
                    case "4":
                        DisplayTotalPrice();
                        break;
                    case "5":
                        Console.WriteLine("Thank you for using the ordering system. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        static void AddNewItem()
        {
            Console.Write("Enter the name of the item: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter the price of the item: ");
            double itemPrice = Convert.ToDouble(Console.ReadLine());

            orders.Add((itemName, itemPrice));
            Console.WriteLine("Item added to the order.");
        }

        static void ViewOrderSummary()
        {
            if (orders.Count == 0)
            {
                Console.WriteLine("No items in the order.");
            }
            else
            {
                Console.WriteLine("Order Summary:");
                for (int i = 0; i < orders.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {orders[i].Item1}: ${orders[i].Item2}");
                }
            }
        }

        static void PlaceOrder()
        {
            if (orders.Count == 0)
            {
                Console.WriteLine("No items in the order. Cannot place empty order.");
            }
            else
            {
                double totalPrice = 0;
                foreach ((string, double) order in orders)
                {
                    totalPrice += order.Item2;
                }
                Console.WriteLine($"Total price of the order: ${totalPrice}");
                orders.Clear();
                Console.WriteLine("Order placed successfully.");
            }
        }

        static void DisplayTotalPrice()
        {
            double totalPrice = 0;
            foreach ((string, double) order in orders)
            {
                totalPrice += order.Item2;
            }
            Console.WriteLine($"Total price of the order: ${totalPrice}");
        }
    }
}
