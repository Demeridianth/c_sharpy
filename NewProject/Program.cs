using System;
using System.Buffers;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Windows.Markup;
using NewProject; // Needed for the .Contains() method




TimeUtility.PrintTime();

namespace NewProject
{
    public static class TimeUtility
    {
        public static void PrintTime() => Console.WriteLine(DateTime.Now.ToShortTimeString());
    }
}


namespace NewProject
{
    public class SavingAccount
    {
        public static double currInterestRate;     // var
        public static double bondRate;              // must be static in order to be used in a method

        static SavingAccount()                      // constructor
        {
            currInterestRate = 0.4;
        }

        public static void AddBondRate()            // method
        {
            currInterestRate = bondRate + 0.1;
        }
    }

}

















