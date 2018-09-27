using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSorting
{
    public class EmployeeSalary
    {

        private Employee employee;
        private HoursSalaryCorrespondence correspondence;

        public EmployeeSalary(Employee employee, HoursSalaryCorrespondence correspondence)
        {
            this.employee = employee;
            this.correspondence = correspondence;
        }

        public Employee GetEmployee()
        {
            return employee;
        }

        public HoursSalaryCorrespondence GetCorrespondence()
        {
            return correspondence;
        }

        public void print()
        {
            printEmployee();
            printSalaryHoursCorrespondence();
        }

        public void printEmployee()
        {
            if (employee != null)
            {
                employee.print();
            }
            else
            {
                Console.Write("Employee: {null}. ");
            }
        }

        public void printSalaryHoursCorrespondence()
        {
            if (correspondence != null)
            {
                correspondence.print();
            }
            else
            {
                Console.Write("SalaryHoursCorrespondence: {null}");
            }
        }

    }
}
