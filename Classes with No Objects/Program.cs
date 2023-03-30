using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_with_No_Objects
{
    internal class Program
    {
        public class Mymath
        {
            public static long add(params int[] args)
            {
                int ctr = 0;
                long answer = 0;

                for (ctr = 0; ctr < args.Length; ctr++)
                {
                    answer += args[ctr];
                }
                return answer;
            }

            public static long Substrat(int args1, int args2)
            {
                long answer = 0;
                answer = args1 - args2;
                return answer;
            }


        }
        static void Main(string[] args)
        {
            long Result = 0;

            Result = Mymath.add(1, 2, 3);
            Console.WriteLine($"Add result is {Result}");

            Result = Mymath.Substrat(10, 5);
            Console.WriteLine($"Subtract result is {Result}");
        }
    }
}
