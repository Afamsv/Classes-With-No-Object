using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliasing_with_using
{
    using doit = System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            doit.WriteLine("Hello World!");
        }
    }
}
