using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            long chainLength = 0;
            long longestChainNumber = 0;

            for(long i = 13; i < 1000000; i++)
            {
                long chainLengthForI = CalculateChainLength(i);
                if(chainLengthForI > chainLength)
                {
                    chainLength = chainLengthForI;
                    longestChainNumber = i;
                    Console.WriteLine("NEW CHAIN LENGTH: " + chainLength + " ||| NUMBER: " + longestChainNumber);
                }
            }
            Console.WriteLine("FINAL: " + longestChainNumber);
            Console.ReadLine();
        }

        static long CalculateChainLength(long n)
        {
            List<long> chainElements = new List<long>();
            do
            {
                chainElements.Add(n);
                n = n % 2 == 0 ? n / 2 : 3 * n + 1;
            } while (!chainElements.Contains(n));
            if(chainElements.Last() != 1)
            {
                foreach(long element in chainElements)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
            return chainElements.Count;
        }
    }
}
