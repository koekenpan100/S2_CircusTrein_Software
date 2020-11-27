using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein_S2_Software;

namespace CircusTreinTests
{
    [TestClass]
    public class WagonTests
    {
        [TestMethod]
        public void WagonConstructorInitializesParametersCorrectly()
        {
            Wagon wagon = new Wagon(1);
            Assert.AreEqual(1 , wagon.WagonID);
            Assert.AreEqual(10, wagon.MaxPoints);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WagonConstructorThrowsArgumentExceptionWhenWagonIdIsNegative()
        {
            Wagon wagon = new Wagon(-1);
        }

        [TestMethod]
        public void AddAnimalAddsAnimalToAnimalList()
        {
            Wagon wagon = new Wagon(1);
            Animal animal = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            wagon.AddAnimal(animal);
            Assert.AreEqual(1, wagon.Animals.Count);
        }

        [TestMethod]
        public void AddSmallAnimalIncreasesWagonCurrentPointsBy1()
        {
            Wagon wagon = new Wagon(1);
            Animal animal = new Animal(AnimalSize.Small, AnimalFood.Herbivore);
            wagon.AddAnimal(animal);
            Assert.AreEqual(1, wagon.CurrentPoints);
        }

        [TestMethod]
        public void AddMediumAnimalIncreasesWagonCurrentPointsBy3()
        {
            Wagon wagon = new Wagon(1);
            Animal animal = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            wagon.AddAnimal(animal);
            Assert.AreEqual(3, wagon.CurrentPoints);
        }

        [TestMethod]
        public void AddLargeAnimalIncreasesWagonCurrentPointsBy5()
        {
            Wagon wagon = new Wagon(1);
            Animal animal = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            wagon.AddAnimal(animal);
            Assert.AreEqual(5, wagon.CurrentPoints);
        }

        [TestMethod]
        public void CheckAvailablePlaceInWagonReturnsFalseWhenWagonIsFull()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            Animal animal2 = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            Animal animalTryingToAdd = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            Assert.AreEqual(false , wagon.CheckAvailablePlaceInWagon(animalTryingToAdd));
        }

        [TestMethod]
        public void CheckAvailablePlaceInWagonReturnsTrueWhenWagonIsNotFull()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            Animal animal2 = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            Animal animalTryingToAdd = new Animal(AnimalSize.Small, AnimalFood.Herbivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            Assert.AreEqual(true, wagon.CheckAvailablePlaceInWagon(animalTryingToAdd));
        }

        [TestMethod]
        public void CheckWagonCapacityReturnsValidWagonCapacity()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            Animal animal2 = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            Assert.AreEqual(8, wagon.CheckWagonCapacity());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckWagonCapacityThrowsArgumentExceptionWhenCapacityExceeds10Points()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            Animal animal2 = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            Animal animal3 = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            wagon.AddAnimal(animal3);
            wagon.CheckWagonCapacity();
        }

        [TestMethod]
        public void CheckIfAnimalsInWagonGetsEatenReturnsFalseIfPlacedAnimalInWagonIsHerbivore()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Small, AnimalFood.Herbivore);
            Animal animal2 = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            Animal animalToBePlaced = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            Assert.AreEqual(false, wagon.CheckIfAnimalsInWagonGetEaten(animalToBePlaced));
        }

        [TestMethod]
        public void CheckIfAnimalsInWagonGetsEatenReturnsFalseIfPlacedAnimalInWagonIsSmallerCarnivore()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Medium, AnimalFood.Carnivore);
            Animal animal2 = new Animal(AnimalSize.Medium, AnimalFood.Carnivore);
            Animal animalToBePlaced = new Animal(AnimalSize.Small, AnimalFood.Carnivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            Assert.AreEqual(false, wagon.CheckIfAnimalsInWagonGetEaten(animalToBePlaced));
        }

        [TestMethod]
        public void CheckIfAnimalsInWagonGetsEatenReturnsTrueIfPlacedAnimalInWagonIsBiggerOrSameSizeCarnivore()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Large, AnimalFood.Carnivore);
            Animal animal2 = new Animal(AnimalSize.Medium, AnimalFood.Carnivore);
            Animal animalToBePlaced = new Animal(AnimalSize.Large, AnimalFood.Carnivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            Assert.AreEqual(true, wagon.CheckIfAnimalsInWagonGetEaten(animalToBePlaced));
        }

        [TestMethod]
        public void CheckIfPlacedAnimalGetsEatenReturnsTrueIfOtherAnimalsInWagonAreBiggerCarnivores()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Large, AnimalFood.Carnivore);
            Animal animal2 = new Animal(AnimalSize.Medium, AnimalFood.Carnivore);
            Animal animalToBePlaced = new Animal(AnimalSize.Small, AnimalFood.Carnivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            Assert.AreEqual(true, wagon.CheckIfPlacedAnimalGetsEaten(animalToBePlaced));
        }

        [TestMethod]
        public void CheckIfPlacedAnimalGetsEatenReturnsFalseIfOtherAnimalsInWagonAreSmallerCarnivores()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Medium, AnimalFood.Carnivore);
            Animal animal2 = new Animal(AnimalSize.Medium, AnimalFood.Carnivore);
            Animal animalToBePlaced = new Animal(AnimalSize.Large, AnimalFood.Carnivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            Assert.AreEqual(false, wagon.CheckIfPlacedAnimalGetsEaten(animalToBePlaced));
        }

        [TestMethod]
        public void CheckIfPlacedAnimalGetsEatenReturnsFalseIfOtherAnimalsInWagonAreBiggerHerbivores()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            Animal animal2 = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            Animal animalToBePlaced = new Animal(AnimalSize.Small, AnimalFood.Carnivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            Assert.AreEqual(false, wagon.CheckIfPlacedAnimalGetsEaten(animalToBePlaced));
        }

        [TestMethod]
        public void CheckIfPlacedAnimalGetsEatenReturnsFalseIfAllAnimalsInWagonAreHerbivores()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            Animal animal2 = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            Animal animalToBePlaced = new Animal(AnimalSize.Small, AnimalFood.Herbivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            Assert.AreEqual(false, wagon.CheckIfPlacedAnimalGetsEaten(animalToBePlaced));
        }

        [TestMethod]
        public void CheckIfPlacedAnimalGetsEatenReturnsTrueIfOtherAnimalInWagonIsSameSizeCarnivore()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            Animal animalToBePlaced = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            wagon.AddAnimal(animal1);
            Assert.AreEqual(false, wagon.CheckIfPlacedAnimalGetsEaten(animalToBePlaced));
        }

        [TestMethod]
        public void PlaceAnimalReturnsTrueIfAllChecksAreGoodWeather()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            Animal animalToBePlaced = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            wagon.AddAnimal(animal1);
            Assert.AreEqual(true, wagon.PlaceAnimal(animalToBePlaced));
        }

        [TestMethod]
        public void PlaceAnimalReturnsFalseIfWagonHasNoSpace()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            Animal animal2 = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            Animal animalToBePlaced = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            Assert.AreEqual(false, wagon.PlaceAnimal(animalToBePlaced));
        }

        [TestMethod]
        public void PlaceAnimalReturnsFalseIfAnimalsInWagonGetEaten()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            Animal animal2 = new Animal(AnimalSize.Small, AnimalFood.Herbivore);
            Animal animalToBePlaced = new Animal(AnimalSize.Medium, AnimalFood.Carnivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            Assert.AreEqual(false, wagon.PlaceAnimal(animalToBePlaced));
        }

        [TestMethod]
        public void PlaceAnimalReturnsFalseIfAnimalToBePlacedGetsEaten()
        {
            Wagon wagon = new Wagon(1);
            Animal animal1 = new Animal(AnimalSize.Large, AnimalFood.Carnivore);
            Animal animal2 = new Animal(AnimalSize.Medium, AnimalFood.Carnivore);
            Animal animalToBePlaced = new Animal(AnimalSize.Medium, AnimalFood.Carnivore);
            wagon.AddAnimal(animal1);
            wagon.AddAnimal(animal2);
            Assert.AreEqual(false, wagon.PlaceAnimal(animalToBePlaced));
        }
    }
}
