using System;

namespace ConsoleAppExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person;
            person = new Human();
            person.Name = "Jarik";
            person.Surname = "The Pro";
            person.Age = 25;
            person.EyeColor = "Pink";
            person.Introduce();

            person.Name = "Kolya";
            person.Introduce();
        }
    }


}
