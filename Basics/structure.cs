using System;


// old way
namespace MyApp
{
    class Program
    {
        static string name = "Bob";
        static int age = 30;

        static void Main(string[] args)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");

            SayHello();
        }

        static void SayHello()
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
// namespace
// └── class Program
//     ├── variables
//     ├── Main()          ← program starts here
//     └── SayHello()


// new way
string name = "Bob";
int age = 30;

Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");

SayHello();

void SayHello()
{
    Console.WriteLine($"Hello, {name}!");
}
