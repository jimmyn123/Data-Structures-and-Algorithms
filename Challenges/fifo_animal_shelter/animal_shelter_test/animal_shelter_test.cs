using System;
using Xunit;
using fifo_animal_shelter.Class;

namespace animal_shelter_test
{
    public class animal_shelter_test
    {
        /// <summary>
        /// Tests the enqueue and then 
        /// </summary>
        /// <param name="animalNum"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(3, 3)]
        [InlineData(45, 45)]
        [InlineData(29, 29)]
        public void EnqueueTest(int animalNum, int expected)
        {
            AnimalShelter shelter = new AnimalShelter();
            for (int i = 0; i < animalNum; i++){
                Animal inAnimal = new Dog();
                if(i % 2 == 0)
                {
                    inAnimal = new Cat();
                }
                shelter.Enqueue(new Node(inAnimal));
            }

            Assert.True(shelter.Size == expected);
        }

        [Theory]
        [InlineData(3, 2)]
        [InlineData(45, 44)]
        [InlineData(29, 28)]
        public void DequeueNumTest(int animalNum, int expected)
        {
            AnimalShelter shelter = new AnimalShelter();
            for (int i = 0; i < animalNum; i++)
            {
                Animal inAnimal = new Dog();
                if (i % 2 == 0)
                {
                    inAnimal = new Cat();
                }
                shelter.Enqueue(new Node(inAnimal));
            }

            shelter.Dequeue("stuff");

            Assert.True(shelter.Size == expected);
        }

        [Theory]
        [InlineData("cat", "cat")]
        [InlineData("dog", "dog")]
        [InlineData("stuff", "cat")]
        public void DequeueValueTest(string animalIn, string animalExpected)
        {
            AnimalShelter shelter = new AnimalShelter();
            shelter.Enqueue(new Node(new Cat()));
            shelter.Enqueue(new Node(new Dog()));

            Animal result = (Animal)shelter.Dequeue(animalIn).Value;

            Assert.Equal(result.Name, animalExpected);
        }
    }
}
