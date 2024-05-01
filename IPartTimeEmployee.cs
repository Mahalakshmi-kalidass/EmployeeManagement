using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyOop
{
    //Step-4 create IPartTimeEmployee Interface inheriting IEmployee<Employee>
    internal interface IPartTimeEmployee : IEmployee<Employee>
    {
        //Auto-implemented Properties
        double Basic {  get; set; }
        double Da {  get; set; }
        double NetSalary { get; set; }

        //Method declaration
        /// <summary>
        /// this calculates the salary of the part time employee
        /// </summary>
        /// <returns>returns the salary</returns>
        double CalculateSalary();

    }
}
