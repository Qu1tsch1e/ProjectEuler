using System;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "2";
            for(int i = 2; i <= 1000; i++)
            {
                number = MultNumber(number, 2);
                Console.WriteLine(number);
            }
            long sum = 0;
            for(int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number.Substring(i, 1));
            }
            Console.WriteLine("FINAL: " + sum);
            Console.ReadLine();
        }

        static string MultNumber(string number, int n)
        {
            string newNumber = "";
            int overflow = 0;
            for(int i = number.Length - 1; i >= 0; i--)
            {
                int currentCalculation = int.Parse(number.Substring(i, 1)) * n + overflow;
                overflow = currentCalculation / 10;
                newNumber = (currentCalculation % 10) + newNumber;
            }
            return overflow > 0 ? overflow + newNumber : newNumber;
        }
    }
}
