using System;
using System.Buffers;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ExceptionServices;
using System.Windows.Markup;
using NewProject; // Needed for the .Contains() method




int? value = null;      // allows NULL

string value2 = null!;   // bang operator, not advised

Console.WriteLine(value2?.Length);

if (value2 is not null)
{
    Console.WriteLine(value2.Length);
}


Console.WriteLine(value2 ?? "No value!");       // logic in one line: if value == null print(No values)
Console.WriteLine(value2 is not null ? "Has value!" : "No value");       // logic in one line: if value not null, elif is null





















