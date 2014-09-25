using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Manager : Resource
    {
        
       public Manager(int idManager, string name, int numHours) : base (idManager, name, numHours)
        {
              List<Employee> EmployeesList = new List<Employee>();
        }

        //public Employee GetEmployee(int IdEmployee)
        //{ 
            
        //}
    }
}
