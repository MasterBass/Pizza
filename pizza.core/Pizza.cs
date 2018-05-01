using System;
using System.Collections.Generic;

namespace pizza.core
{
    public class Pizza
    {
        public Pizza(List<string> toppings)
        {
            Toppings = toppings;
        }

        public List<string> Toppings { get; private set; }

        public void Print()
        {            
            foreach (var topping in Toppings)
            {
                Console.WriteLine(topping);
            }
            
        }
    }
    
}