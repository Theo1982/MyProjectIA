using System;
using System.Collections.Generic;

namespace MiProyecto
{
    public static class Menu
    {
        public static List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza { Name = "Pepperoni", Price = 10.99M, Toppings = new[] { "Pepperoni", "Cheese" } },
            new Pizza { Name = "Margherita", Price = 9.99M, Toppings = new[] { "Tomato Sauce", "Mozzarella Cheese", "Basil" } },
            new Pizza { Name = "Hawaiian", Price = 12.99M, Toppings = new[] { "Ham", "Pineapple", "Cheese" } },
        };

        public static void Print()
        {
            Console.WriteLine("Menu:");
            foreach (var pizza in Pizzas)
            {
                pizza.Print();
                Console.WriteLine();
            }
        }
    }
}
