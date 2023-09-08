using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.PrinciplesOop.Polymorphism.Abstract.Methode
{
    class HexagonAbstractMethod : ShapeAbstractMethod
    {
        public HexagonAbstractMethod() { }
        public HexagonAbstractMethod(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
    }
}
