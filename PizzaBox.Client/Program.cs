using System;
using System.Collections.Generic;
using PizzaBox.Domain.Model;
using PizzaBox.Storing.Repositories;


namespace PizzaBox.Client
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }
        private static void Run()
        {
            var order = new Order();

            System.Console.WriteLine("Welcome to Pizzabox");
            DisplayStoreMenu();

            order.Customer = new Order();
            order.Store = SelectStore();
            order.Pizzas = SelectPizza();

            ;
        }

        private static void DisplayOrder(Order pizzas)
        {
            Console.WriteLine($"Your order is: {pizzas}");
        }

        private static void DisplayPizzaMenu()
        {
            var index = 0;
            {
                Console.WriteLine($"{++index} - {item}");
            }
        }
        private static void DisplayStoreMenu()
        {
            var index = 0;

            {
                Console.WriteLine($"{++index} - {item}");
            }
        }

        private static Build SelectPizza()
        {
            var input = int.Parse(Console.ReadLine());

            DisplayOrder(pizza);

            return pizza;
        }
        private static Build SelectSize()
        {

            DisplaySize(size);
            return Size;
        }

        private static Store SelectStore()
        {
            var Store = (Console.ReadLine());

            DisplayPizzaMenu();

            return Stores.Stores;
        }

    }
}