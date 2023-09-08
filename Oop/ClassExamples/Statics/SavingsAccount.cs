using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.ClassExamples.Statics
{
    class SavingsAccount
    {
        public double currBalance;

        public static double currlnterestRate = 0.04;
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        public static void SetlnterestRate(double newRate)
        {
            currlnterestRate = newRate;
        }
        public static double GetlnterestRate()
        {
            return currlnterestRate;
        }
    }
}
