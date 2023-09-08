using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.ClassExamples.Statics
{
    class ChangeStatic
    {
        public double currBalance;
        public static double currlnterestRate = 0.04;


        public ChangeStatic(double balance)
        {
            currBalance = balance;
        }
        static ChangeStatic()
        {
            // The message "In static ctor! " is printed only once,
            // because the CLR calls all static constructors
            // before the first use (and never calls them again for a given application instance):
            Console.WriteLine("In static ctor!");
            currlnterestRate = 0.04;
        }

        public static double GetlnterestRate()
        {
            return currlnterestRate;

        }
        public static void SetlnterestRate(double newRate)
        {
            currlnterestRate = newRate;
        }
    }
}
