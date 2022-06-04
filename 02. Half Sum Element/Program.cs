using System;
namespace UPR2702
{
    class Program
    {
        static void Main()
        {
            //INPUT
            int numberOfOutput = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;
            //ACTIONS
            for (int i = 0; i < numberOfOutput; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;

                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }
            int sumWithoutMaxNumber = sum - maxNumber;
            if (maxNumber == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");

            }
            else
            {
                int diff = Math.Abs(maxNumber - sumWithoutMaxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }



            //OUTPUT
        }
    }
}

