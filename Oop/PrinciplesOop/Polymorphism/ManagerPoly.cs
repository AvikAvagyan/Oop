using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.PrinciplesOop.Polymorphism
{
    class ManagerPoly : EmployeePoly
    {
        public override void PrintGivBonus(float amount)
        {
            base.PrintGivBonus(amount);
            Random r = new Random();
            Console.WriteLine(amount * r.Next(500));

        }
    }
}
