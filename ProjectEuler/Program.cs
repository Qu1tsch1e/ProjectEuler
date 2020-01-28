using System;

namespace Problem2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long fib0 = 0;
            long fib1 = 1;

            long sum = 0;

            bool isUnderFourMillion = true;
            do
            {
                if (fib1 % 2 == 1)
                {
                    sum += fib1;
                }

                long nextFib = fib0 + fib1;
                fib0 = fib1;
                fib1 = nextFib;
                isUnderFourMillion = nextFib < 4000000;
            } while (isUnderFourMillion);

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
