using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            var birdie = new Bird();
            birdie.WingSpanInCm = 150;
            birdie.CanFly=true; ;
            birdie.Migrates = true;
            birdie.EatsBugs = true;

            var croc = new Reptile()
            {
                NumberOfLegs = 4,
                EnvironmentItLivesIn = "swamp",
                HotOrColdBlooded="cold",
                HasFeathers=false
            
        };
            var animalArray = new Animal[] {birdie,croc };

foreach(var animal in animalArray)
            {
                Console.WriteLine("Has "+animal.NumberOfLegs+" , lives in "+ animal.EnvironmentItLivesIn+" fathers?"+ animal.HasFeathers+" is "+ animal.HotOrColdBlooded+" blooded.");
            }



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
