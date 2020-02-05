using System;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisors = 0;
            int counter = 1;
            int triangleNumber = 1;
            while (divisors < 500)
            {
                int newDivisors = CountDivisors(triangleNumber);

                if(newDivisors > divisors)
                {
                    Console.WriteLine("Counter: " + counter + " ||| divisors: " + divisors + " ||| triangle number: " + triangleNumber);
                    divisors = newDivisors;
                }

                counter++;
                triangleNumber += counter;
            }
            Console.Read();
        }

        private static int CountDivisors(int n)
        {
            int divisors = 0;
            for(int i = 1; i <= Math.Sqrt(n); i++)
            {
                if(n%i == 0)
                {
                    if(n != n / i)
                    {
                        divisors++;
                    }
                    divisors++;
                }
            }
            return divisors;
        }
    }
}
