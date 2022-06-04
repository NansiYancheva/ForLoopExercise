using System;
namespace UPR2702
{
    class Program
    {
        static void Main()
        {
            //INPUT
            int ageofLilly = int.Parse(Console.ReadLine());
            double priceOfWashMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toysCollected = 0;
            double moneyCollected = 0;

            //ACTIONS
            for (int currAge = 1; currAge <= ageofLilly; currAge++)
            {
                if (currAge % 2 != 0)
                    toysCollected++;
                else
                {
                    int moneyPresent = (currAge * 5) - 1;
                    moneyCollected += moneyPresent;
                }
            }

            int toysSellPrice = toysCollected * toyPrice;
            moneyCollected += toysSellPrice;

            if (moneyCollected >= priceOfWashMachine)
            {
                double left = moneyCollected - priceOfWashMachine;
                Console.WriteLine($"Yes! {left:f2}");
            }
            else
            {
                double notEnough = priceOfWashMachine - moneyCollected;
                Console.WriteLine($"No! {notEnough:f2}");
            }


            //OUTPUT
        }
    }
}
