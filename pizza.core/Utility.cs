using System.Collections.Generic;
using System.Linq;

namespace pizza.core
{
    public class Utility
    {
        public Dictionary<Pizza, int> getMostPopular(List<Pizza> list, int quantity)
        {
            var pizzaComparer = new PizzaComparer();                        
        
            var res = list.GroupBy(p => p, pizzaComparer)
                .Select(group => new
                {
                    Pizza = group.Key,
                    Count = group.Count()
                })
                .OrderByDescending(x => x.Count).Take(quantity).ToDictionary(t => t.Pizza, t=> t.Count);

            return res;
                        
        }
    }
}