using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaring_a_Namespace
{
    public class PI
    {
        public static double value = 3.14159;
        private PI() { }
    }

    public class three
    {
        public static int value = 3;
        private three() { }
    }

    namespace MyMath
    {
        public class Routine
        {
            public static long Add(params int[] args)
            {
                int ctr = 0;
                long answer = 0;

                for (ctr = 0; ctr < args.Length; ctr++)
                {
                    answer += args[ctr];
                }
                return answer;
            }

            public static long Substrat(int arg1, int arg2)
            {
                int Anwser = 0;
                Anwser = arg1 - arg2;
                return Anwser;
            }
        }       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            long Result = 0;

            Result = MyMath.Routine.Add(1, 2, 3);
            Console.WriteLine($"Add result is {Result}");

            Result = MyMath.Routine.Substrat(10, 5);
            Console.WriteLine($"Subtract result is {Result}");

            Console.WriteLine($"\nThe value of PI is {Declaring_a_Namespace.PI.value}");
            Console.WriteLine($"\nThe value of three is {Declaring_a_Namespace.three.value}\n");
        }
    }
}
