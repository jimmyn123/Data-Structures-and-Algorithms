using System;
using fifo_animal_shelter.Class;
using static System.Console;

namespace fifo_animal_shelter
{
    class Program
    {
        static void Main(string[] args)
        {
            // calls function
            FIFOAnimalShelter();
        }

        /// <summary>
        /// Adds dogs and cats into an animalshelter and then removes them
        /// </summary>
        public static void FIFOAnimalShelter()
        {
            // creates new animal shelter and dogs and cats and puts them in
            AnimalShelter shelter = new AnimalShelter();
            shelter.Print();
            shelter.Enqueue(new Node(new Dog()));
            shelter.Enqueue(new Node(new Dog()));
            shelter.Enqueue(new Node(new Cat()));
            shelter.Enqueue(new Node(new Dog()));
            shelter.Enqueue(new Node(new Cat()));

            // prints initial shelter after creating them
            shelter.Print();

            // dequeue a cat
            WriteLine("Dequeueing...cat");
            shelter.Dequeue("Cat");
            shelter.Print();

            // dequeue second cat
            WriteLine("Dequeueing...cat");
            shelter.Dequeue("Cat");
            shelter.Print();

            // dequeue a third cat, but ends up w/ a dog because no more cats
            WriteLine("Dequeueing...cat");
            shelter.Dequeue("Cat");
            shelter.Print();

            WriteLine("No more cats so it dequeued a dog");
        }
    }
}
