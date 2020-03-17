using System;

namespace InheritanceChallengeEmployee
{
    class Program
    {
        static void Main(string[] args)
        {

            var newManager = new Manager("Luis", "Tellez", 23_000, "Kia 2020");
            var newTrainee = new Trainee("Israel", "Mendoza", 8_000, 4);

            Console.WriteLine(newManager);
            Console.WriteLine(newTrainee);
            Console.WriteLine();

            newManager.Lead();
            newTrainee.Learn();
            Console.WriteLine();

            newManager.ApplyRaise();
            newTrainee.ApplyRaise();
        }
    }
}
