using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using pizza.core;

namespace pizza.console
{
    class Program
    {
        static void Main()
        {
            try
            {
                var json = File.ReadAllText(@"pizzas.json");
                var pizzas =
                    JsonConvert.DeserializeObject<List<Pizza>>(json);

                var utility = new Utility();
                var result = utility.getMostPopular(pizzas, 10);

                foreach (var r in result)
                {
                    Console.WriteLine($"{r.Value}");
                    r.Key.Print();
                    Console.WriteLine();
                }                

            }
            catch (IOException)
            {
                Console.WriteLine($"json-file is not found");
            }
            catch (JsonReaderException)
            {
                Console.WriteLine($"json-file is broken or is not correct");
            }
            catch (Exception)
            {
                Console.WriteLine("unknown error");
            }

        }
    }    
}