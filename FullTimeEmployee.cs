using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyOop
{
    //step-6 Creating a derived class PartTimeEmployee by inherting IPartTimeEmployee
    //and implementing its methods and properties
    internal class FullTimeEmployee : IFullTimeEmployee
    {
        public double Basic { get; set; }
        public double Hra { get; set ; }
        public double Da { get; set; }

     
        public double NetSalary {  get; set; }
        

        /// <summary>
        /// Calucates the net salary of the full time employee
        /// </summary>
        /// <returns>returns the salary</returns>
        public double CalculateSalary()
        {
            return Basic + Hra + Da;
        }

        /// <summary>
        /// this method gives the details of the full time employee
        /// </summary>
        /// <param name="employee">Employee object whose details to be printed</param>
        /// <returns>return the string of employee details</returns>
        public string PrintEmployeeDetails(Employee employee)
        {
            return $"Employee Code : {employee.EmpCode}\n " +
                   $"Employee Name : {employee.EmpName}\n" +
                   $"Email : {employee.Email}\n" +
                   $"Department : {employee.DeptName}\n" +
                   $"Location : {employee.Location}\n" +
                   $"Basic Salary : {Basic}\n" +
                   $"HRA : {Hra}\n" +
                   $"DA : {Da}\n" +
                   $"Net Salary : {NetSalary}\n";       
        }
    }
}
