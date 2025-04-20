// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello World");
// dotnet new console -o SecondApp  create new porject



//datatypes

using System.Data;
using System.Text;

string text = "word";
int number = 9;
float starBuckPrice = 2.9f;
long bigNumber = 2000000000000000000;
bool isTrue = true;

var someTypeOfData = "data";


//String

var item = "cup";
Console.WriteLine($"drink from the {item}");

string newItem = item.Replace("cup", "big cup");
newItem =  newItem.Remove(0, 2);
Console.WriteLine($"drink from the {newItem}");

StringBuilder newCoolItem = new StringBuilder();
newCoolItem.Append("very big cup");

//delete        with String BUilder remembers, with simple string, needs a new var
newCoolItem.Remove(0, 9);
// Console.WriteLine(newCoolItem);


//Array

//Create
string[] products = ["keyboards", "mouse", "laptop"];

//Read
foreach(var product in products)
{
    Console.WriteLine(product);
}

//Update
//Linq
var newItems = products.Where((e) => e.StartsWith("b")); 

products[0] = "keyboard";
foreach(var product in newItems)
{
    Console.WriteLine(product);
}


//FOR LOOPS

//old school
for(var i = 0; i <= 10; i++){
    Console.WriteLine(i);
}