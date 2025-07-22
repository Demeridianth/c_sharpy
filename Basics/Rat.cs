using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Basics
{
    public class Rat
    {
        public string Name { get; set; }
        public int Number { get; set; }  // property is like a variable
        public bool IsRadioactive { get; set; }

        // constructor
        // public Rat(string name, int number, bool isRadioactive)
        // {
        //     Name = name;
        //     Number = number;
        //     IsRadioactive = isRadioactive;

        // }
    }
}

namespace Basics
{
    public class AnotherRat
    {
        public string Name { get; set; }
        public int Number { get; set; }  // property is like a variable
        public bool IsRadioactive { get; set; }
    }
}