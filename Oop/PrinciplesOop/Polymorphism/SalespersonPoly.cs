using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.PrinciplesOop.Polymorphism
{
    class SalespersonPoly : EmployeePoly
    {
        public override void PrintGivBonus(float amount)
        {
            if (amount > 100)
            {
                Console.WriteLine("Amount is > 100 = " + amount);
            }
            else
            {
                Console.WriteLine(amount * 100);
            }
        }
    }
}
