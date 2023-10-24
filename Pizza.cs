using System;

namespace MiProyecto
{
    public class Pizza
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
    public string?[] Toppings { get; set; }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine("Toppings:");
            foreach (var topping in Toppings)
            {
                Console.WriteLine($"- {topping}");
            }
        }
    }
}
