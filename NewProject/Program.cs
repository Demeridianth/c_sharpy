using System;
using System.Buffers;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Windows.Markup;
using NewProject; // Needed for the .Contains() method


//Record

Person person1 = new("Bob", "White", new string[1] {"555-555"});
// OR
Person person2 = new("Dequan", "Black", ["12", "666-666"]);  // newer way

Console.WriteLine(person2.PhoneNumbers[1]);

public record Person(string FirstName, string LastName, string[] PhoneNumbers);

















