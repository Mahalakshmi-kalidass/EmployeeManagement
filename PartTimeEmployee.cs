using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyOop
{
    //step-5 Creating a derived class FullTimeEmployee by inherting IFullTimeEmployee
    ///and implementing its methods and properties
    internal class PartTimeEmployee : IPartTimeEmployee
    {
        public double Basic { get; set  ; }
        public double Da { get ; set  ; }

      
        public double NetSalary { get; set; }
      
      



        /// <summary>
        /// this method calculates the net salary of the part time employee
        /// </summary>
        /// <returns></returns>
        public double CalculateSalary()
        {
            return Basic + Da;
        }
        /// <summary>
        /// this method gives the details of the parttime employee
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
                   $"DA : {Da}\n" +
                   $"Net Salary : {NetSalary}\n";
        }
    }
}
