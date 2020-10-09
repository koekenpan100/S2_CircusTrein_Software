using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein_S2_Software
{
    public class Train
    {
        public List<Wagon> Wagons { get; private set; }

        public Train()
        {
            Wagons = new List<Wagon>();
        }
        public bool AddWagon(Wagon wagon)
        {
            if (wagon != null)
            {
                Wagons.Add(wagon);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("Train has the following wagons:{0}", Wagons.ToString());
        }
    }
}
