using System;
namespace ForLoopExercise
{
    class Program
    {
        static void Main()
        {
            int groups = int.Parse(Console.ReadLine());
            double peopleMusala = 0;
            double peopleMonblan = 0;
            double peopleKili = 0;
            double peopleKTwo = 0;
            double peopleEverest = 0;
            double totalNumberOfPeople = 0;
            //За всяка една група на отделен ред – броя на хората в групата 
            for (int counter = 1; counter <= groups; counter++)
            {
                //докато групите започват от 1 и свършат до подадения брой групи чети брой на хора
                int numPeoplePerGroup = int.Parse(Console.ReadLine());
                totalNumberOfPeople += numPeoplePerGroup;
                if (numPeoplePerGroup <= 5)
                    peopleMusala += numPeoplePerGroup;
                else if (numPeoplePerGroup > 5 && numPeoplePerGroup <= 12)
                    peopleMonblan += numPeoplePerGroup;
                else if (numPeoplePerGroup > 12 && numPeoplePerGroup <= 25)
                    peopleKili += numPeoplePerGroup;
                else if (numPeoplePerGroup > 25 && numPeoplePerGroup <= 40)
                    peopleKTwo += numPeoplePerGroup;
                else if (numPeoplePerGroup > 40)
                    peopleEverest += numPeoplePerGroup;
            }
            double percMusala = (peopleMusala / totalNumberOfPeople) * 100;
            double percMonblan = (peopleMonblan / totalNumberOfPeople) * 100;
            double percKili = (peopleKili / totalNumberOfPeople) * 100;
            double percKTwo = (peopleKTwo / totalNumberOfPeople) * 100;
            double percEverest = (peopleEverest / totalNumberOfPeople) * 100;
            Console.WriteLine($"{percMusala:f2}%");
            Console.WriteLine($"{percMonblan:f2}%");
            Console.WriteLine($"{percKili:f2}%");
            Console.WriteLine($"{percKTwo:f2}%");
            Console.WriteLine($"{percEverest:f2}%");
        }
    }
}
