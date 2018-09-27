using Lab01;
using Lab01.IONumbers;
using Lab01.utils;
using ParallelSorting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var employees = ObjectsHolders.GetEmployees();
                var correspondences = ObjectsHolders.GetCorrespondences();
                var employeesSalaries = EmployeeSalaryWorker.Combine(employees, correspondences);

                PrintSalaries(employeesSalaries);
                employeesSalaries = CombineSorting.SortByAge(employeesSalaries);
                PrintSalaries(employeesSalaries);

                EmployeeSalaryWorker.Split(employeesSalaries, ref employees, ref correspondences);
                PrintEmployees(employees);
                PrintCorrespondences(correspondences);

                Console.WriteLine("That's all");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void PrintSalaries(List<EmployeeSalary> objs)
        {
            foreach (var obj in objs)
            {
                obj.print();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void PrintEmployees(List<Employee> objs)
        {
            foreach (var obj in objs)
            {
                obj.print();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void PrintCorrespondences(List<HoursSalaryCorrespondence> objs)
        {
            foreach (var obj in objs)
            {
                obj.print();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine("\n");
        }

        public static void PrintArray(long[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine("\n");
        }

    }
}
