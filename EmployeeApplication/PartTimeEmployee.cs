using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal class PartTimeEmployee : IEmployee
    {
        public string first_name;
        public string last_name;
        public string department;
        public string job_title;
        public double basic_salary;


        string FirstName {
            set
            {
                first_name = value;
            }
            get
            {
                return first_name;
            }
        }

        string LastName
        {
            set
            {
                last_name = value;
            }
            get
            {
                return last_name;
            }
        }
        string Department
        {
            set
            {
                department = value;
            }
            get
            {
                return department;
            }
        }
            string JobTitle
        {
            set
            {
                job_title = value;
            }
            get
            {
                return job_title;
            }
        }
        double BasicSalary
        {
            set
            {
                basic_salary = value;
            }
            get
            {
                return basic_salary;
            }
        }

        public string Firstname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Lastname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IEmployee.Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string JobTile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        double IEmployee.BasicSalary { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public PartTimeEmployee(string first_name, string last_name, string department, string job_title)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.department = department;
            this.job_title = job_title;
        }
        public void computeSalary(int hoursWorked, double ratePerHour)
        {
            basic_salary = hoursWorked * ratePerHour;
        }
        public double getSalary()
        {
            return basic_salary;
        }
    }
}
