using System;
using System.Numerics;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            // !(40) / ((20)! * (20)!)
            BigInteger x1 = new BigInteger(39);
            BigInteger x2 = new BigInteger(37);
            BigInteger x3 = new BigInteger(35);
            BigInteger x4 = new BigInteger(33);
            BigInteger x5 = new BigInteger(31);
            BigInteger x6 = new BigInteger(29);
            BigInteger x7 = new BigInteger(23);
            BigInteger x8 = new BigInteger(4);
            BigInteger calc = x1 * x2 * x3 * x4 * x5 * x6 * x7 * x8;
            Console.WriteLine(calc);
            Console.ReadLine();
        }
    }
}
