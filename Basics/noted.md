## for "to_do_" - write in old and then in new syntax

## Running APP
1. dotnet run
2. dotnet watch run

# Class
1. taken from another file in the project
2. in the same file

# get, set
public string? Name { get; set; }   // get - allows to read value, // set - allows to assign/change value

# static
static means it belongs to the class (like self.)
For example, without static:

public class Employee
{
    public string Name;
}

You need an object:

Employee bob = new Employee();
bob.Name = "Bob";

Employee alice = new Employee();
alice.Name = "Alice";

Each object has its own Name:

Employee
   ├── bob   → Name = "Bob"
   └── alice → Name = "Alice"

Now consider static:

public class Employee
{
    public static string Company = "Microsoft";
}

You don't need an Employee object to access it:

Console.WriteLine(Employee.Company);

# string[]
is an array, you can READ it, can Update it (string[] = names; names[0] = Mike), BUT you cant create/add OR delete
can also create places in memory: string[] = PhoneNumbers; new string[1] = {"555-555"} // the 1 in the bracket tells how many slots are in array

# record
contains a piece of data, immutable-ISH, some things can be changed, a short class like object, that usually wont be changed
equality:
Person p1 = new("Bob", "White");
Person p2 = new("Bob", "White");

Console.WriteLine(p1 == p2); // True

# public/private 
public  = accessible from outside the class
private = accessible only inside the class

# methods
public void DoSomething()     // returns nothing

public int GetAge()           // returns an int

public string GetName()       // returns a string

public Employee GetEmployee() // returns an Employee

public bool IsEmployeeValid() // returns true/false

# delegates
A delegate lets you store a function itself in a variable:
   │
   ├── Action          → built-in delegate returning void
   │
   ├── Func            → built-in delegate returning a value
   │
   └── SuperCustom     → your own delegate type

Lambda expression
   │
   └── x => x + 2      → convenient way of creating the function