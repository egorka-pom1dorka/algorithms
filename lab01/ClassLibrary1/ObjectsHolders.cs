using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSorting
{
    public static class ObjectsHolders
    {

        public static List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            employees.Add(new Employee("Jonn", 21, 120));
            employees.Add(new Employee("Bob", 19, 80));
            employees.Add(new Employee("Mike", 24, 100));
            employees.Add(new Employee("Linda", 22, 130));
            employees.Add(new Employee("Josh", 23, 70));
            employees.Add(new Employee("Elizabet", 18, 110));
            employees.Add(new Employee("Dave", 20, 140));
            return employees;
        }

        public static List<HoursSalaryCorrespondence> GetCorrespondences()
        {
            var correspondences = new List<HoursSalaryCorrespondence>();
            correspondences.Add(new HoursSalaryCorrespondence(100, 1200));
            correspondences.Add(new HoursSalaryCorrespondence(70, 800));
            correspondences.Add(new HoursSalaryCorrespondence(120, 1500));
            correspondences.Add(new HoursSalaryCorrespondence(140, 1800));
            correspondences.Add(new HoursSalaryCorrespondence(80, 950));
            return correspondences;
        }

    }
}
