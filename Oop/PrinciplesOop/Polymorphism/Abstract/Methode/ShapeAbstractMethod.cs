using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.PrinciplesOop.Polymorphism.Abstract.Methode
{
    abstract class ShapeAbstractMethod
    {
        public string PetName { get; set; }
        public ShapeAbstractMethod(string name = "NoName")
        {
            PetName = name;
        }

        public abstract void Draw();
    }
}
