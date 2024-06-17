// See https://aka.ms/new-console-template for more information

using System;

namespace InheritanceAndMethodOverriding
{
    // Base class Animal with a virtual method MakeSound
    class Animal
    {
        // Virtual method that can be overridden in derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog that inherits from Animal
    class Dog : Animal
    {
        // Override the MakeSound method to provide Dog-specific behavior
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat that inherits from Animal
    class Cat : Animal
    {
        // Override the MakeSound method to provide Cat-specific behavior
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    // Main program class
    class Program
    {
        // Main method - entry point of the program
        static void Main(string[] args)
        {
            // Create instances of Animal, Dog, and Cat
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.MakeSound(); 
            myDog.MakeSound();  
            myCat.MakeSound();
        }
    }
}
