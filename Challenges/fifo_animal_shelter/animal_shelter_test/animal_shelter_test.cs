using System;
using Xunit;
using fifo_animal_shelter.Class;

namespace animal_shelter_test
{
    public class animal_shelter_test
    {
        /// <summary>
        /// Tests the enqueue against the size to compare
        /// </summary>
        /// <param name="animalNum">the amount to add</param>
        /// <param name="expected">the expected size</param>
        [Theory]
        [InlineData(3, 3)]
        [InlineData(45, 45)]
        [InlineData(29, 29)]
        public void EnqueueTest(int animalNum, int expected)
        {
            AnimalShelter shelter = new AnimalShelter();
            // loops and creates a new animal, every other animal is a dog
            for (int i = 0; i < animalNum; i++){
                Animal inAnimal = new Dog();
                if(i % 2 == 0)
                {
                    inAnimal = new Cat();
                }
                shelter.Enqueue(new Node(inAnimal));
            }

            // size should be the same as expected
            Assert.True(shelter.Size == expected);
        }
        
        /// <summary>
        /// Tests Dequeue by expecting a number less than the enqueue
        /// </summary>
        /// <param name="animalNum">the amount to add</param>
        /// <param name="expected">should be one less</param>
        [Theory]
        [InlineData(3, 2)]
        [InlineData(45, 44)]
        [InlineData(29, 28)]
        public void DequeueNumTest(int animalNum, int expected)
        {
            AnimalShelter shelter = new AnimalShelter();
            // adds new animals, every other animal is cat
            for (int i = 0; i < animalNum; i++)
            {
                Animal inAnimal = new Dog();
                if (i % 2 == 0)
                {
                    inAnimal = new Cat();
                }
                shelter.Enqueue(new Node(inAnimal));
            }

            // dequeues the first animal
            shelter.Dequeue("stuff");
            
            // size should be one less
            Assert.True(shelter.Size == expected);
        }

        /// <summary>
        /// Test the values that are returned
        /// </summary>
        /// <param name="animalIn">the value to dequeue</param>
        /// <param name="animalExpected">the expected animal coming back</param>
        [Theory]
        [InlineData("cat", "cat")]
        [InlineData("dog", "dog")]
        [InlineData("stuff", "cat")]
        public void DequeueValueTest(string animalIn, string animalExpected)
        {
            AnimalShelter shelter = new AnimalShelter();
            // adds two animals
            shelter.Enqueue(new Node(new Cat()));
            shelter.Enqueue(new Node(new Dog()));

            // gets the result animal
            Animal result = (Animal)shelter.Dequeue(animalIn).Value;

            // animal name should be the same
            Assert.Equal(result.Name, animalExpected);
        }
    }
}
