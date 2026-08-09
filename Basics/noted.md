## Running APP
1. dotnet run
2. dotnet watch run

# Class
1. taken from another file in the project
2. in the same file

# get, set
public string? Name { get; set; }   // get - allows to read value, // set - allows to assign/change value

# string[]
is an array, you can READ it, can Update it (string[] = names; names[0] = Mike), BUT you cant create/add OR delete
can also create places in memory: string[] = PhoneNumbers; new string[1] = {"555-555"} // the 1 in the bracket tells how many slots are in array

# record
contains a piece of data, immutable-ISH, some things can be changed, a short class like object, that usually wont be changed