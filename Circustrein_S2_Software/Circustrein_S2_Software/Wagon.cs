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

        public void AddAnimal(Animal animal, Wagon wagon)
        {
            wagon.Animals.Add(animal);
            wagon.CurrentPoints += (int)animal.AnimalSize;
        }
    }
}
