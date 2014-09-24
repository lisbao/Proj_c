using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ResourceManagement res = new ResourceManagement();

            Employee r = new Employee(res.Increment(), "João", 8);
        }
    }
}
