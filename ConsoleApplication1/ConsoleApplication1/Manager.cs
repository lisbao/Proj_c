using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Manager : Resource
    {
        
       public Manager(int IdManager, string _Name, int _NumHours) : base (IdManager, _Name, _NumHours)
        {
              List<Employee> EmployeesList = new List<Employee>();
        }

        public Employee GetEmployee(int IdEmployee)
        { 
            
        }
    }
}
