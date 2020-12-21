using System;

namespace Factorial
{
    class Program
    {
        static void Factorial(uint min, int factorial, ulong iEmul)
        {
            if (min == factorial+1)
            {
                Console.WriteLine(iEmul);
            }
            if (min <= factorial)
            {
                iEmul = iEmul * min;
                min++;
                Factorial(min, factorial, iEmul);
            }
        }
        static void Main(string[] args)
        {
            uint min = 1;
            int factorial = Int32.Parse(Console.ReadLine()); //max 20
            ulong iEmul = 1;
            Factorial(min, factorial, iEmul);
        }
    }
}
