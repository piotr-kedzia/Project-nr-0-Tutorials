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
            List<string> names = new List<string> { "Ana", "Maria", "Felipe" };
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine("---------------------");
        }


    }
    
}
