using System;
using System.Diagnostics;
using System.Numerics;
using System.Threading.Tasks;

namespace Problem699
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long N = 100000000000000;
            //long N = 10000000;

            BigInteger sum = 0;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Parallel.For(3L, N / 3, iterator =>
            {
                long i = iterator * 3;
                long sigma = SumOfAllDivisors(i);
                long gcd = CalculateGreatestCommonDivisor(sigma, i);

                long b = i / gcd;
                if (IsPowerOfThree(b))
                {
                    Console.WriteLine("n : " + i + " ||| sigma(n)/n : " + sigma + "/" + i + " ||| gcd : " + gcd + " ||| b : " + b + " ||| sum : " + sum);
                    sum += i;
                }
            });
            watch.Stop();
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Time elapsed: " + watch.ElapsedMilliseconds + " ms");
            Console.Read();
        }

        private static bool IsPowerOfThree(long b)
        {
            // 4052555153018976267 is the highest long value of power of 3
            return b > 1 && 4052555153018976267 % b == 0;
        }

        private static long CalculateGreatestCommonDivisor(long u, long v)
        {
            int shift = 0;

            while (((u | v) & 1) == 0)
            {
                shift++;
                u >>= 1;
                v >>= 1;
            }
            while ((u & 1) == 0)
            {
                u >>= 1;
            }

            do
            {
                while ((v & 1) == 0)
                {
                    v >>= 1;
                }

                if (u > v)
                {
                    long t = v;
                    v = u;
                    u = t;
                }

                v -= u;
            } while (v != 0);

            return u << shift;
        }

        private static long SumOfAllDivisors(long n)
        {
            long res = 1;
            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                long curr_sum = 1;
                long curr_term = 1;
                while (n % i == 0)
                {
                    n = n / i;

                    curr_term *= i;
                    curr_sum += curr_term;
                }

                res *= curr_sum;
            }

            if (n >= 2)
            {
                res *= 1 + n;
            }

            return res;
        }
    }
}
