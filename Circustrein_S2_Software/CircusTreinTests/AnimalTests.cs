using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein_S2_Software;

namespace CircusTreinTests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void AnimalConstructorInitializesParametersCorrectly()
        {
            Animal animal = new Animal(AnimalSize.Large, AnimalFood.Carnivore);
            Assert.AreEqual(AnimalSize.Large, animal.AnimalSize);
            Assert.AreEqual(AnimalFood.Carnivore, animal.AnimalFood);
        }

        [TestMethod]
        public void CheckIfHerbivoreReturnsTrueWhenAnimalfoodEnumIsHerbivore()
        {
            Animal animal = new Animal(AnimalSize.Large, AnimalFood.Herbivore);
            Assert.AreEqual(true, animal.CheckIfHerbivore());
        }

        [TestMethod]
        public void CheckIfHerbivoreReturnsFalseWhenAnimalfoodEnumIsCarnivore()
        {
            Animal animal = new Animal(AnimalSize.Large, AnimalFood.Carnivore);
            Assert.AreEqual(false, animal.CheckIfHerbivore());
        }

        [TestMethod]
        public void AnimalToStringReturnsCorrectString()
        {
            Animal animal = new Animal(AnimalSize.Medium, AnimalFood.Carnivore);
            string toString =   "Food:" + animal.AnimalFood.ToString()
                                + " "
                                + "Size:" + animal.AnimalSize.ToString();
            Assert.AreEqual(toString, animal.ToString());
        }
    }
}
