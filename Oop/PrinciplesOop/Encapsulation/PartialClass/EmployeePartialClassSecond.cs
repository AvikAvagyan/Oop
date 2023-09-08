using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.PrinciplesOop.Encapsulation.PartialClass
{
    partial class EmployeePartialClassFirst
    {
        public void PrintDetails()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Hire Date: {HireDate.ToShortDateString()}");
        }

    }
}
