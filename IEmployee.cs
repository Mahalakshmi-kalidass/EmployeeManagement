using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyOop
{
    //Step-2:Create a Generic interface IEmployee of type Employee
    public interface IEmployee<T>
    {

        //Declaring a method
        string PrintEmployeeDetails(T employee);
    }
}
