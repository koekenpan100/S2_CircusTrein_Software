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
        public int WagonID { get; private set; }

        public Wagon(int wagonID)
        {
            if (wagonID < 0)
            {
                throw new ArgumentException("WagonID");
            }
            MaxPoints = 10;
            WagonID = wagonID;
            Animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            CurrentPoints += (int)animal.AnimalSize;
        }

        public bool CheckAvailablePlaceInWagon(Animal animal)
        {
            int wagonCapacity = CheckWagonCapacity();

            if (wagonCapacity + (int)animal.AnimalSize > MaxPoints)
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

            if (wagonCapacity > 10)
            {
                throw new ArgumentException("Wagon capacity cannot exceed 10 points");
            }
            return wagonCapacity;
        }

        public bool CheckIfAnimalsInWagonGetEaten(Animal animal)
        {
            if (animal.CheckIfHerbivore())
            {
                return false;
            }

            foreach (var animalInWagon in Animals)
            {
                if (animal.AnimalSize >= animalInWagon.AnimalSize)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CheckIfPlacedAnimalGetsEaten(Animal animal)
        {

            foreach (var animalInWagon in Animals)
            {
                if (animalInWagon.AnimalFood == AnimalFood.Carnivore && animalInWagon.AnimalSize >= animal.AnimalSize)
                {
                    return true;
                }
            }
            return false;
        }

        public bool PlaceAnimal(Animal animal)
        {
            bool AvailablePlace = CheckAvailablePlaceInWagon(animal);
            bool AnimalGetsEaten = CheckIfPlacedAnimalGetsEaten(animal);
            bool OtherAnimalsGetEaten = CheckIfAnimalsInWagonGetEaten(animal);

            if (AvailablePlace == true && AnimalGetsEaten == false && OtherAnimalsGetEaten == false)
            {
                AddAnimal(animal);
                return true;
            }
                return false;
        }
    }
}
