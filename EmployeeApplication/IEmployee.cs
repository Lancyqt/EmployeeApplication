using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal interface IEmployee
    {

        string Firstname
        { get; set; }
        string Lastname 
        { get; set; } 
        string Department
        { get; set; }
        string JobTile
        { get; set; }
        double BasicSalary
        {  get; set; }

         void computeSalary(int hoursWorked, double ratePerHour);
    }

}
