using System;

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "";
            for(int i = 1; i < 1000; i++)
            {
                string number = NumberToString(i);
                numbers += number + " ";
                Console.Write(i);
                if(i < 10)
                {
                    Console.Write("  ");
                }
                else if(i < 100)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" " + number);
            }
            numbers += "one thousand";
            numbers = numbers.Replace(" ", "").Replace("-", "");
            Console.WriteLine(numbers);
            Console.WriteLine("FINAL:" + numbers.Length);
            Console.ReadLine();
        }

        static string NumberToString(int number)
        {
            int hundreds = number / 100;
            int rest = number % 100;
            string n = hundreds > 0 ? DigitToSTring(hundreds) + " hundred" : string.Empty;
            return n + (rest > 0 && n != string.Empty ? " and " : string.Empty) + Below100String(rest);
        }

        static string Below100String(int number)
        {
            if(number < 1)
            {
                return string.Empty;
            }
            if(number <= 19)
            {
                return DigitToSTring(number);
            }
            if(number % 10 == 0)
            {
                return TensToString(number);
            }
            return TensToString(number / 10 * 10) + "-" + DigitToSTring(number % 10);
        }

        static string TensToString(int number)
        {
            switch (number)
            {
                case 20: return "twenty";
                case 30: return "thirty";
                case 40: return "forty";
                case 50: return "fifty";
                case 80: return "eighty";
                default:
                    break;
            }
            return DigitToSTring(number / 10) + "ty";
        }

        static string DigitToSTring(int number)
        {
            switch (number)
            {
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
