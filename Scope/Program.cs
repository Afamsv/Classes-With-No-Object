using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine($"X is {x}");
            }

            Console.WriteLine("");

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine($"X is {x}");
            }
        }
    }
}
