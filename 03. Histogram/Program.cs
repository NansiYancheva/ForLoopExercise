using System;
namespace ForLoopExercise
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            double nbelow200 = 0;
            double nbelow399 = 0;
            double nbelow599 = 0;
            double nbelow799 = 0;
            double nabove800 = 0;

            for (int i = 1; i <= number; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (currNum < 200)
                    nbelow200++;
                else if (currNum >= 200 && currNum <= 399)
                    nbelow399++;
                else if (currNum >= 400 && currNum <= 599)
                    nbelow599++;
                else if (currNum >= 600 && currNum <= 799)
                    nbelow799++;
                else
                    nabove800++;
            }
            double perc200 = (nbelow200 / number) * 100;
            Console.WriteLine($"{perc200:f2}%");
            double perc399 = (nbelow399 / number) * 100;
            Console.WriteLine($"{perc399:f2}%");
            double perc599 = (nbelow599 / number) * 100;
            Console.WriteLine($"{perc599:f2}%");
            double perc799 = (nbelow799 / number) * 100;
            Console.WriteLine($"{perc799:f2}%");
            double perc800 = (nabove800 / number) * 100;
            Console.WriteLine($"{perc800:f2}%");
        }
    }
}

