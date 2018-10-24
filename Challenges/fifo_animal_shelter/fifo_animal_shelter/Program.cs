using System;
using fifo_animal_shelter.Class;
using static System.Console;

namespace fifo_animal_shelter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AnimalShelter shelter = new AnimalShelter();
            shelter.Print();
            shelter.Enqueue(new Node(new Dog()));
            shelter.Enqueue(new Node(new Dog()));
            shelter.Enqueue(new Node(new Cat()));
            shelter.Enqueue(new Node(new Dog()));
            shelter.Enqueue(new Node(new Cat()));

            shelter.Print();

            WriteLine("Dequeueing...");
            shelter.Dequeue("Cat");
            shelter.Print();
        }
    }
}
