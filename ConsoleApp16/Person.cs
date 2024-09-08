using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    public class Person
    {
        public string FullName { get; set; }
        public int Average { get; set; }
        public Person(string fullName,int average)
        {
            FullName = fullName;
            Average = average;
        }
    }
}
