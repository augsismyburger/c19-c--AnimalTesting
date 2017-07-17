using System;
using Xunit;

namespace Animals.Test
{
    public class AnimalShould
    {
        private Animal _animal;
        private Dog _dog;
        public void TestAnimalShould()
        {
            _animal = new Animal();
        }
        public void DogShould()
        {
            _dog = new Dog();
        }

        [Fact]
        public void NameAnimal()
        {
            _animal.Name = "Brian";

            Assert.Equal(_animal.Name, "Brian");
        }
        [Fact]
        public void SetAnimalSpecies()
        {
            _animal.Species = "Feline";

            Assert.Equal(_animal.Species, "Feline");
        }
        [Fact]        public void WalkAnimal()
        {
            Assert.Equal(_animal.Walk(), "Walking at Feline Speed");
        }
                [Fact]
        public void NameDog()
        {
            _dog.Name = "Brown Dog";

            Assert.Equal(_dog.Name, "Brown Dog");
        }
        [Fact]
        public void SeeDogSpecies()
        {
            Assert.Equal(_dog.Species, "Canine");
        }
        [Fact]        
        public void WalkDog()
        {
            Assert.Equal(_dog.Walk(), "Walking at Canine Speed");
        }
    }
}
