using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.PrinciplesOop.Inheritance
{
    class ElectroCar
    {
        public readonly int maxSpeed;
        private int currSpeed;


        public ElectroCar(int max)
        {
            maxSpeed = max;
        }
        public ElectroCar()
        {

        }


        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }

        }
    }
}
