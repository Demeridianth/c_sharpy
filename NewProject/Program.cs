using System;
using System.Buffers;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Windows.Markup;
using NewProject; // Needed for the .Contains() method



// class Program
// {
//     static void Main()
//     {
//         Employee Clerk = new("Bob", 40, 30);


//         int startedAge = Clerk.CalculateAgeStarted();
//         Console.WriteLine(startedAge);
//     }

// }

var values = ("a", 1, "z");      // can define datatype, dont neer var if do
Console.WriteLine(values.Item1);
Console.WriteLine(values.Item2);

(string, int, string) tupleValues = ("a", 1, "z");      // can define datatype, dont neer var if do
Console.WriteLine(tupleValues.Item1);
Console.WriteLine(tupleValues.Item2);

var moreValues = (First: "a", Second: 1, Third: "z");
Console.WriteLine(moreValues.First);

(string a, int b, bool c) ReturnValues()        // in a function
{
    return ("a", 1, true);
}
var valuesReturned = ReturnValues();            // function in a variable
Console.WriteLine(valuesReturned.a);
Console.WriteLine(valuesReturned.b);            // return tuple item

(string a, int b, bool c) = ReturnValues();     // arguments destructuring function
Console.WriteLine(a);                           // just use argument
Console.WriteLine(b);

















