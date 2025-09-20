using System;
using System.Buffers;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Windows.Markup;
using NewProject; // Needed for the .Contains() method


class Program
{
    static void Main()
    {
        Employee manager = new("Bob", 42, 10);

        Console.WriteLine($"{manager.Name} started working here at {manager.CalculateAgeStarted()} years old");
    }
}

















