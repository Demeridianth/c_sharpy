using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using NewProject;
using System.Diagnostics.CodeAnalysis; 



namespace NewProject
{
    public class Employee

    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Position { get; set; }

        public Employee() {}

        
        public Employee(string name, int id, string position)
        {
            Name = name;
            Id = id;
            Position = position;
        }
    }
}