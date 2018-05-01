using System.Collections.Generic;
using System.Linq;

namespace pizza.core
{
    public class PizzaComparer : IEqualityComparer<Pizza>
    {
        public bool Equals(Pizza x, Pizza y)
        {
            if (x.Toppings.Count != y.Toppings.Count)
                return false;

            foreach (var component in x.Toppings)
            {                
                if (y.Toppings.Count(p => p.Contains(component)) !=
                    x.Toppings.Count(p => p.Contains(component)))
                    return false;

            }
            
            return true;
        }

        public int GetHashCode(Pizza x)
        {
            return x.Toppings.Aggregate(0, (a, y) => a ^ y.GetHashCode());
        }
    }
}