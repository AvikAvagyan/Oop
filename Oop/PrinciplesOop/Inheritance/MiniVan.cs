using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.PrinciplesOop.Inheritance
{
    sealed class MiniVan : ElectroCar
    {
        public void TestMethod()
        {
            Speed = 10;
            //Error
            //currSpeed = 10;
        }
    }

    // Error! Cannot extend
    // a class marked with the sealed keyword!
    //class DeluxeMmiVan : MiniVan{}

}
