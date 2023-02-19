using System;
using System.Collections.Generic;

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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird bird1 = new Bird();
            bird1.animalName = "parrot";
            bird1.Migratory = false;
            bird1.IsCarnivoir = false;
            bird1.CanSpeak = true;
            bird1.CanFly = true;
            bird1.IsEndangered = true;
            bird1.Legs = 2;
            bird1.IsNocturnal = true;
            bird1.Age = 30;
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile rep1 = new Reptile();
            rep1.animalName = "turtle";
            rep1.CreepyMeanCute = "cute";
            rep1.IsVenomous = false;
            rep1.IsCarnivoir = true;
            rep1.HasShell = true;
            rep1.IsEndangered = false;
            rep1.LaysEggs = true;
            rep1.Age = 100;
            rep1.Legs = 4;
            
             List<Animal> animals = new List<Animal>(2) { rep1,bird1};
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.animalName);
                Console.WriteLine($"Carnivoir: { animal.IsCarnivoir}");
                Console.WriteLine($"How many legs {animal.Legs}");
                Console.WriteLine($"What is the animal's age {animal.Age} years");
                Console.WriteLine($"Endangered: {animal.IsEndangered}");
                Console.WriteLine($"");
            }
     
        }
    }
}
