using System.Collections.Generic;
using pizza.core;
using Xunit;

namespace pizza.test
{
    public class PizzaTest
    {
        [Fact]
        public void OneComponentTest()
        {
            var pizzaX = new Pizza(new List<string>
            {
                "feta cheese"
            });
            
            var pizzaY = new Pizza(new List<string>
            {
                "pepperoni"
            });
            
            var pizzaZ = new Pizza(new List<string>
            {
                "pepperoni"
            });
            
            var pizzaComparer = new PizzaComparer();
            
                        
            Assert.False(pizzaComparer.Equals(pizzaX, pizzaY));
            Assert.True(pizzaComparer.Equals(pizzaZ, pizzaY));
        }
        
        [Fact]
        public void TwoComponentTest()
        {
            var pizzaX = new Pizza(new List<string>
            {
                "feta cheese",
                "pepperoni"
            });
            
            var pizzaY = new Pizza(new List<string>
            {
                "pepperoni",
                "feta cheese"
            });
            
            var pizzaZ = new Pizza(new List<string>
            {
                "pepperoni",
                "pepperoni"
            });
            
            
            
            var pizzaComparer = new PizzaComparer();
            
                        
            Assert.True(pizzaComparer.Equals(pizzaX, pizzaY));
            Assert.True(pizzaComparer.Equals(pizzaY, pizzaX));
            Assert.False(pizzaComparer.Equals(pizzaZ, pizzaY));
        }

        [Fact]
        public void MixedComponentTest()
        {
            var pizzaX = new Pizza(new List<string>
            {
                "feta cheese"
            });
            
            var pizzaY = new Pizza(new List<string>
            {
                "pepperoni"
            });
            
            var pizzaZ = new Pizza(new List<string>
            {
                "feta cheese",
                "pepperoni"
            });
            
            
            
            var pizzaComparer = new PizzaComparer();
            
                        
            Assert.False(pizzaComparer.Equals(pizzaX, pizzaZ));
            Assert.False(pizzaComparer.Equals(pizzaZ, pizzaY));
        }
        
        [Fact]
        public void RepeatSameComponentTest()
        {
            var pizzaX = new Pizza(new List<string>
            {
                "pepperoni",
                "pepperoni",
                "pepperoni",
                "feta cheese"
            });
            
            var pizzaY = new Pizza(new List<string>
            {
                "pepperoni",
                "pepperoni",
                "feta cheese"
            });
            
            var pizzaZ = new Pizza(new List<string>
            {
                "feta cheese",
                "pepperoni",
                "pepperoni"
            });
            
            
            
            var pizzaComparer = new PizzaComparer();
            
                        
            Assert.False(pizzaComparer.Equals(pizzaX, pizzaZ));
            Assert.False(pizzaComparer.Equals(pizzaY, pizzaX));
            Assert.True(pizzaComparer.Equals(pizzaZ, pizzaY));
            Assert.True(pizzaComparer.Equals(pizzaY, pizzaZ));
        }
 
    }
}