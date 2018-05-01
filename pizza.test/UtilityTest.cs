using System.Collections.Generic;
using System.Linq;
using pizza.core;
using Xunit;

namespace pizza.test
{
    public class UtilityTest
    {
        [Fact]
        public void OneRepeatableComponentTest()
        {
            var utility = new Utility();

            var pizzas = new List<Pizza>
            {
                new Pizza(new List<string>()
                    {
                        "feta cheese",
                        "pepperoni",
                        "pepperoni",
                        "pepperoni",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "feta cheese",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "feta cheese",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "feta cheese",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "feta cheese",
                        "pepperoni",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "feta cheese",
                        "pepperoni",
                        "pepperoni",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "feta cheese"
                    }
                ),
            };

            var mostPopular = utility.getMostPopular(pizzas, 1);


            Assert.Single(mostPopular);
            Assert.Equal(2, mostPopular.FirstOrDefault().Value);
            Assert.Equal(3, mostPopular.FirstOrDefault().Key.Toppings.Count);
            
            Assert.Equal("feta cheese", mostPopular.FirstOrDefault().Key.Toppings.ElementAt(0));
            Assert.Equal("pepperoni", mostPopular.FirstOrDefault().Key.Toppings.ElementAt(1));
            Assert.Equal("pepperoni", mostPopular.FirstOrDefault().Key.Toppings.ElementAt(2));
            
            
        }

        [Fact]
        public void ComponentOrderMixTest()
        {
            var utility = new Utility();

            var pizzas = new List<Pizza>
            {
                new Pizza(new List<string>()
                    {
                        "pepperoni",
                        "feta cheese",
                        "pepperoni",
                        "feta cheese",
                        "pepperoni",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "pepperoni",
                        "pepperoni",
                        "feta cheese",
                        "pepperoni",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "feta cheese",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "feta cheese",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "pepperoni",
                        "feta cheese",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "pepperoni",
                        "feta cheese",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "pepperoni",
                        "pepperoni",
                        "pepperoni",
                        "feta cheese",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "feta cheese"
                    }
                ),
            };

            var mostPopular = utility.getMostPopular(pizzas, 1);


            Assert.Single(mostPopular);
            Assert.Equal(2, mostPopular.FirstOrDefault().Value);
            Assert.Equal(3, mostPopular.FirstOrDefault().Key.Toppings.Count);

            Assert.Equal("feta cheese", mostPopular.FirstOrDefault().Key.Toppings.ElementAt(0));
            Assert.Equal("pepperoni", mostPopular.FirstOrDefault().Key.Toppings.ElementAt(1));
            Assert.Equal("pepperoni", mostPopular.FirstOrDefault().Key.Toppings.ElementAt(2));
        }
        
        
        [Fact]
        public void TwoRepeatableComponentWithOrderMixTest()
        {
            var utility = new Utility();

            var pizzas = new List<Pizza>
            {
                new Pizza(new List<string>()
                    {
                        "pepperoni",
                        "feta cheese",
                        "pepperoni",
                        "feta cheese",
                        "pepperoni",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "pepperoni",
                        "pepperoni",
                        "feta cheese",
                        "pepperoni",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "feta cheese",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "feta cheese",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "pepperoni",
                        "feta cheese",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "pepperoni",
                        "feta cheese",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        
                        "feta cheese",
                        "feta cheese",
                        "pepperoni",
                        "pepperoni",
                        "pepperoni",
                        "pepperoni",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "pepperoni",
                        "pepperoni",
                        "pepperoni",
                        "feta cheese",
                        "pepperoni"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "feta cheese"
                    }
                ),
                new Pizza(new List<string>()
                    {
                        "pepperoni",
                        "feta cheese",
                        "pepperoni",                        
                        "pepperoni",
                        "pepperoni",
                        "pepperoni",
                        "feta cheese",
                    }
                )
            };

            var mostPopular = utility.getMostPopular(pizzas, 1);


            Assert.Single(mostPopular);
            Assert.Equal(3, mostPopular.FirstOrDefault().Value);
            Assert.Equal(7, mostPopular.FirstOrDefault().Key.Toppings.Count);

            Assert.Equal("pepperoni", mostPopular.FirstOrDefault().Key.Toppings.ElementAt(0));
            Assert.Equal("feta cheese", mostPopular.FirstOrDefault().Key.Toppings.ElementAt(1));
            Assert.Equal("pepperoni", mostPopular.FirstOrDefault().Key.Toppings.ElementAt(2));
            Assert.Equal("feta cheese", mostPopular.FirstOrDefault().Key.Toppings.ElementAt(3));
            Assert.Equal("pepperoni", mostPopular.FirstOrDefault().Key.Toppings.ElementAt(4));
            Assert.Equal("pepperoni", mostPopular.FirstOrDefault().Key.Toppings.ElementAt(5));
            Assert.Equal("pepperoni", mostPopular.FirstOrDefault().Key.Toppings.ElementAt(6));
        }

    }
}