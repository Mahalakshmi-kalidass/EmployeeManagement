using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyOop
{
    // Step-3:Create a IFullTimeEmployee interface by inheriting IEmployee interface.
    public interface IFullTimeEmployee :IEmployee<Employee>
    {
        //Auto-implemented properties
        double Basic {  get; set; }
        double Hra {  get; set; }
        double Da {  get; set; }
        double NetSalary { get; set; }

        //declaring a method CalculateSalary()
        double CalculateSalary();
    }
}
