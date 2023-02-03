using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Hello();


        }

        static void Hello()
        {
            List<string> names = new List<string> { "Beatrice", "Ana", "Felipe" };
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine("New names list \n");
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            Console.WriteLine();
            Console.WriteLine($"The list has {names.Count} people in it");
            Console.WriteLine(); Console.ReadKey();

            var index = names.IndexOf("Felipe");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
            Console.ReadKey();
        }


    }
    
}
