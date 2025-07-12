using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basics
{
    public class RealEstate
    {
        public string Adress { get; set; }
        public int Price { get; set; }
        public int SquareFootage { get; set; }

        public int CalculatePricePerFoot() => Price / SquareFootage;
        // OR
        // {
        //       return Price / SquareFootage
        // }
    }
}