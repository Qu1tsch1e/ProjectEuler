using System;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] numbers = Data.NumbersAsCharArrays();
            string addition = "";
            int overflow = 0;
            for(int digitCount = numbers[0].Length - 1; digitCount >= 0; digitCount--)
            {
                int number = overflow;
                for(int numberCount = 0; numberCount < numbers.Length; numberCount++)
                {
                    number += int.Parse(numbers[numberCount][digitCount].ToString());
                }
                overflow = number / 10;
                addition = (number % 10) + addition;
                Console.WriteLine(addition);
            }
            addition = overflow + addition;
            Console.WriteLine("Final: " + addition.Substring(0, 10));
            Console.ReadLine();
        }
    }
}
