using System;
namespace UPR2702
{
    class Program
    {
        static void Main()
        {
            //INPUT
            int tabsOpen = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            //ACTIONS
            for (int currTab = 0; currTab < tabsOpen; currTab++)
            {
                string nameOfTab = Console.ReadLine();

                switch (nameOfTab)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine(salary);


            //OUTPUT
        }
    }
}
