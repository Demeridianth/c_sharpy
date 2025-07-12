using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewProject;



namespace NewProject
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public  int YearsWorked { get; set; }

        public Employee(string name, int age, int yearsWorked)      // constructor
        {
            Name = name;
            Age = age;
            YearsWorked = yearsWorked;
        }


        public int CalculateAgeStarted() => Age - YearsWorked;
    }
};