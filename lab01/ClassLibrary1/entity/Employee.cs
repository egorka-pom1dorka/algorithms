using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSorting
{
    public class Employee
    {

        private string name;
        private int age;
        private int workedHours;

        public Employee(string name, int age, int workedHours)
        {
            this.name = name;
            this.age = age;
            this.workedHours = workedHours;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public int GetWorkedHours()
        {
            return workedHours;
        }

        public void print()
        {
            Console.Write("Employee: {");
            Console.Write($"name: {name}, age: {age}, hours: {workedHours}");
            Console.Write("}. ");
        }

    }
}
