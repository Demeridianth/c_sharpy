using System.Net.NetworkInformation;
using System.Data;
using System.Net;
using System.Text;
using Basics;
using System.Windows.Markup;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello World");

// CREATE NEW PROJECT
// dotnet new console -n SecondApp          
// dotnet watch run

// TO HAVE MULTIPLE PROJECTS
// dotnet new sln -n MyProjects
// dotnet sln add Project1/Project1.csproj
// dotnet sln add Project2/Project2.csproj

// ALTER RENAME
// dotnet sln remove OldProjectName\OldProjectName.csproj
// dotnet sln add NewProjectName\NewProjectName.csproj

//datatypes





// string text = "word";
// int number = 9;
// float starBuckPrice = 2.9f;
// long bigNumber = 2000000000000000000;
// bool isTrue = true;

// var someTypeOfData = "data";


//STRING

var item = "cup";
// Console.WriteLine($"drink from the {item}");

string newItem = item.Replace("cup", "big cup");
newItem =  newItem.Remove(0, 2);
// Console.WriteLine($"drink from the {newItem}");

StringBuilder newCoolItem = new StringBuilder();
newCoolItem.Append("very big cup");

//delete        with String BUilder remembers, with simple string, needs a new var
newCoolItem.Remove(0, 9);
// Console.WriteLine(newCoolItem);


//ARRAY

//Create
string[] products = ["keyboards", "mouse", "laptop"];

//Read
foreach(var product in products)
{
    // Console.WriteLine(product);
}

//Update
//Linq
var newItems = products.Where((e) => e.StartsWith("b")); 

products[0] = "keyboard";
foreach(var product in newItems)
{
    // Console.WriteLine(product);
};


//FOR LOOPS

string[] students = ["Bob", "Sally", "Jessy"];

//old school
for (var i = 0; i <= 10; i++){
    // Console.WriteLine(i);
};

for (var i = 0; i < students.Length; i++) {
    // Console.WriteLine(students[i]);
};


// newer
foreach(var student in students) {
    // Console.WriteLine(student);
}

// new Linq
students.ToList().ForEach((i) => {
    Console.WriteLine("ForEach: " + i);
});

// another way in one line
Array.ForEach(students, e => Console.WriteLine("Array.ForEach: " + e));



// IF/ELSE  

var isLoggedIn = false;
var isUserAdim = true;

if(isLoggedIn && isUserAdim)        // && = AND
{
    Console.WriteLine("True");
}
else if(isUserAdim || isUserAdim)       // || = OR
{
    Console.WriteLine("user is admin");
}
else
{
    Console.WriteLine("not true");
};


var employee = "Bob";
var workProgress = "slow";

if(workProgress == "fast")
{
    Console.WriteLine($"promote {employee}");
}
else if(workProgress == "normal")
{
    Console.WriteLine($"no action");
}
else
{
    Console.WriteLine($"fire {employee}");
}

// check datatype

string name = "Bob";
if (name is string)
{
    Console.WriteLine("its a string");
}



// Enum

// Console.WriteLine(Warning.CodeYellow);
// Console.WriteLine((int)Warning.CodeYellow);   // force to show the number, not used often

// var status = Warning.CodeYellow;
// if (status == Warning.CodeYellow)
// {
//     Console.WriteLine("its yellow");
// }

// enum Warning
// {
//     CodeRed,
//     CodeBlue,
//     CodeYellow
// };

// partial class Program
// {
//     static void Main()
//     {
//         var status = Warning.CodeYellow;
//         if (status == Warning.CodeYellow)
//         {
//             Console.WriteLine("yellow alert");
//         }
//     }
// }



/// SWITCH EXPRESSION

// old school
var weapon = "Axe";

switch (weapon)
{
    case "Sword":
        Console.WriteLine("Sword");
        break;
    case "Axe":
        Console.WriteLine("Axe");
        break;
    default:  // nothing matches
        Console.WriteLine("nothing matches");
        break;
}


// new
var new_weapon = "Sword";

var result = new_weapon switch
{
    "Axe" => "Axe",
    "Sword" => "Sword",
    _ => "No match"
};

Console.WriteLine("I found the " + result);



// While lopp 

// Pinger
// using System.Net.NetworkInformation;

Ping p1 = new Ping();
PingReply PR = p1.Send("8.8.8.8");

while (PR.Status.ToString() == "Success")
{
    Console.WriteLine(PR.Status.ToString() + "!");
    PR = p1.Send("8.8.8.8");
    Thread.Sleep(2000);
}



// CLASS

// In another class file:

// namespace Basics
// {
//     public class Rats
//     {
//         public string Name { get; set; }         // click "prop" to auto
//         public int Number { get; set; }          // property is like a variable
//         public bool IsRadioactive { get; set; }  

             // constructor
        //  public Rat(string name, int number, bool isRadioactive)
        // {
        //     Name = name;
        //     Number = number;
        //     IsRadioactive = isRadioactive;

        // }
//     }
// }

Rat wolfRat = new();     // new class instance, class object
// {
//     Name = "Skinny Rat",
//     Number = 20,
//     IsRadioactive = false
// };

// OR
wolfRat.Name = "Wolf Rat";
wolfRat.Number = 1000;
wolfRat.IsRadioactive = false;

//Read
Console.WriteLine(wolfRat.Name);

//Update
wolfRat.Name = "WOLF RAT";

//Delete
wolfRat.Name = "";

// OR with constructor



// METHOD

// from another class file

// namespace Basics
// {
//     public class RealEstate
//     {
//         public int Adress { get; set; }
//         public int Price { get; set; }
//         public int SquareFootage { get; set; }

//         public int CalculatePricePerFoot() => Price / SquareFootage;
//         // OR
//         // {
//         //       return Price / SquareFootage
//         // }
//     }
// }

RealEstate elmStreet = new()
{
    Adress = "elmStreet",
    Price = 20000,
    SquareFootage = 1300
};
Console.WriteLine(elmStreet.CalculatePricePerFoot());




// TUPLE
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


