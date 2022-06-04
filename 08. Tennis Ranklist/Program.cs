using System;
namespace ForLoopExercise
{
    class Program
    {
        static void Main()
        {
            int numberTournament = int.Parse(Console.ReadLine());
            int begginingPoints = int.Parse(Console.ReadLine());
            int points = 0;
            double numberWin = 0;
            for (int i = 1; i <= numberTournament; i++)
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    points += 2000;
                    numberWin++;
                }
                if (stage == "F")
                    points += 1200;
                if (stage == "SF")
                    points += 720;
            }
            int finalPoints = points + begginingPoints;
            Console.WriteLine($"Final points: {finalPoints}");
            double avgPoints = Math.Abs(points / numberTournament);
            Console.WriteLine($"Average points: {avgPoints}");
            double percWin = (numberWin / numberTournament) * 100;
            Console.WriteLine($"{percWin:f2}%");
        }
    }
}
