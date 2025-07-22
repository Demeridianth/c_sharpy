using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basics
{
    public class RealEstate
    {
        public required string Adress { get; set; }
        public required int Price { get; set; }
        public required int SquareFootage { get; set; }

        public int CalculatePricePerFoot() => Price / SquareFootage;
        // OR
        // {
        //       return Price / SquareFootage
        // }
    }
}