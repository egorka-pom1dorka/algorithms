using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSorting
{
    public class HoursSalaryCorrespondence
    {

        private int hours;
        private int salary;

        public HoursSalaryCorrespondence(int hours, int salary)
        {
            this.hours = hours;
            this.salary = salary;
        }

        public int GetHours()
        {
            return hours;
        }   

        public int GetSalary()
        {
            return salary;
        }

        public void print()
        {
            Console.Write("SalaryHoursCorrespondence: {");
            Console.Write($"hours: {hours}, salary: {salary}");
            Console.Write("}. ");
        }

    }
}
