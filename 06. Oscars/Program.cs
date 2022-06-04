using System;
namespace ForLoopExercise
{
    class Program
    {
        static void Main()
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judgesNumber = int.Parse(Console.ReadLine());
            double pointsFromName = 0;
            double totalPoints = 0;


            for (int i = 1; i <= judgesNumber; i++)
            {
                string judgeName = Console.ReadLine();
                double currJudgePoints = double.Parse(Console.ReadLine());
                pointsFromName = judgeName.Length;
                totalPoints = academyPoints + ((pointsFromName * currJudgePoints) / 2);
                academyPoints = totalPoints;
                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
                    return;
                }
            }
            double morePoints = 1250.5 - totalPoints;
            Console.WriteLine($"Sorry, {actorName} you need {morePoints:f1} more!");
        }
    }
}
