using System;

namespace task._2
{
    class Program
    {
        static void Main(string[] args)
        {
            sumOfDigits();

        }
        static void sumOfDigits()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int sumOfDigits = 0;

            while (n > 0)
            {
                int lastdigit = n % 10;
                sumOfDigits = sumOfDigits + lastdigit;
                n = n / 10;
            }
            Console.WriteLine(sumOfDigits);
        }
    }
}