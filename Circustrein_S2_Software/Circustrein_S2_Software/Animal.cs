using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_S2_Software
{
    public enum AnimalFood
    {
        Carnivore,
        Herbivore
    }

    public enum AnimalSize
    {
        Small = 1,
        Medium = 3,
        Large = 5
    }

    public class Animal
    {
        public  AnimalFood AnimalFood { get; }
        public AnimalSize AnimalSize { get; }

        public Animal(AnimalSize animalsize, AnimalFood animalfood)
        {
            AnimalFood = animalfood;
            AnimalSize = animalsize;
        }

        public bool CheckIfHerbivore()
        {
            if (AnimalFood == AnimalFood.Herbivore)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("Food:{0} Size:{1}", AnimalFood.ToString(), AnimalSize.ToString());
        }
    }
}
