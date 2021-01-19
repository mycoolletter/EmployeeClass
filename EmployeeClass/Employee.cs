using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClass
{
    class Employee : MyBasedClass
    {
        private static int _employeeNumber;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HiringDate { get; set; }
        public string JobDescription { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(string firstName, string lastName, DateTime hiringDate, string jobDescription, string department, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            HiringDate = hiringDate;
            JobDescription = jobDescription;
            Department = department;
            Salary = salary;
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }     
        public string GetNameForSorting()
        {
            return $"{LastName}, {FirstName}";
        }
        //public override string ToString()
        //{
        //    return $"{FirstName} {LastName} {HiringDate}";
        //}
        public override string ToString()
        {
            return base.ToString();
        }
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract method in abstract class");
        }







    }
}
