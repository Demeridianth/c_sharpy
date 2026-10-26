using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace to_do
{
    public class TaskItem
    {
        public string? Name { get; set; }
        public string? Status { get; set; }
    
        public TaskItem(string name, string status)
        {
            Name = name;
            Status = Status;
        }
    }
}