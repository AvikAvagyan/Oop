using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.ClassExamples.Statics
{
    class StaticConstructors
    {
        public double currBalance;
        public static double currlnterestRate;


        public StaticConstructors
            (double balance)
        {
            currlnterestRate = 0.04;
            currBalance = balance;
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
