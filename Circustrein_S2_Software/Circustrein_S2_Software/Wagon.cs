using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_S2_Software
{
    public class Wagon
    {
        public List<Animal> Animals { get; private set; }
        public int MaxPoints { get; private set; }
        public int CurrentPoints { get; private set; }
        public bool WagonIsFull { get; set; }
        public int WagonID { get; private set; }

        public Wagon(int wagonID)
        {
            if (wagonID < 0)
            {
                throw new ArgumentException("WagonID");
            }
            MaxPoints = 10;
            WagonID = wagonID;
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            CurrentPoints += (int)animal.AnimalSize;
        }

        public bool CheckAvailablePlaceInWagon(int animalSize)
        {
            int wagonCapacity = CheckWagonCapacity();

            if (wagonCapacity + animalSize > MaxPoints)
            {
                return false;
            }

            return true;
        }

        public int CheckWagonCapacity()
        {
            int wagonCapacity = 0;

            foreach (var item in Animals)
            {
                wagonCapacity += (int)item.AnimalSize;
            }

            return wagonCapacity;
        }

        public bool CheckIfAnimalInWagonGetsEaten(Animal animal)
        {
            if (animal.CheckIfHerbivore())
            {
                return true;
            }

            bool AnimalEatsOtherAnimals = Animals.Any(a => a.AnimalSize >= animal.AnimalSize);

            if (AnimalEatsOtherAnimals == true)
            {
                return false;
            }

            return true;
        }

        public bool CheckIfPlacedAnimalGetsEaten(Animal animal)
        {
            bool DangerousAnimal = Animals.Any(a => a.AnimalFood == AnimalFood.Carnivore && a.AnimalSize >= animal.AnimalSize);

            if (DangerousAnimal == true)
            {
                return false;
            }

            return true;
        }

        public void PlaceAnimal(Animal animal)
        {
            bool AvailablePlace = CheckAvailablePlaceInWagon((int)animal.AnimalSize);
            bool AnimalSurvives = CheckIfPlacedAnimalGetsEaten(animal);
            bool OtherAnimalsSurvive = CheckIfAnimalInWagonGetsEaten(animal);

            if (AvailablePlace == true && AnimalSurvives == true && OtherAnimalsSurvive == true)
            {
                PlaceAnimal(animal);
            }
        }
    }
}
