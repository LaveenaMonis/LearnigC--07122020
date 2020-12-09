using System;
using System.Collections.Generic;
using System.Text;

namespace LearningcSharp.Day1
{
    public class Employee
    {
        private int salary;
        public int Salary
        {

            get {
                
                return salary;

            }

            set
            {
                this.salary = value;
                Console.WriteLine(Salary);
                Console.WriteLine(salary);
                
            }
            }

        public int Bonus { get; set; }

        public void CalculateSalary()
        {
            int totalSalry;
            totalSalry = Salary + Bonus;
            Console.WriteLine("Total Salary" + totalSalry);
        }
    }
}
