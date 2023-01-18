using System;

namespace task._3
{
    class Program
    {
        static void Main(string[] args)
        {
            hasA();
        }
        static void hasA ()
        {
            Console.WriteLine("Yazini daxil edin: ");

            string word = Console.ReadLine();

            bool hasWantedChar = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    hasWantedChar = true;
                    break;
                }
            }
            if (hasWantedChar == true)
            {
                Console.WriteLine("Yazida a herfi var");
            }
            else
            {
                Console.WriteLine("Yazida a herfi yoxdur");
            }
        }
    }
}

