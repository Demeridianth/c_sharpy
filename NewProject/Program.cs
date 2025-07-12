using System;
using System.Buffers;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using NewProject; // Needed for the .Contains() method



class Program
{
    static void Main()
    {
        Employee Clerk = new("Bob", 40, 30);
        

        int startedAge = Clerk.CalculateAgeStarted();
        Console.WriteLine(startedAge);
    }
    
}


    













