using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Done - Create a class Animal
            // give this class 4 members that all Animals have in common


            // Done - Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Done - Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            var myBird = new Bird();
            myBird.WingColor = "red";
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakLength = 8;

            var alligator = new Reptile()
            {
                IscoldBlooded = true,
                IsScaly = true,
                Habitat = "Swamp",
                CanGrowTail = true
            };

            var myAnimals = new Animal[] { myBird, alligator };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age} years old");
                Console.WriteLine($"It has {animal.LegCount} legs on its body");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
                Console.WriteLine("");


            }

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
