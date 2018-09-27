using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSorting
{
    public static class CombineSorting
    {

        public static List<EmployeeSalary> SortByAge(List<EmployeeSalary> employeesSalaries)
        {
            return MergeSort(employeesSalaries);
        }

        private static List<EmployeeSalary> MergeSort(List<EmployeeSalary> employeesSalaries)
        {
            if (employeesSalaries.Count <= 1)
                return employeesSalaries;

            var left = new List<EmployeeSalary>();
            var right = new List<EmployeeSalary>();

            int middle = employeesSalaries.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(employeesSalaries[i]);
            }

            for (int i = middle; i < employeesSalaries.Count; i++)
            {
                right.Add(employeesSalaries[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<EmployeeSalary> Merge(List<EmployeeSalary> left, List<EmployeeSalary> right)
        {
            List<EmployeeSalary> result = new List<EmployeeSalary>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0 && left.First().GetEmployee() != null && right.First().GetEmployee() != null)
                {
                    if (left.First().GetEmployee().GetAge() <= right.First().GetEmployee().GetAge())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }

    }
}
