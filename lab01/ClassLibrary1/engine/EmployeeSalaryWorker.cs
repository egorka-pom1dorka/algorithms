using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSorting
{
    public static class EmployeeSalaryWorker
    {

        public static List<EmployeeSalary> Combine(List<Employee> employees, List<HoursSalaryCorrespondence> correspondences)
        {
            var salaries = new List<EmployeeSalary>();
            
            for (int i = 0; i < employees.Count; i++)
            {
                for (int j = 0; j < correspondences.Count; j++)
                {
                    if (employees[i].GetWorkedHours() == correspondences[j].GetHours())
                    {
                        var employeeSalary = new EmployeeSalary(employees[i], correspondences[j]);
                        salaries.Add(employeeSalary);
                        employees.RemoveAt(i);
                        correspondences.RemoveAt(j);
                        i--; j--;
                        break;
                    }
                }
            }

            foreach (var employee in employees)
            {
                var employeeSalary = new EmployeeSalary(employee, null);
                salaries.Add(employeeSalary);
            }

            foreach (var correspondence in correspondences)
            {
                var employeeSalary = new EmployeeSalary(null, correspondence);
                salaries.Add(employeeSalary);
            }

            return salaries;
        }

        public static void Split(List<EmployeeSalary> salaries, 
            ref List<Employee> employees, ref List<HoursSalaryCorrespondence> correspondences)
        {
            employees = new List<Employee>();
            correspondences = new List<HoursSalaryCorrespondence>();

            foreach (var salary in salaries)
            {
                if (salary.GetEmployee() != null)
                {
                    employees.Add(salary.GetEmployee());
                }
                
                if (salary.GetCorrespondence() != null)
                {
                    correspondences.Add(salary.GetCorrespondence());
                }
            }
        }

    }
}
