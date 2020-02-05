using System;
using System.Collections.Generic;

namespace Problem699
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long N = 100000000000000;
            //long N = 1000000;

            long sum = 0;
            for (long i = 3; i <= N; i+=3)
            {
                long sigma = SumOfAllDivisors(i);
                long gcd = CalculateGreatestCommonDivisor(sigma, i);

                //long a = sigma / gcd;
                long b = i / gcd;
                if (IsPowerOfThree(b))
                {
                    Console.WriteLine("n : " + i + " ||| sigma(n)/n : " + sigma + "/" + i + " ||| gcd : " + gcd + " ||| " + "a/b : " + a + "/" + b);
                    sum += i;
                }
            }
            Console.WriteLine(sum);
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
            if (u == 0)
            {
                return v;
            }

            if (v == 0)
            {
                return u;
            }

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
            return Sum(GetDivisors(n));
        }

        private static List<long> GetDivisors(long n)
        {
            List<long> divisors = new List<long>();
            for (long i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                    if (n / i != i)
                    {
                        divisors.Add(n / i);
                    }
                }
            }
            return divisors;
        }

        public static long Sum(List<long> queryable)
        {
            long sum = default(long);
            foreach (long element in queryable)
            {
                sum += element;
            }
            return sum;
        }
    }
}
