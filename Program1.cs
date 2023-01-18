using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            average();

        }
                
        static void average()
        {
            int M = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            double count = 0;

            for (int i = M; i < N; i++)
            {
                if (i % 21 == 0)
                {
                    sum = sum + i;
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("21-e bolunen eded yoxdur");
            }
            else
            {
                Console.WriteLine(sum / count);
            }
        }
    }
}

